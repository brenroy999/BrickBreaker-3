﻿namespace BrickBreaker
{
    partial class HighScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.highScores = new System.Windows.Forms.Label();
			this.backButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// highScores
			// 
			this.highScores.AutoSize = true;
			this.highScores.BackColor = System.Drawing.Color.Transparent;
			this.highScores.Font = new System.Drawing.Font("OCR A Std", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.highScores.ForeColor = System.Drawing.Color.Cyan;
			this.highScores.Location = new System.Drawing.Point(56, 47);
			this.highScores.Name = "highScores";
			this.highScores.Size = new System.Drawing.Size(51, 380);
			this.highScores.TabIndex = 5;
			this.highScores.Text = "1.\r\n\r\n2.\r\n\r\n3.\r\n\r\n4.\r\n\r\n5.\r\n\r\n6.\r\n\r\n7.\r\n\r\n8.\r\n\r\n9.\r\n\r\n10.";
			// 
			// backButton
			// 
			this.backButton.BackgroundImage = global::BrickBreaker.Properties.Resources.button;
			this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.backButton.FlatAppearance.BorderSize = 0;
			this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.backButton.Font = new System.Drawing.Font("OCR A Std", 14F);
			this.backButton.ForeColor = System.Drawing.Color.Cyan;
			this.backButton.Location = new System.Drawing.Point(24, 458);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(119, 58);
			this.backButton.TabIndex = 6;
			this.backButton.Text = "BACK";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// HighScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BackgroundImage = global::BrickBreaker.Properties.Resources.Stars;
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.highScores);
			this.Name = "HighScreen";
			this.Size = new System.Drawing.Size(800, 550);
			this.Load += new System.EventHandler(this.HighScreen_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label highScores;
		private System.Windows.Forms.Button backButton;
	}
}
