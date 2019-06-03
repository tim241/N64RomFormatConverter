﻿namespace N64RomFormatConverter
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
            this.RomFileInputText = new System.Windows.Forms.TextBox();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.ConvertButton1 = new System.Windows.Forms.Button();
            this.ConvertButton2 = new System.Windows.Forms.Button();
            this.RomInfoText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RomFileInputText
            // 
            this.RomFileInputText.Location = new System.Drawing.Point(13, 13);
            this.RomFileInputText.Name = "RomFileInputText";
            this.RomFileInputText.ReadOnly = true;
            this.RomFileInputText.Size = new System.Drawing.Size(242, 20);
            this.RomFileInputText.TabIndex = 0;
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(261, 10);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFileButton.TabIndex = 1;
            this.SelectFileButton.Text = "select file";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // ConvertButton1
            // 
            this.ConvertButton1.Enabled = false;
            this.ConvertButton1.Location = new System.Drawing.Point(12, 113);
            this.ConvertButton1.Name = "ConvertButton1";
            this.ConvertButton1.Size = new System.Drawing.Size(150, 55);
            this.ConvertButton1.TabIndex = 2;
            this.ConvertButton1.Text = "Convert to ...";
            this.ConvertButton1.UseVisualStyleBackColor = true;
            this.ConvertButton1.Click += new System.EventHandler(this.ConvertButton1_Click);
            // 
            // ConvertButton2
            // 
            this.ConvertButton2.Enabled = false;
            this.ConvertButton2.Location = new System.Drawing.Point(180, 113);
            this.ConvertButton2.Name = "ConvertButton2";
            this.ConvertButton2.Size = new System.Drawing.Size(151, 55);
            this.ConvertButton2.TabIndex = 3;
            this.ConvertButton2.Text = "Convert to ...";
            this.ConvertButton2.UseVisualStyleBackColor = true;
            this.ConvertButton2.Click += new System.EventHandler(this.ConvertButton2_Click);
            // 
            // RomInfoText
            // 
            this.RomInfoText.Location = new System.Drawing.Point(13, 39);
            this.RomInfoText.Multiline = true;
            this.RomInfoText.Name = "RomInfoText";
            this.RomInfoText.ReadOnly = true;
            this.RomInfoText.Size = new System.Drawing.Size(318, 68);
            this.RomInfoText.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 178);
            this.Controls.Add(this.RomInfoText);
            this.Controls.Add(this.ConvertButton2);
            this.Controls.Add(this.ConvertButton1);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.RomFileInputText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N64RomFormatConverter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RomFileInputText;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Button ConvertButton1;
        private System.Windows.Forms.Button ConvertButton2;
        private System.Windows.Forms.TextBox RomInfoText;
    }
}
