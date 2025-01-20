using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Diagnostics;
using ChatWithLlama.Properties;
using System.Configuration;

namespace ChatWithLlama
{
    public partial class Configurations : Form
    {
        Process stopModel;
        ProcessStartInfo pstartInfo;
        Process runModelprocess;
        Point windowPanelPoint;
        public Configurations()
        {
            InitializeComponent();
            FormClosing += Configurations_FormClosing;
        }

        private void Configurations_Load(object sender, EventArgs e)
        {
            //modelsComboBox.Items.Add("llama3.2:1b");
            LoadModels();
            hideCMDCheckBox.Checked = true;
            attachWindowsCheckBox.Checked = Properties.Settings.Default.attachedSettingsWindow;
            LoadColors();
            Properties.Settings.Default.Reload();
            formTitlePanel.MouseDown += FormTitlePanel_MouseDown;
            formTitlePanel.MouseMove += FormTitlePanel_MouseMove;
            formTitleLabel.Text = this.Text;
        }

        private void FormTitlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                    this.Location.X + (e.X - windowPanelPoint.X),
                    this.Location.Y + (e.Y - windowPanelPoint.Y));
            }
        }

        private void FormTitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            windowPanelPoint = new Point(e.X, e.Y);
        }

        private void RunModel()
        {
            if (runModelprocess != null && !runModelprocess.HasExited)
            {
                runModelprocess.Kill();
            }
            runModelprocess = new Process();
            pstartInfo = new ProcessStartInfo();
            if(hideCMDCheckBox.Checked)
            {
                //pstartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            }
            pstartInfo.FileName = "cmd.exe";
            pstartInfo.Arguments = $"/C ollama run {modelsComboBox.SelectedItem.ToString()}";
            pstartInfo.CreateNoWindow = true;
            pstartInfo.UseShellExecute = false;
            runModelprocess.StartInfo = pstartInfo;

            runModelprocess.Start();
            LoadModel();
        }
        private void Configurations_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Reload();
            
            if (runModelprocess != null && !runModelprocess.HasExited)
            {
                runModelprocess.Kill();
            }
        }
        
        private async void LoadModels()
        {
            modelsComboBox.Items.Clear();   
            try 
            {
                // get the available models from ollama api
                using ( var client = new HttpClient())
                    {
                    var response = await client.GetAsync("http://127.0.0.1:11434/api/tags");
                    response.EnsureSuccessStatusCode();

                    var responseBody = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(responseBody);
                    int selectedModelIndex = 0;

                    // add the models to the models combo box
                    for (int i = 0; i < data.models.Count; i++)
                    {
                        modelsComboBox.Items.Add(data.models[i].name);
                        if (data.models[i].name == Properties.Settings.Default.activeModel)
                        {
                            selectedModelIndex = i;
                        }
                    }
                    modelsComboBox.SelectedIndex = selectedModelIndex;
                    }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error connecting to server: {ex}");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            RunModel();
            

        }

        private void modelsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadModels();
        }

        private void stopModelButton_Click(object sender, EventArgs e)
        {
            StopModel();
        }

        private void StopModel()
        {
            UnloadModel();
            stopModel = new Process();
            ProcessStartInfo stopModelInfo = new ProcessStartInfo();
            //stopModelInfo.WindowStyle = ProcessWindowStyle.Hidden;
            stopModelInfo.FileName = "cmd.exe";
            stopModelInfo.Arguments = $"/C ollama stop {modelsComboBox.SelectedItem.ToString()}";
            stopModelInfo.UseShellExecute = false;
            stopModelInfo.CreateNoWindow = true;
            stopModel.StartInfo = stopModelInfo;
            stopModel.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListActiveModels();
        }

        private async void ListActiveModels()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync("http://127.0.0.1:11434/api/ps");
                    response.EnsureSuccessStatusCode();
                    var responseData = await response.Content.ReadAsStringAsync();
                    dynamic responseContent = JsonConvert.DeserializeObject(responseData);
                    string activeModels = "";
                    for (int i = 0; i < responseContent.models.Count; i++)
                    {
                        activeModels += $"{responseContent.models[i].name}\n";
                    }
                    if (activeModels.Length == 0)
                    {
                        MessageBox.Show("No active models.");
                    }
                    else
                    {
                        MessageBox.Show($"Active Models:\n{activeModels}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the server: {ex}");
            }
        }

        private void loadModelButton_Click(object sender, EventArgs e)
        {
            LoadModel();
        }
        private void LoadModel()
        {
            MainForm.modelName = modelsComboBox.SelectedItem.ToString();
            MainForm.loadedModelTextLabel.Text = modelsComboBox.SelectedItem.ToString();
            MainForm.loadedModelTextLabel.ForeColor = Color.Green;
        }

        private void unloadModelButton_Click(object sender, EventArgs e)
        {
            UnloadModel();

        }

        private void UnloadModel()
        {
            MainForm.modelName = null;
            MainForm.loadedModelTextLabel.Text = "None";
            MainForm.loadedModelTextLabel.ForeColor = Color.Red;
        }
        private void UpdateColors(Color userNameColor, Color userTextColor, Color botNameColor, Color botTextColor)
        {
            Properties.Settings.Default.userNameColor = userNameColor;
            Properties.Settings.Default.userTextColor = userTextColor;
            Properties.Settings.Default.botNameColor = botNameColor;
            Properties.Settings.Default.botTextColor = botTextColor;
            Properties.Settings.Default.Save();
            LoadColors();
            MessageBox.Show("Some settings require restart to take effect.");
        }

        private void LoadColors()
        {
            userNameColorLabel.ForeColor = Properties.Settings.Default.userNameColor;
            userTextColorLabel.ForeColor = Properties.Settings.Default.userTextColor;
            botNameColorLabel.ForeColor = Properties.Settings.Default.botNameColor;
            botTextColorLabel.ForeColor = Properties.Settings.Default.botTextColor;
        }
        private void userNameColorLabel_Click(object sender, EventArgs e)
        {
            ChangeLabelColor(userNameColorLabel);
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.activeModel = modelsComboBox.SelectedItem.ToString();
            UpdateColors(userNameColorLabel.ForeColor, userTextColorLabel.ForeColor, botNameColorLabel.ForeColor, botTextColorLabel.ForeColor);
            Properties.Settings.Default.Save();
            MessageBox.Show(Properties.Settings.Default.activeModel);
        }

        private void userTextColorLabel_Click_1(object sender, EventArgs e)
        {
            ChangeLabelColor(userTextColorLabel);
        }

        private void botNameColorLabel_Click(object sender, EventArgs e)
        {
            ChangeLabelColor(botNameColorLabel);
        }

        private void botTextColorLabel_Click(object sender, EventArgs e)
        {
            ChangeLabelColor(botTextColorLabel);
        }
        
        private void ChangeLabelColor(Label label)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                label.ForeColor = colorDialog1.Color;
            }
        }

        private void attachWindowsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (attachWindowsCheckBox.Checked)
            {
                Properties.Settings.Default.attachedSettingsWindow = true;
            }
            else
            {
                Properties.Settings.Default.attachedSettingsWindow = false;
            }
            
        }

        private void formMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
