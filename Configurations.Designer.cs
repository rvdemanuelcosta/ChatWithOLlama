﻿using System.Runtime.CompilerServices;

namespace ChatWithLlama
{
    partial class Configurations
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
            this.modelsComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.runModelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hideCMDCheckBox = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.unloadModelButton = new System.Windows.Forms.Button();
            this.loadModelButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.userNameColorLabel = new System.Windows.Forms.Label();
            this.userTextColorLabel = new System.Windows.Forms.Label();
            this.botNameColorLabel = new System.Windows.Forms.Label();
            this.botTextColorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.attachWindowsCheckBox = new System.Windows.Forms.CheckBox();
            this.formTitlePanel = new System.Windows.Forms.Panel();
            this.formMinimizeButton = new System.Windows.Forms.Button();
            this.formCloseButton = new System.Windows.Forms.Button();
            this.formTitleLabel = new System.Windows.Forms.Label();
            this.formTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelsComboBox
            // 
            this.modelsComboBox.FormattingEnabled = true;
            this.modelsComboBox.Location = new System.Drawing.Point(12, 120);
            this.modelsComboBox.Name = "modelsComboBox";
            this.modelsComboBox.Size = new System.Drawing.Size(555, 21);
            this.modelsComboBox.TabIndex = 0;
            this.modelsComboBox.SelectedIndexChanged += new System.EventHandler(this.modelsComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(573, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // runModelButton
            // 
            this.runModelButton.BackColor = System.Drawing.Color.DarkGray;
            this.runModelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runModelButton.Location = new System.Drawing.Point(17, 174);
            this.runModelButton.Name = "runModelButton";
            this.runModelButton.Size = new System.Drawing.Size(163, 58);
            this.runModelButton.TabIndex = 2;
            this.runModelButton.Text = "Run Model";
            this.runModelButton.UseVisualStyleBackColor = false;
            this.runModelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model Settings";
            // 
            // hideCMDCheckBox
            // 
            this.hideCMDCheckBox.AutoSize = true;
            this.hideCMDCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideCMDCheckBox.Location = new System.Drawing.Point(111, 100);
            this.hideCMDCheckBox.Name = "hideCMDCheckBox";
            this.hideCMDCheckBox.Size = new System.Drawing.Size(88, 20);
            this.hideCMDCheckBox.TabIndex = 5;
            this.hideCMDCheckBox.Text = "Hide CMD";
            this.hideCMDCheckBox.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(574, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 58);
            this.button3.TabIndex = 6;
            this.button3.Text = "List Active Models";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(186, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 58);
            this.button4.TabIndex = 7;
            this.button4.Text = "Stop Model";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.stopModelButton_Click);
            // 
            // unloadModelButton
            // 
            this.unloadModelButton.BackColor = System.Drawing.Color.DarkGray;
            this.unloadModelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unloadModelButton.Location = new System.Drawing.Point(469, 174);
            this.unloadModelButton.Name = "unloadModelButton";
            this.unloadModelButton.Size = new System.Drawing.Size(99, 58);
            this.unloadModelButton.TabIndex = 8;
            this.unloadModelButton.Text = "Unload Model";
            this.unloadModelButton.UseVisualStyleBackColor = false;
            this.unloadModelButton.Click += new System.EventHandler(this.unloadModelButton_Click);
            // 
            // loadModelButton
            // 
            this.loadModelButton.BackColor = System.Drawing.Color.DarkGray;
            this.loadModelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadModelButton.Location = new System.Drawing.Point(355, 174);
            this.loadModelButton.Name = "loadModelButton";
            this.loadModelButton.Size = new System.Drawing.Size(108, 58);
            this.loadModelButton.TabIndex = 9;
            this.loadModelButton.Text = "Load Model";
            this.loadModelButton.UseVisualStyleBackColor = false;
            this.loadModelButton.Click += new System.EventHandler(this.loadModelButton_Click);
            // 
            // userNameColorLabel
            // 
            this.userNameColorLabel.AutoSize = true;
            this.userNameColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameColorLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userNameColorLabel.Location = new System.Drawing.Point(13, 303);
            this.userNameColorLabel.Name = "userNameColorLabel";
            this.userNameColorLabel.Size = new System.Drawing.Size(44, 18);
            this.userNameColorLabel.TabIndex = 10;
            this.userNameColorLabel.Text = "User:";
            this.userNameColorLabel.Click += new System.EventHandler(this.userNameColorLabel_Click);
            // 
            // userTextColorLabel
            // 
            this.userTextColorLabel.AutoSize = true;
            this.userTextColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextColorLabel.Location = new System.Drawing.Point(13, 327);
            this.userTextColorLabel.Name = "userTextColorLabel";
            this.userTextColorLabel.Size = new System.Drawing.Size(323, 18);
            this.userTextColorLabel.TabIndex = 11;
            this.userTextColorLabel.Text = "This is the user message text color. on the chat.";
            this.userTextColorLabel.Click += new System.EventHandler(this.userTextColorLabel_Click_1);
            // 
            // botNameColorLabel
            // 
            this.botNameColorLabel.AutoSize = true;
            this.botNameColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botNameColorLabel.Location = new System.Drawing.Point(13, 351);
            this.botNameColorLabel.Name = "botNameColorLabel";
            this.botNameColorLabel.Size = new System.Drawing.Size(35, 18);
            this.botNameColorLabel.TabIndex = 12;
            this.botNameColorLabel.Text = "Bot:";
            this.botNameColorLabel.Click += new System.EventHandler(this.botNameColorLabel_Click);
            // 
            // botTextColorLabel
            // 
            this.botTextColorLabel.AutoSize = true;
            this.botTextColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botTextColorLabel.Location = new System.Drawing.Point(13, 375);
            this.botTextColorLabel.Name = "botTextColorLabel";
            this.botTextColorLabel.Size = new System.Drawing.Size(311, 18);
            this.botTextColorLabel.TabIndex = 13;
            this.botTextColorLabel.Text = "This is the bot message text color on the chat.";
            this.botTextColorLabel.Click += new System.EventHandler(this.botTextColorLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Appearance Settings";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.BackColor = System.Drawing.Color.DarkGray;
            this.saveSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettingsButton.Location = new System.Drawing.Point(12, 455);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.saveSettingsButton.TabIndex = 15;
            this.saveSettingsButton.Text = "Save";
            this.saveSettingsButton.UseVisualStyleBackColor = false;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // attachWindowsCheckBox
            // 
            this.attachWindowsCheckBox.AutoSize = true;
            this.attachWindowsCheckBox.Location = new System.Drawing.Point(377, 303);
            this.attachWindowsCheckBox.Name = "attachWindowsCheckBox";
            this.attachWindowsCheckBox.Size = new System.Drawing.Size(132, 17);
            this.attachWindowsCheckBox.TabIndex = 16;
            this.attachWindowsCheckBox.Text = "Attach window to chat";
            this.attachWindowsCheckBox.UseVisualStyleBackColor = true;
            this.attachWindowsCheckBox.CheckedChanged += new System.EventHandler(this.attachWindowsCheckBox_CheckedChanged);
            // 
            // formTitlePanel
            // 
            this.formTitlePanel.BackColor = System.Drawing.Color.DarkGray;
            this.formTitlePanel.Controls.Add(this.formTitleLabel);
            this.formTitlePanel.Controls.Add(this.formCloseButton);
            this.formTitlePanel.Controls.Add(this.formMinimizeButton);
            this.formTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.formTitlePanel.Name = "formTitlePanel";
            this.formTitlePanel.Size = new System.Drawing.Size(693, 40);
            this.formTitlePanel.TabIndex = 17;
            // 
            // formMinimizeButton
            // 
            this.formMinimizeButton.BackColor = System.Drawing.Color.Silver;
            this.formMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formMinimizeButton.Location = new System.Drawing.Point(605, 8);
            this.formMinimizeButton.Name = "formMinimizeButton";
            this.formMinimizeButton.Size = new System.Drawing.Size(32, 23);
            this.formMinimizeButton.TabIndex = 0;
            this.formMinimizeButton.Text = "----";
            this.formMinimizeButton.UseVisualStyleBackColor = false;
            this.formMinimizeButton.Click += new System.EventHandler(this.formMinimizeButton_Click);
            // 
            // formCloseButton
            // 
            this.formCloseButton.BackColor = System.Drawing.Color.Silver;
            this.formCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formCloseButton.Location = new System.Drawing.Point(643, 8);
            this.formCloseButton.Name = "formCloseButton";
            this.formCloseButton.Size = new System.Drawing.Size(42, 23);
            this.formCloseButton.TabIndex = 1;
            this.formCloseButton.Text = "X";
            this.formCloseButton.UseVisualStyleBackColor = false;
            this.formCloseButton.Click += new System.EventHandler(this.formCloseButton_Click);
            // 
            // formTitleLabel
            // 
            this.formTitleLabel.AutoSize = true;
            this.formTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitleLabel.Location = new System.Drawing.Point(9, 13);
            this.formTitleLabel.Name = "formTitleLabel";
            this.formTitleLabel.Size = new System.Drawing.Size(46, 18);
            this.formTitleLabel.TabIndex = 2;
            this.formTitleLabel.Text = "label4";
            // 
            // Configurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 490);
            this.Controls.Add(this.formTitlePanel);
            this.Controls.Add(this.attachWindowsCheckBox);
            this.Controls.Add(this.saveSettingsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botTextColorLabel);
            this.Controls.Add(this.botNameColorLabel);
            this.Controls.Add(this.userTextColorLabel);
            this.Controls.Add(this.userNameColorLabel);
            this.Controls.Add(this.loadModelButton);
            this.Controls.Add(this.unloadModelButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.hideCMDCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.runModelButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modelsComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Configurations";
            this.Text = "Configurations";
            this.Load += new System.EventHandler(this.Configurations_Load);
            this.formTitlePanel.ResumeLayout(false);
            this.formTitlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox modelsComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button runModelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox hideCMDCheckBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button unloadModelButton;
        private System.Windows.Forms.Button loadModelButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label userNameColorLabel;
        private System.Windows.Forms.Label userTextColorLabel;
        private System.Windows.Forms.Label botNameColorLabel;
        private System.Windows.Forms.Label botTextColorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.CheckBox attachWindowsCheckBox;
        private System.Windows.Forms.Panel formTitlePanel;
        private System.Windows.Forms.Button formCloseButton;
        private System.Windows.Forms.Button formMinimizeButton;
        private System.Windows.Forms.Label formTitleLabel;
    }
}