namespace ChatWithLlama
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.userSendButton = new System.Windows.Forms.Button();
            this.userInputBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.topMostCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.activeModelLabel = new System.Windows.Forms.Label();
            this.activeModelTextLabel = new System.Windows.Forms.Label();
            this.lockChatCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // userSendButton
            // 
            this.userSendButton.BackColor = System.Drawing.Color.White;
            this.userSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userSendButton.Location = new System.Drawing.Point(296, 516);
            this.userSendButton.Name = "userSendButton";
            this.userSendButton.Size = new System.Drawing.Size(75, 23);
            this.userSendButton.TabIndex = 0;
            this.userSendButton.Text = "Send";
            this.userSendButton.UseVisualStyleBackColor = false;
            this.userSendButton.Click += new System.EventHandler(this.userSendButton_Click);
            // 
            // userInputBox
            // 
            this.userInputBox.BackColor = System.Drawing.Color.White;
            this.userInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInputBox.ForeColor = System.Drawing.Color.Black;
            this.userInputBox.Location = new System.Drawing.Point(12, 516);
            this.userInputBox.Name = "userInputBox";
            this.userInputBox.Size = new System.Drawing.Size(278, 20);
            this.userInputBox.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(359, 455);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // topMostCheckBox
            // 
            this.topMostCheckBox.AutoSize = true;
            this.topMostCheckBox.Location = new System.Drawing.Point(13, 493);
            this.topMostCheckBox.Name = "topMostCheckBox";
            this.topMostCheckBox.Size = new System.Drawing.Size(68, 17);
            this.topMostCheckBox.TabIndex = 4;
            this.topMostCheckBox.Text = "TopMost";
            this.topMostCheckBox.UseVisualStyleBackColor = true;
            this.topMostCheckBox.CheckedChanged += new System.EventHandler(this.topMostCheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 25);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // activeModelLabel
            // 
            this.activeModelLabel.AutoSize = true;
            this.activeModelLabel.Location = new System.Drawing.Point(46, 12);
            this.activeModelLabel.Name = "activeModelLabel";
            this.activeModelLabel.Size = new System.Drawing.Size(72, 13);
            this.activeModelLabel.TabIndex = 6;
            this.activeModelLabel.Text = "Active Model:";
            // 
            // activeModelTextLabel
            // 
            this.activeModelTextLabel.AutoSize = true;
            this.activeModelTextLabel.Location = new System.Drawing.Point(124, 12);
            this.activeModelTextLabel.Name = "activeModelTextLabel";
            this.activeModelTextLabel.Size = new System.Drawing.Size(0, 13);
            this.activeModelTextLabel.TabIndex = 7;
            // 
            // lockChatCheckBox
            // 
            this.lockChatCheckBox.AutoSize = true;
            this.lockChatCheckBox.Location = new System.Drawing.Point(88, 493);
            this.lockChatCheckBox.Name = "lockChatCheckBox";
            this.lockChatCheckBox.Size = new System.Drawing.Size(75, 17);
            this.lockChatCheckBox.TabIndex = 8;
            this.lockChatCheckBox.Text = "Lock Chat";
            this.lockChatCheckBox.UseVisualStyleBackColor = true;
            this.lockChatCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.userSendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 548);
            this.Controls.Add(this.lockChatCheckBox);
            this.Controls.Add(this.activeModelTextLabel);
            this.Controls.Add(this.activeModelLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.topMostCheckBox);
            this.Controls.Add(this.userSendButton);
            this.Controls.Add(this.userInputBox);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Chat With Ollama";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userSendButton;
        private System.Windows.Forms.TextBox userInputBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox topMostCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label activeModelLabel;
        private System.Windows.Forms.Label activeModelTextLabel;
        private System.Windows.Forms.CheckBox lockChatCheckBox;
    }
}

