﻿namespace Maksymov_IKM_721B_project
{
    partial class About
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button1 = new Button();
            tAbout = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 75);
            label1.Name = "label1";
            label1.Size = new Size(138, 90);
            label1.TabIndex = 0;
            label1.Text = "           Rozrobyv \r\nstudent hrupy IKM-721B \r\nM.D.O\r\n\r\nTeskt zavdannia\r\nTekst";
            // 
            // button1
            // 
            button1.Location = new Point(340, 181);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Zakryty";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tAbout
            // 
            tAbout.Interval = 10000;
            tAbout.Tick += tAbout_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(326, 227);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "About";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        public System.Windows.Forms.Timer tAbout;
        public ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}