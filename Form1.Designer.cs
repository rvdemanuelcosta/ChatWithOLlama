namespace ChatWithLlama
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.userSendButton = new System.Windows.Forms.Button();
            this.userInputBox = new System.Windows.Forms.TextBox();
            this.chatHistoryOutput = new System.Windows.Forms.RichTextBox();
            this.chatHistoryContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chatHistoryContMenuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.topMostCheckBox = new System.Windows.Forms.CheckBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.activeModelLabel = new System.Windows.Forms.Label();
            this.activeModelTextLabel = new System.Windows.Forms.Label();
            this.lockChatCheckBox = new System.Windows.Forms.CheckBox();
            this.systemMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.chatSettingsPanel = new System.Windows.Forms.Panel();
            this.chatExportButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.systemMessageModifyButton = new System.Windows.Forms.Button();
            this.chatSettingsButton = new System.Windows.Forms.Button();
            this.clearChatButton = new System.Windows.Forms.Button();
            this.windowTitlePanel = new System.Windows.Forms.Panel();
            this.mainFormClosebutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.formTitleLabel = new System.Windows.Forms.Label();
            this.chatHistoryContextMenu.SuspendLayout();
            this.chatSettingsPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.windowTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userSendButton
            // 
            this.userSendButton.BackColor = System.Drawing.Color.White;
            this.userSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userSendButton.Location = new System.Drawing.Point(296, 340);
            this.userSendButton.Name = "userSendButton";
            this.userSendButton.Size = new System.Drawing.Size(75, 23);
            this.userSendButton.TabIndex = 0;
            this.userSendButton.Text = "Send";
            this.userSendButton.UseVisualStyleBackColor = false;
            this.userSendButton.Click += new System.EventHandler(this.userSendButton_Click);
            // 
            // userInputBox
            // 
            this.userInputBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputBox.ForeColor = System.Drawing.Color.Black;
            this.userInputBox.Location = new System.Drawing.Point(12, 332);
            this.userInputBox.Multiline = true;
            this.userInputBox.Name = "userInputBox";
            this.userInputBox.Size = new System.Drawing.Size(359, 40);
            this.userInputBox.TabIndex = 1;
            this.userInputBox.TextChanged += new System.EventHandler(this.userInputBox_TextChanged);
            // 
            // chatHistoryOutput
            // 
            this.chatHistoryOutput.BackColor = System.Drawing.SystemColors.Control;
            this.chatHistoryOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatHistoryOutput.ContextMenuStrip = this.chatHistoryContextMenu;
            this.chatHistoryOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatHistoryOutput.Location = new System.Drawing.Point(12, 77);
            this.chatHistoryOutput.Name = "chatHistoryOutput";
            this.chatHistoryOutput.ReadOnly = true;
            this.chatHistoryOutput.Size = new System.Drawing.Size(359, 220);
            this.chatHistoryOutput.TabIndex = 3;
            this.chatHistoryOutput.Text = "";
            this.chatHistoryOutput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // chatHistoryContextMenu
            // 
            this.chatHistoryContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chatHistoryContMenuFont});
            this.chatHistoryContextMenu.Name = "chatHistoryContextMenu";
            this.chatHistoryContextMenu.Size = new System.Drawing.Size(99, 26);
            // 
            // chatHistoryContMenuFont
            // 
            this.chatHistoryContMenuFont.Name = "chatHistoryContMenuFont";
            this.chatHistoryContMenuFont.Size = new System.Drawing.Size(98, 22);
            this.chatHistoryContMenuFont.Text = "Font";
            this.chatHistoryContMenuFont.Click += new System.EventHandler(this.chatHistoryContMenuFont_Click);
            // 
            // topMostCheckBox
            // 
            this.topMostCheckBox.AutoSize = true;
            this.topMostCheckBox.Location = new System.Drawing.Point(17, 105);
            this.topMostCheckBox.Name = "topMostCheckBox";
            this.topMostCheckBox.Size = new System.Drawing.Size(68, 17);
            this.topMostCheckBox.TabIndex = 4;
            this.topMostCheckBox.Text = "TopMost";
            this.topMostCheckBox.UseVisualStyleBackColor = true;
            this.topMostCheckBox.CheckedChanged += new System.EventHandler(this.topMostCheckBox_CheckedChanged);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.DarkGray;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(12, 46);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(27, 25);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "*";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // activeModelLabel
            // 
            this.activeModelLabel.AutoSize = true;
            this.activeModelLabel.Location = new System.Drawing.Point(46, 57);
            this.activeModelLabel.Name = "activeModelLabel";
            this.activeModelLabel.Size = new System.Drawing.Size(72, 13);
            this.activeModelLabel.TabIndex = 6;
            this.activeModelLabel.Text = "Active Model:";
            // 
            // activeModelTextLabel
            // 
            this.activeModelTextLabel.AutoSize = true;
            this.activeModelTextLabel.Location = new System.Drawing.Point(124, 57);
            this.activeModelTextLabel.Name = "activeModelTextLabel";
            this.activeModelTextLabel.Size = new System.Drawing.Size(0, 13);
            this.activeModelTextLabel.TabIndex = 7;
            // 
            // lockChatCheckBox
            // 
            this.lockChatCheckBox.AutoSize = true;
            this.lockChatCheckBox.Location = new System.Drawing.Point(17, 82);
            this.lockChatCheckBox.Name = "lockChatCheckBox";
            this.lockChatCheckBox.Size = new System.Drawing.Size(75, 17);
            this.lockChatCheckBox.TabIndex = 8;
            this.lockChatCheckBox.Text = "Lock Chat";
            this.lockChatCheckBox.UseVisualStyleBackColor = true;
            this.lockChatCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // systemMessageCheckBox
            // 
            this.systemMessageCheckBox.AutoSize = true;
            this.systemMessageCheckBox.Location = new System.Drawing.Point(14, 19);
            this.systemMessageCheckBox.Name = "systemMessageCheckBox";
            this.systemMessageCheckBox.Size = new System.Drawing.Size(111, 17);
            this.systemMessageCheckBox.TabIndex = 9;
            this.systemMessageCheckBox.Text = "System message?";
            this.systemMessageCheckBox.UseVisualStyleBackColor = true;
            this.systemMessageCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // chatSettingsPanel
            // 
            this.chatSettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatSettingsPanel.Controls.Add(this.chatExportButton);
            this.chatSettingsPanel.Controls.Add(this.groupBox1);
            this.chatSettingsPanel.Controls.Add(this.lockChatCheckBox);
            this.chatSettingsPanel.Controls.Add(this.topMostCheckBox);
            this.chatSettingsPanel.Location = new System.Drawing.Point(206, 113);
            this.chatSettingsPanel.Name = "chatSettingsPanel";
            this.chatSettingsPanel.Size = new System.Drawing.Size(165, 184);
            this.chatSettingsPanel.TabIndex = 10;
            this.chatSettingsPanel.Visible = false;
            // 
            // chatExportButton
            // 
            this.chatExportButton.BackColor = System.Drawing.Color.DarkGray;
            this.chatExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chatExportButton.Location = new System.Drawing.Point(17, 142);
            this.chatExportButton.Name = "chatExportButton";
            this.chatExportButton.Size = new System.Drawing.Size(111, 23);
            this.chatExportButton.TabIndex = 12;
            this.chatExportButton.Text = "Export Chat as Json";
            this.chatExportButton.UseVisualStyleBackColor = false;
            this.chatExportButton.Click += new System.EventHandler(this.chatExportButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.systemMessageCheckBox);
            this.groupBox1.Controls.Add(this.systemMessageModifyButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 73);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // systemMessageModifyButton
            // 
            this.systemMessageModifyButton.BackColor = System.Drawing.Color.DarkGray;
            this.systemMessageModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.systemMessageModifyButton.Location = new System.Drawing.Point(93, 44);
            this.systemMessageModifyButton.Name = "systemMessageModifyButton";
            this.systemMessageModifyButton.Size = new System.Drawing.Size(60, 23);
            this.systemMessageModifyButton.TabIndex = 10;
            this.systemMessageModifyButton.Text = "Modify";
            this.systemMessageModifyButton.UseVisualStyleBackColor = false;
            this.systemMessageModifyButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // chatSettingsButton
            // 
            this.chatSettingsButton.BackColor = System.Drawing.Color.DarkGray;
            this.chatSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chatSettingsButton.Location = new System.Drawing.Point(341, 303);
            this.chatSettingsButton.Name = "chatSettingsButton";
            this.chatSettingsButton.Size = new System.Drawing.Size(30, 23);
            this.chatSettingsButton.TabIndex = 11;
            this.chatSettingsButton.Text = "| | |";
            this.chatSettingsButton.UseVisualStyleBackColor = false;
            this.chatSettingsButton.Click += new System.EventHandler(this.chatSettingsButton_Click);
            // 
            // clearChatButton
            // 
            this.clearChatButton.BackColor = System.Drawing.Color.DarkGray;
            this.clearChatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearChatButton.Location = new System.Drawing.Point(260, 303);
            this.clearChatButton.Name = "clearChatButton";
            this.clearChatButton.Size = new System.Drawing.Size(75, 23);
            this.clearChatButton.TabIndex = 12;
            this.clearChatButton.Text = "Clear";
            this.clearChatButton.UseVisualStyleBackColor = false;
            this.clearChatButton.Click += new System.EventHandler(this.clearChatButton_Click);
            // 
            // windowTitlePanel
            // 
            this.windowTitlePanel.BackColor = System.Drawing.Color.DarkGray;
            this.windowTitlePanel.Controls.Add(this.formTitleLabel);
            this.windowTitlePanel.Controls.Add(this.button1);
            this.windowTitlePanel.Controls.Add(this.mainFormClosebutton);
            this.windowTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.windowTitlePanel.Name = "windowTitlePanel";
            this.windowTitlePanel.Size = new System.Drawing.Size(383, 40);
            this.windowTitlePanel.TabIndex = 13;
            // 
            // mainFormClosebutton
            // 
            this.mainFormClosebutton.BackColor = System.Drawing.Color.Silver;
            this.mainFormClosebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainFormClosebutton.Location = new System.Drawing.Point(334, 9);
            this.mainFormClosebutton.Name = "mainFormClosebutton";
            this.mainFormClosebutton.Size = new System.Drawing.Size(42, 23);
            this.mainFormClosebutton.TabIndex = 0;
            this.mainFormClosebutton.Text = "X";
            this.mainFormClosebutton.UseVisualStyleBackColor = false;
            this.mainFormClosebutton.Click += new System.EventHandler(this.mainFormCloseButton_Click_3);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(296, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "----";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // formTitleLabel
            // 
            this.formTitleLabel.AutoSize = true;
            this.formTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitleLabel.Location = new System.Drawing.Point(12, 14);
            this.formTitleLabel.Name = "formTitleLabel";
            this.formTitleLabel.Size = new System.Drawing.Size(46, 18);
            this.formTitleLabel.TabIndex = 2;
            this.formTitleLabel.Text = "label1";
            // 
            // MainForm
            // 
            this.AcceptButton = this.userSendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(383, 385);
            this.Controls.Add(this.windowTitlePanel);
            this.Controls.Add(this.clearChatButton);
            this.Controls.Add(this.chatSettingsButton);
            this.Controls.Add(this.chatSettingsPanel);
            this.Controls.Add(this.userInputBox);
            this.Controls.Add(this.activeModelTextLabel);
            this.Controls.Add(this.activeModelLabel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.userSendButton);
            this.Controls.Add(this.chatHistoryOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Chat With Ollama";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.chatHistoryContextMenu.ResumeLayout(false);
            this.chatSettingsPanel.ResumeLayout(false);
            this.chatSettingsPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.windowTitlePanel.ResumeLayout(false);
            this.windowTitlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userSendButton;
        private System.Windows.Forms.TextBox userInputBox;
        private System.Windows.Forms.RichTextBox chatHistoryOutput;
        private System.Windows.Forms.CheckBox topMostCheckBox;
        private System.Windows.Forms.Label activeModelLabel;
        private System.Windows.Forms.Label activeModelTextLabel;
        private System.Windows.Forms.CheckBox lockChatCheckBox;
        private System.Windows.Forms.CheckBox systemMessageCheckBox;
        public System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Panel chatSettingsPanel;
        private System.Windows.Forms.Button chatSettingsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button systemMessageModifyButton;
        private System.Windows.Forms.ContextMenuStrip chatHistoryContextMenu;
        private System.Windows.Forms.ToolStripMenuItem chatHistoryContMenuFont;
        private System.Windows.Forms.Button clearChatButton;
        private System.Windows.Forms.Button chatExportButton;
        private System.Windows.Forms.Panel windowTitlePanel;
        private System.Windows.Forms.Button mainFormClosebutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label formTitleLabel;
    }
}

