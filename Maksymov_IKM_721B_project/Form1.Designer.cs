﻿namespace Maksymov_IKM_721B_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            bStart = new Button();
            tbInput = new TextBox();
            tClock = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            работаToolStripMenuItem = new ToolStripMenuItem();
            puskToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            proNakopychuvachiToolStripMenuItem = new ToolStripMenuItem();
            referenceToolStripMenuItem = new ToolStripMenuItem();
            abouteProjectToolStripMenuItem = new ToolStripMenuItem();
            sfdSave = new SaveFileDialog();
            ofdOpen = new OpenFileDialog();
            dgwOpen = new DataGridView();
            bSearch = new Button();
            tbSearch = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwOpen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 69);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Some text";
            label1.Click += label1_Click;
            // 
            // bStart
            // 
            bStart.BackColor = SystemColors.ActiveBorder;
            bStart.Location = new Point(56, 116);
            bStart.Name = "bStart";
            bStart.Size = new Size(75, 23);
            bStart.TabIndex = 1;
            bStart.Text = "Пуск";
            bStart.UseVisualStyleBackColor = false;
            bStart.Click += button1_Click;
            // 
            // tbInput
            // 
            tbInput.Enabled = false;
            tbInput.Location = new Point(56, 87);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(100, 23);
            tbInput.TabIndex = 2;
            tbInput.TextChanged += textBox1_TextChanged;
            tbInput.KeyPress += tbInput_KeyPress;
            // 
            // tClock
            // 
            tClock.Interval = 25000;
            tClock.Tick += tClock_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, работаToolStripMenuItem, referenceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, toolStripSeparator1, saveToolStripMenuItem, toolStripSeparator2, saveToolStripMenuItem1, saveAsToolStripMenuItem, toolStripSeparator3, exitToolStripMenuItem, fileToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(37, 20);
            файлToolStripMenuItem.Text = "File";
            файлToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeyDisplayString = "";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(146, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            saveToolStripMenuItem.Size = new Size(146, 22);
            saveToolStripMenuItem.Text = "Open";
            saveToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(143, 6);
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem1.Size = new Size(146, 22);
            saveToolStripMenuItem1.Text = "Save";
            saveToolStripMenuItem1.Click += saveToolStripMenuItem1_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(146, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            exitToolStripMenuItem.Size = new Size(146, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(146, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // работаToolStripMenuItem
            // 
            работаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { puskToolStripMenuItem, toolStripSeparator4, proNakopychuvachiToolStripMenuItem });
            работаToolStripMenuItem.Name = "работаToolStripMenuItem";
            работаToolStripMenuItem.Size = new Size(47, 20);
            работаToolStripMenuItem.Text = "Work";
            работаToolStripMenuItem.Click += workToolStripMenuItem_Click;
            // 
            // puskToolStripMenuItem
            // 
            puskToolStripMenuItem.Name = "puskToolStripMenuItem";
            puskToolStripMenuItem.ShortcutKeys = Keys.F9;
            puskToolStripMenuItem.Size = new Size(182, 22);
            puskToolStripMenuItem.Text = "Pusk";
            puskToolStripMenuItem.Click += button1_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(179, 6);
            // 
            // proNakopychuvachiToolStripMenuItem
            // 
            proNakopychuvachiToolStripMenuItem.Name = "proNakopychuvachiToolStripMenuItem";
            proNakopychuvachiToolStripMenuItem.Size = new Size(182, 22);
            proNakopychuvachiToolStripMenuItem.Text = "Pro nakopychuvachi";
            proNakopychuvachiToolStripMenuItem.Click += proNakopychuvachiToolStripMenuItem_Click;
            // 
            // referenceToolStripMenuItem
            // 
            referenceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abouteProjectToolStripMenuItem });
            referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            referenceToolStripMenuItem.Size = new Size(71, 20);
            referenceToolStripMenuItem.Text = "Reference";
            // 
            // abouteProjectToolStripMenuItem
            // 
            abouteProjectToolStripMenuItem.Name = "abouteProjectToolStripMenuItem";
            abouteProjectToolStripMenuItem.Size = new Size(147, 22);
            abouteProjectToolStripMenuItem.Text = "About project";
            abouteProjectToolStripMenuItem.Click += abouteProjectToolStripMenuItem_Click;
            // 
            // sfdSave
            // 
            sfdSave.Filter = "|*.SoM|All files|*.*";
            // 
            // ofdOpen
            // 
            ofdOpen.FileName = "openFileDialog1";
            ofdOpen.Filter = "|*.SoM|All files|*.*";
            // 
            // dgwOpen
            // 
            dgwOpen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwOpen.Location = new Point(195, 69);
            dgwOpen.Name = "dgwOpen";
            dgwOpen.RowTemplate.Height = 25;
            dgwOpen.Size = new Size(493, 150);
            dgwOpen.TabIndex = 4;
            // 
            // bSearch
            // 
            bSearch.Location = new Point(195, 225);
            bSearch.Name = "bSearch";
            bSearch.Size = new Size(75, 23);
            bSearch.TabIndex = 5;
            bSearch.Text = "poshuk";
            bSearch.UseVisualStyleBackColor = true;
            bSearch.Click += bSearch_Click_1;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(195, 254);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(100, 23);
            tbSearch.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbSearch);
            Controls.Add(bSearch);
            Controls.Add(dgwOpen);
            Controls.Add(tbInput);
            Controls.Add(bStart);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwOpen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bStart;
        private TextBox tbInput;
        private System.Windows.Forms.Timer tClock;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem работаToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem referenceToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem puskToolStripMenuItem;
        private ToolStripMenuItem proNakopychuvachiToolStripMenuItem;
        private ToolStripMenuItem abouteProjectToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private SaveFileDialog sfdSave;
        private OpenFileDialog ofdOpen;
        private DataGridView dgwOpen;
        private Button bSearch;
        private TextBox tbSearch;
        private ToolStripMenuItem fileToolStripMenuItem;
    }
}