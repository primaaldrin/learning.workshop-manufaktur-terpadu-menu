﻿namespace Workshop_Manufaktur_Terpadu
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
            this.about_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // about_button
            // 
            this.about_button.Location = new System.Drawing.Point(709, 403);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(79, 35);
            this.about_button.TabIndex = 0;
            this.about_button.Text = "About";
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.about_button);
            this.Name = "MainForm";
            this.Text = "Workshop Manufaktur Terpadu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button about_button;
    }
}

