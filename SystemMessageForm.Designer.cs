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
            this.SuspendLayout();
            // 
            // systemMessageInput
            // 
            this.systemMessageInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.systemMessageInput.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemMessageInput.Location = new System.Drawing.Point(9, 5);
            this.systemMessageInput.Name = "systemMessageInput";
            this.systemMessageInput.Size = new System.Drawing.Size(362, 164);
            this.systemMessageInput.TabIndex = 0;
            this.systemMessageInput.Text = "";
            // 
            // systemMessageSaveButton
            // 
            this.systemMessageSaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.systemMessageSaveButton.Location = new System.Drawing.Point(144, 175);
            this.systemMessageSaveButton.Name = "systemMessageSaveButton";
            this.systemMessageSaveButton.Size = new System.Drawing.Size(93, 23);
            this.systemMessageSaveButton.TabIndex = 1;
            this.systemMessageSaveButton.Text = "Save";
            this.systemMessageSaveButton.UseVisualStyleBackColor = true;
            this.systemMessageSaveButton.Click += new System.EventHandler(this.systemMessageSaveButton_Click);
            // 
            // SystemMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 210);
            this.Controls.Add(this.systemMessageSaveButton);
            this.Controls.Add(this.systemMessageInput);
            this.MinimumSize = new System.Drawing.Size(399, 249);
            this.Name = "SystemMessageForm";
            this.Text = "SystemMessageForm";
            this.Load += new System.EventHandler(this.SystemMessageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox systemMessageInput;
        private System.Windows.Forms.Button systemMessageSaveButton;
    }
}