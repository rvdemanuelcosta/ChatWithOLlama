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
        Point windowMouseDownPoint = new Point();
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
            formTitlePanel.MouseDown += FormTitlePanel_MouseDown;
            formTitlePanel.MouseMove += FormTitlePanel_MouseMove;
            formTitleLabel.Text = this.Text;
        }

        private void FormTitlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                    this.Location.X + (e.X - windowMouseDownPoint.X),
                    this.Location.Y + (e.Y - windowMouseDownPoint.Y));
            }
        }

        private void FormTitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            windowMouseDownPoint = new Point(e.X, e.Y);
        }

        private void formMinimizebutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formClosebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
