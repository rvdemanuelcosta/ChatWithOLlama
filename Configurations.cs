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

namespace ChatWithLlama
{
    public partial class Configurations : Form
    {
        
        public Configurations()
        {
            InitializeComponent();
        }

        private void Configurations_Load(object sender, EventArgs e)
        {
            //modelsComboBox.Items.Add("llama3.2:1b");
            LoadModels();
            hideCMDCheckBox.Checked = true;

        }

        
        private void RunModel()
        {
            Process process = new Process();
            ProcessStartInfo pstartInfo = new ProcessStartInfo();
            if(hideCMDCheckBox.Checked)
            {
                pstartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            }
            pstartInfo.FileName = "cmd.exe";
            pstartInfo.Arguments = $"/C ollama run {modelsComboBox.SelectedItem.ToString()}";
            process.StartInfo = pstartInfo;
            process.Start();
            LoadModel();
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

                    // add the models to the models combo box
                    for (int i = 0; i < data.models.Count; i++)
                    {
                        modelsComboBox.Items.Add(data.models[i].name);
                    }
                    modelsComboBox.SelectedIndex = 0;
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
            Process stopModel = new Process();
            ProcessStartInfo stopModelInfo = new ProcessStartInfo();
            stopModelInfo.WindowStyle = ProcessWindowStyle.Hidden;
            stopModelInfo.FileName = "cmd.exe";
            stopModelInfo.Arguments = $"/C ollama stop {modelsComboBox.SelectedItem.ToString()}";
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
            Form1.modelName = modelsComboBox.SelectedItem.ToString();
            Form1.loadedModelTextLabel.Text = modelsComboBox.SelectedItem.ToString();
            Form1.loadedModelTextLabel.ForeColor = Color.Green;
        }

        private void unloadModelButton_Click(object sender, EventArgs e)
        {
            UnloadModel();

        }

        private void UnloadModel()
        {
            Form1.modelName = null;
            Form1.loadedModelTextLabel.Text = "None";
            Form1.loadedModelTextLabel.ForeColor = Color.Red;
        }
    }
}
