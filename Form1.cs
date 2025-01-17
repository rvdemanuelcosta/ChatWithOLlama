using System;
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

namespace ChatWithLlama
{
    public partial class Form1 : Form
    {
        List<Message> conversationHistory = new List<Message>();
        Configurations modelConfigurations;
        public static Label loadedModelTextLabel;
        public static string modelName { get; set; }
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //chatFLP.AutoScroll = true;    T o rmeove
            //chatFLP.HorizontalScroll.Visible = false; T o rmeove
            //chatFLP.VerticalScroll.Visible = true; T o rmeove 
            //chatFLP.HorizontalScroll.Enabled = false; T o rmeove
            //chatFLP.VerticalScroll.Enabled = true; T o rmeove
            //chatFLP.FlowDirection = FlowDirection.TopDown; T o rmeove
            this.HorizontalScroll.Enabled = false;
            Timer updateLocationTimer = new Timer();
            updateLocationTimer.Interval = 10;
            updateLocationTimer.Tick += UpdateLocation;
            updateLocationTimer.Start();
            loadedModelTextLabel = this.activeModelTextLabel;
            loadedModelTextLabel.Text = "None";
            loadedModelTextLabel.ForeColor = Color.Red;
        }

        private void UpdateLocation(object sender, EventArgs e)
        {
            if(modelConfigurations != null)
            {
                modelConfigurations.Location = new Point(this.Location.X + this.Size.Width, this.Location.Y);
            }
            
           
        }

        //protected override CreateParams CreateParams
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
                        messages = new List<Message>(conversationHistory) // Use the entire conversation history
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
           if(userInputBox.Text == "" || modelName == null)
            {
                MessageBox.Show("No models loaded or Message box is empty.");
            }
            else
            {
                /* To remove
                Label userNameLabel = new Label();
                userNameLabel.MaximumSize = new Size(358, 0);
                userNameLabel.Size = new Size(326, 0);
                userNameLabel.AutoSize = true;
                userNameLabel.Text = "User:";
                userNameLabel.Parent = this.chatFLP;
                */
                AppendColoredText(richTextBox1, "User: \n", Color.NavajoWhite);
                //userNameLabel.Location = new Point(0, userNameLabel.Location.Y); to remove
                /* To remove
                Label userTextLabel = new Label();
                userTextLabel.Size = new Size(326, 0);
                userTextLabel.MaximumSize = new Size(358, 0);
                userTextLabel.AutoSize = true;
                userTextLabel.Text = userInputBox.Text; */
                AppendColoredText(richTextBox1, $"{userInputBox.Text} \n", Color.Orange);
                //userTextLabel.Parent = this.chatFLP; To remove
                //userTextLabel.Location = new Point(0, userTextLabel.Location.Y); to remove
                
                conversationHistory.Add(new Message { role = "user", content = userInputBox.Text });
                string res = await SendToLlama();
                /*  To remove
                Label ollamaName = new Label();
                ollamaName.MaximumSize = new Size(358, 0);
                ollamaName.Size = new Size(326, 0);
                ollamaName.AutoSize = true;
                ollamaName.Text = "Bot:";
                ollamaName.Parent = this.chatFLP; */
                AppendColoredText(richTextBox1, "Bot: \n", Color.Lime);
                //ollamaName.Location = new Point(0, ollamaName.Location.Y);
                /* To remove
                Label ollamaText = new Label();
                ollamaText.MaximumSize = new Size(358, 0);
                ollamaText.Size = new Size(326, 0);
                ollamaText.AutoSize = true;
                ollamaText.Text = res;
                ollamaText.Parent = this.chatFLP;
                */
                AppendColoredText(richTextBox1, $"{res} \n", Color.DarkGreen);
                //ollamaText.Location = new Point(0, ollamaText.Location.Y);
                
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
            
            if (checkBox1.Checked)
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
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
