using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatWithLlama
{
    public partial class SystemMessageForm : Form
    {
        public SystemMessageForm()
        {
            InitializeComponent();
        }

        private void systemMessageSaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.systemMessageText = systemMessageInput.Text;
            Properties.Settings.Default.Save();
        }

        private void SystemMessageForm_Load(object sender, EventArgs e)
        {
            systemMessageInput.Text = Properties.Settings.Default.systemMessageText;
        }
    }
}
