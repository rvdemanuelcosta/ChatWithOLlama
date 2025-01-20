namespace ChatWithLlama
{
    partial class SystemMessageForm
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
            this.systemMessageInput = new System.Windows.Forms.RichTextBox();
            this.systemMessageSaveButton = new System.Windows.Forms.Button();
            this.formTitlePanel = new System.Windows.Forms.Panel();
            this.formMinimizebutton = new System.Windows.Forms.Button();
            this.formClosebutton = new System.Windows.Forms.Button();
            this.formTitleLabel = new System.Windows.Forms.Label();
            this.formTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // systemMessageInput
            // 
            this.systemMessageInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.systemMessageInput.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemMessageInput.Location = new System.Drawing.Point(9, 58);
            this.systemMessageInput.Name = "systemMessageInput";
            this.systemMessageInput.Size = new System.Drawing.Size(378, 157);
            this.systemMessageInput.TabIndex = 0;
            this.systemMessageInput.Text = "";
            // 
            // systemMessageSaveButton
            // 
            this.systemMessageSaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.systemMessageSaveButton.Location = new System.Drawing.Point(152, 221);
            this.systemMessageSaveButton.Name = "systemMessageSaveButton";
            this.systemMessageSaveButton.Size = new System.Drawing.Size(93, 23);
            this.systemMessageSaveButton.TabIndex = 1;
            this.systemMessageSaveButton.Text = "Save";
            this.systemMessageSaveButton.UseVisualStyleBackColor = true;
            this.systemMessageSaveButton.Click += new System.EventHandler(this.systemMessageSaveButton_Click);
            // 
            // formTitlePanel
            // 
            this.formTitlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formTitlePanel.BackColor = System.Drawing.Color.DarkGray;
            this.formTitlePanel.Controls.Add(this.formTitleLabel);
            this.formTitlePanel.Controls.Add(this.formClosebutton);
            this.formTitlePanel.Controls.Add(this.formMinimizebutton);
            this.formTitlePanel.Location = new System.Drawing.Point(0, -1);
            this.formTitlePanel.Name = "formTitlePanel";
            this.formTitlePanel.Size = new System.Drawing.Size(399, 40);
            this.formTitlePanel.TabIndex = 2;
            // 
            // formMinimizebutton
            // 
            this.formMinimizebutton.BackColor = System.Drawing.Color.Silver;
            this.formMinimizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formMinimizebutton.Location = new System.Drawing.Point(313, 10);
            this.formMinimizebutton.Name = "formMinimizebutton";
            this.formMinimizebutton.Size = new System.Drawing.Size(32, 23);
            this.formMinimizebutton.TabIndex = 0;
            this.formMinimizebutton.Text = "----";
            this.formMinimizebutton.UseVisualStyleBackColor = false;
            this.formMinimizebutton.Click += new System.EventHandler(this.formMinimizebutton_Click);
            // 
            // formClosebutton
            // 
            this.formClosebutton.BackColor = System.Drawing.Color.Silver;
            this.formClosebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formClosebutton.Location = new System.Drawing.Point(351, 10);
            this.formClosebutton.Name = "formClosebutton";
            this.formClosebutton.Size = new System.Drawing.Size(42, 23);
            this.formClosebutton.TabIndex = 1;
            this.formClosebutton.Text = "X";
            this.formClosebutton.UseVisualStyleBackColor = false;
            this.formClosebutton.Click += new System.EventHandler(this.formClosebutton_Click);
            // 
            // formTitleLabel
            // 
            this.formTitleLabel.AutoSize = true;
            this.formTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitleLabel.Location = new System.Drawing.Point(6, 15);
            this.formTitleLabel.Name = "formTitleLabel";
            this.formTitleLabel.Size = new System.Drawing.Size(46, 18);
            this.formTitleLabel.TabIndex = 2;
            this.formTitleLabel.Text = "label1";
            // 
            // SystemMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 256);
            this.Controls.Add(this.formTitlePanel);
            this.Controls.Add(this.systemMessageSaveButton);
            this.Controls.Add(this.systemMessageInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(399, 249);
            this.Name = "SystemMessageForm";
            this.Text = "SystemMessageForm";
            this.Load += new System.EventHandler(this.SystemMessageForm_Load);
            this.formTitlePanel.ResumeLayout(false);
            this.formTitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox systemMessageInput;
        private System.Windows.Forms.Button systemMessageSaveButton;
        private System.Windows.Forms.Panel formTitlePanel;
        private System.Windows.Forms.Button formClosebutton;
        private System.Windows.Forms.Button formMinimizebutton;
        private System.Windows.Forms.Label formTitleLabel;
    }
}