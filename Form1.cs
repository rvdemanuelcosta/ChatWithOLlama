﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;

namespace ChatWithLlama
{
    public partial class MainForm : Form
    {
        List<Message> conversationHistory = new List<Message>();
        Configurations modelConfigurations;
        public static string systemMessageText = "";
        SystemMessageForm smf;
        public static Label loadedModelTextLabel;
        private Point mouseDownPoint;
        
        public static string modelName { get; set; }
        
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.HorizontalScroll.Enabled = false;
            Timer updateLocationTimer = new Timer();
            updateLocationTimer.Interval = 10;
            updateLocationTimer.Tick += UpdateLocation;
            updateLocationTimer.Start();
            loadedModelTextLabel = this.activeModelTextLabel;

            if(Properties.Settings.Default.activeModel != null && Properties.Settings.Default.activeModel != "")
            {
                modelName = Properties.Settings.Default.activeModel;
                loadedModelTextLabel.Text = modelName;
                loadedModelTextLabel.ForeColor = Color.Green;
            }
            else
            {
                modelName = "";
                loadedModelTextLabel.Text = "None";
                loadedModelTextLabel.ForeColor = Color.Red;
            }
            
            if (systemMessageCheckBox.Checked)
            {
                UpdateSystemMessageText();
            }
            UpdateChatHistoryFont();
            windowTitlePanel.MouseDown += WindowTitlePanel_MouseDown;
            windowTitlePanel.MouseMove += WindowTitlePanel_MouseMove;
            formTitleLabel.MouseDown += WindowTitlePanel_MouseDown;
            formTitleLabel.MouseMove += WindowTitlePanel_MouseMove;
            formTitleLabel.Text = this.Text;
            chatSizeComboBox.SelectedItem = Properties.Settings.Default.chatSizeName;
            ChangeChatSize(Properties.Settings.Default.chatSizeName);
        }

        private void WindowTitlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                    this.Location.X + (e.X - mouseDownPoint.X),
                    this.Location.Y + (e.Y - mouseDownPoint.Y));
            }
        }

        private void WindowTitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }

        private void ExportChatAsJson()
        {
            string jsonstring = JsonConvert.SerializeObject(conversationHistory, Formatting.Indented);
            SaveFileDialog dialog = new SaveFileDialog();
            string savePath = "C:/";
            
            dialog.Filter = "Json Files (*.json)|*.json|All Files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                savePath = dialog.FileName;
                File.WriteAllText(savePath, jsonstring);
                MessageBox.Show($" Chat exported as {dialog.FileName}");
            }
        }

        private void ImportChatFromJson()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog(this) == DialogResult.OK)
            {
                List<Message> messages = new List<Message>();
                string jsonstring = File.ReadAllText(dialog.FileName);
                messages = JsonConvert.DeserializeObject<List<Message>>(jsonstring);
                foreach (Message message in messages)
                {
                    conversationHistory.Add(message);
                }
                
                foreach(Message message in conversationHistory)
                {
                    if(message.role != "system")
                    {
                        //chatHistoryOutput.Text += $"{message.role}:\n{message.content}\n";
                        
                    }
                    if(message.role == "user")
                    {
                        AppendColoredText(chatHistoryOutput, $"{message.role}\n", Properties.Settings.Default.userNameColor);
                        AppendColoredText(chatHistoryOutput, $"{message.content}\n", Properties.Settings.Default.userTextColor);
                    }
                    if(message.role == "assistant")
                    {
                        AppendColoredText(chatHistoryOutput, $"{message.role}\n", Properties.Settings.Default.botNameColor);
                        AppendColoredText(chatHistoryOutput, $"{message.content}\n", Properties.Settings.Default.botTextColor);
                    }
                    
                }
            }
        }

        private void UpdateLocation(object sender, EventArgs e)
        {
            if(modelConfigurations != null && Properties.Settings.Default.attachedSettingsWindow == true)
            {
                modelConfigurations.Location = new Point(this.Location.X + this.Size.Width, this.Location.Y);
            }
            
           
        }

        //protected override CreateParams CreateParams  experimenting transparent chat background
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x20; // WS_EX_TRANSPARENT
        //        return cp;
        //    }
        //}
        public async Task<string> SendToLlama()
        {
            
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri("http://127.0.0.1:11434");
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                    var request = new ChatRequest
                    {
                        model = modelName,
                        stream = false,
                        messages = new List<Message>(conversationHistory), // Use the entire conversation history
                        /*
                        messages = new List<Message>
                        {
                            new Message
                            {
                                role = "user",
                                content = userInputBox.Text
                            }
                        }*/
                    };
                    //MessageBox.Show(request.ToString());
                    var jsonContent = JsonConvert.SerializeObject(request);
                    var stringContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync("/api/chat", stringContent);
                    response.EnsureSuccessStatusCode();
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var responseObject = JsonConvert.DeserializeObject<Dictionary< string, Object>>(responseContent);
                    //MessageBox.Show(responseObject["message"].ToString());
                    var botResponse = JsonConvert.DeserializeObject<Dictionary<string, Object>>(responseObject["message"].ToString());
                    //MessageBox.Show(botResponse["content"].ToString());
                    conversationHistory.Add(new Message { role = "assistant", content = botResponse["content"].ToString() });
                    return botResponse["content"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the server: {ex}");
            }

            
            return null;
        }
        private void AppendColoredText(RichTextBox rtb, string text, Color color)
        {
            int start = rtb.TextLength;
            rtb.AppendText(text);
            int end = rtb.TextLength;

            // Select the appended text
            rtb.Select(start, end - start);

            // Apply color
            rtb.SelectionColor = color;
        }

        private async void userSendButton_Click(object sender, EventArgs e)
        {
           if(modelName == null || userInputBox.Text == "")
            {
                MessageBox.Show("No models loaded or Message box is empty.");
            }
            else
            {
                AppendColoredText(chatHistoryOutput, "user: \n", Properties.Settings.Default.userNameColor);
                AppendColoredText(chatHistoryOutput, $"{userInputBox.Text} \n", Properties.Settings.Default.userTextColor);
                
                if (systemMessageCheckBox.Checked)
                {
                    UpdateSystemMessageText();
                }
                conversationHistory.Add(new Message { role = "system", content = systemMessageText });
                conversationHistory.Add(new Message { role = "user", content = userInputBox.Text });
                
                string res = await SendToLlama();
                AppendColoredText(chatHistoryOutput, "assistant: \n", Properties.Settings.Default.botNameColor);
                AppendColoredText(chatHistoryOutput, $"{res} \n", Properties.Settings.Default.botTextColor);
                userInputBox.Text = "";
                
            }
        }

        public static void UpdateSystemMessageText()
        {
            if(systemMessageText != Properties.Settings.Default.systemMessageText)
            {
                systemMessageText = Properties.Settings.Default.systemMessageText;
            }
        }

        private void topMostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(topMostCheckBox.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (modelConfigurations == null || modelConfigurations.IsDisposed)
            {
                modelConfigurations = new Configurations();
                modelConfigurations.Show();
                modelConfigurations.Location = new Point(this.Location.X + this.Size.Width, this.Location.Y);
            }
            else
            {
                if(!modelConfigurations.IsDisposed)
                {
                    modelConfigurations.Dispose();
                }
                else
                {
                    modelConfigurations.Show();
                    
                }
                ;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ToggleChatWindowLockState();
        }

        private void ToggleChatWindowLockState()
        {
            
            if (lockChatCheckBox.Checked)
            {
                //this.FormBorderStyle = FormBorderStyle.None;
                windowTitlePanel.MouseDown -= WindowTitlePanel_MouseDown;
                windowTitlePanel.MouseMove -= WindowTitlePanel_MouseMove;
            }
            else
            {
                //this.FormBorderStyle = FormBorderStyle.FixedSingle;
                windowTitlePanel.MouseDown += WindowTitlePanel_MouseDown;
                windowTitlePanel.MouseMove += WindowTitlePanel_MouseMove;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateChatHistoryFont()
        {
            chatHistoryOutput.Font = Properties.Settings.Default.chatHistoryFont;
        }

        private void userInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if(systemMessageCheckBox.Checked)
            {
                UpdateSystemMessageText();
            }
            else
            {
                systemMessageText = "";
            }
        }

        private void chatSettingsButton_Click(object sender, EventArgs e)
        {
            if (chatSettingsPanel.Visible)
            {
                chatSettingsPanel.Visible = false;
            }
            else
            {
                chatSettingsPanel.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (smf == null || smf.IsDisposed)
            {
                smf = new SystemMessageForm();

                smf.Show();
                smf.Location = new Point(this.Location.X, this.Location.Y + this.Size.Height);
            }
            else
            {
                smf.Dispose();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chatHistoryContMenuFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                chatHistoryOutput.Font = fontDialog.Font;
                Properties.Settings.Default.chatHistoryFont = fontDialog.Font;
                Properties.Settings.Default.Save();
            }
        }

        private void clearChatButton_Click(object sender, EventArgs e)
        {
            ClearChat();
            
            
        }
        private void ClearChat()
        {
            chatHistoryOutput.Text = "";
            conversationHistory.Clear();
            
        }

        private void chatExportButton_Click(object sender, EventArgs e)
        {
            ExportChatAsJson();
        }

        private void mainFormCloseButton_Click_3(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void chatImportButton_Click(object sender, EventArgs e)
        {
            ImportChatFromJson();
        }

        private void chatSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeChatSize(chatSizeComboBox.SelectedItem.ToString());
        }

        private void ChangeChatSize(string size)
        {
            if(Properties.Settings.Default.chatSizeName != size)
            {
                Properties.Settings.Default.chatSizeName = size;
                Properties.Settings.Default.Save();
                
            }
            switch (size)
            {
                case "Small": this.Size = new Size(352, 462); break;
                case "Medium": this.Size = new Size(640, 462); break;
                case "Big": this.Size = new Size(967, 538); break;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }

    public class ChatRequest
    {
        public string model { get; set; }
        public List<Message> messages { get; set; }
        public bool stream { get; set; }
    }

    public class Message
    {
        public string role { get; set; }
        public string content { get; set; }
    }

}
