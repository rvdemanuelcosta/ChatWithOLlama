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
            this.button1.Location = new System.Drawing.Point(573, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // runModelButton
            // 
            this.runModelButton.Location = new System.Drawing.Point(17, 174);
            this.runModelButton.Name = "runModelButton";
            this.runModelButton.Size = new System.Drawing.Size(163, 58);
            this.runModelButton.TabIndex = 2;
            this.runModelButton.Text = "Run Model";
            this.runModelButton.UseVisualStyleBackColor = true;
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
            this.label2.Location = new System.Drawing.Point(279, 33);
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
            this.button3.Location = new System.Drawing.Point(574, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 58);
            this.button3.TabIndex = 6;
            this.button3.Text = "List Active Models";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(186, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 58);
            this.button4.TabIndex = 7;
            this.button4.Text = "Stop Model";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.stopModelButton_Click);
            // 
            // unloadModelButton
            // 
            this.unloadModelButton.Location = new System.Drawing.Point(469, 174);
            this.unloadModelButton.Name = "unloadModelButton";
            this.unloadModelButton.Size = new System.Drawing.Size(99, 58);
            this.unloadModelButton.TabIndex = 8;
            this.unloadModelButton.Text = "Unload Model";
            this.unloadModelButton.UseVisualStyleBackColor = true;
            this.unloadModelButton.Click += new System.EventHandler(this.unloadModelButton_Click);
            // 
            // loadModelButton
            // 
            this.loadModelButton.Location = new System.Drawing.Point(355, 174);
            this.loadModelButton.Name = "loadModelButton";
            this.loadModelButton.Size = new System.Drawing.Size(108, 58);
            this.loadModelButton.TabIndex = 9;
            this.loadModelButton.Text = "Load Model";
            this.loadModelButton.UseVisualStyleBackColor = true;
            this.loadModelButton.Click += new System.EventHandler(this.loadModelButton_Click);
            // 
            // Configurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 248);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Configurations";
            this.Text = "Configurations";
            this.Load += new System.EventHandler(this.Configurations_Load);
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
    }
}