using System.IO.Ports;

namespace Maksymov_IKM_721B_project
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
            System.Text.ASCIIEncoding asciiEncodingSealed1 = new System.Text.ASCIIEncoding();
            System.Text.DecoderReplacementFallback decoderReplacementFallback1 = new System.Text.DecoderReplacementFallback();
            System.Text.EncoderReplacementFallback encoderReplacementFallback1 = new System.Text.EncoderReplacementFallback();
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
            tekstoviFailyToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem2 = new ToolStripMenuItem();
            saveAsToolStripMenuItem1 = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            referenceToolStripMenuItem = new ToolStripMenuItem();
            abouteProjectToolStripMenuItem = new ToolStripMenuItem();
            sfdSave = new SaveFileDialog();
            ofdOpen = new OpenFileDialog();
            dgwOpen = new DataGridView();
            bSearch = new Button();
            tbSearch = new TextBox();
            toolTip1 = new ToolTip(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            statusStrip1 = new StatusStrip();
            tabPage2 = new TabPage();
            richTextBox1 = new RichTextBox();
            tabPage3 = new TabPage();
            splitContainer1 = new SplitContainer();
            StackText = new Label();
            LabelStack = new Label();
            Stacktb = new TextBox();
            Push = new Button();
            Pop = new Button();
            Peek = new Button();
            QueueText = new Label();
            LabelQueue = new Label();
            Queuetb = new TextBox();
            Peek_q = new Button();
            Dequeue = new Button();
            Enqueue = new Button();
            tabPage4 = new TabPage();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            comboBox2 = new ComboBox();
            comboBox6 = new ComboBox();
            button2 = new Button();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            comboBox3 = new ComboBox();
            label4 = new Label();
            comboBox4 = new ComboBox();
            label3 = new Label();
            comboBox5 = new ComboBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            port = new SerialPort(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwOpen).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 27);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Some text";
            label1.Click += label1_Click;
            // 
            // bStart
            // 
            bStart.BackColor = SystemColors.ActiveBorder;
            bStart.Location = new Point(92, 99);
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
            tbInput.Location = new Point(92, 56);
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
            работаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { puskToolStripMenuItem, toolStripSeparator4, proNakopychuvachiToolStripMenuItem, tekstoviFailyToolStripMenuItem });
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
            // tekstoviFailyToolStripMenuItem
            // 
            tekstoviFailyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem2, saveAsToolStripMenuItem1, openToolStripMenuItem });
            tekstoviFailyToolStripMenuItem.Name = "tekstoviFailyToolStripMenuItem";
            tekstoviFailyToolStripMenuItem.Size = new Size(182, 22);
            tekstoviFailyToolStripMenuItem.Text = "Tekstovi faily";
            // 
            // saveToolStripMenuItem2
            // 
            saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
            saveToolStripMenuItem2.Size = new Size(114, 22);
            saveToolStripMenuItem2.Text = "Save";
            saveToolStripMenuItem2.Click += saveToolStripMenuItem2_Click;
            // 
            // saveAsToolStripMenuItem1
            // 
            saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            saveAsToolStripMenuItem1.Size = new Size(114, 22);
            saveAsToolStripMenuItem1.Text = "Save As";
            saveAsToolStripMenuItem1.Click += saveAsToolStripMenuItem1_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(114, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click_1;
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
            dgwOpen.Location = new Point(8, 19);
            dgwOpen.Name = "dgwOpen";
            dgwOpen.RowTemplate.Height = 25;
            dgwOpen.Size = new Size(284, 150);
            dgwOpen.TabIndex = 4;
            // 
            // bSearch
            // 
            bSearch.Location = new Point(8, 217);
            bSearch.Name = "bSearch";
            bSearch.Size = new Size(75, 23);
            bSearch.TabIndex = 5;
            bSearch.Text = "poshuk";
            bSearch.UseVisualStyleBackColor = true;
            bSearch.Click += bSearch_Click_1;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(8, 188);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(164, 23);
            tbSearch.TabIndex = 6;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 422);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(statusStrip1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(tbInput);
            tabPage1.Controls.Add(bStart);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 394);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Vvedennia danykh";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(3, 369);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(786, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(dgwOpen);
            tabPage2.Controls.Add(tbSearch);
            tabPage2.Controls.Add(bSearch);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 394);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Robota z failamy";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(388, 97);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(100, 96);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(splitContainer1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 394);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Stek / Cherha";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.LightGray;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(StackText);
            splitContainer1.Panel1.Controls.Add(LabelStack);
            splitContainer1.Panel1.Controls.Add(Stacktb);
            splitContainer1.Panel1.Controls.Add(Push);
            splitContainer1.Panel1.Controls.Add(Pop);
            splitContainer1.Panel1.Controls.Add(Peek);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Silver;
            splitContainer1.Panel2.Controls.Add(QueueText);
            splitContainer1.Panel2.Controls.Add(LabelQueue);
            splitContainer1.Panel2.Controls.Add(Queuetb);
            splitContainer1.Panel2.Controls.Add(Peek_q);
            splitContainer1.Panel2.Controls.Add(Dequeue);
            splitContainer1.Panel2.Controls.Add(Enqueue);
            splitContainer1.Size = new Size(786, 388);
            splitContainer1.SplitterDistance = 364;
            splitContainer1.TabIndex = 0;
            // 
            // StackText
            // 
            StackText.AutoSize = true;
            StackText.Location = new Point(163, 83);
            StackText.Name = "StackText";
            StackText.Size = new Size(35, 15);
            StackText.TabIndex = 5;
            StackText.Text = "Stack";
            // 
            // LabelStack
            // 
            LabelStack.AutoSize = true;
            LabelStack.Location = new Point(136, 279);
            LabelStack.Name = "LabelStack";
            LabelStack.Size = new Size(63, 15);
            LabelStack.TabIndex = 4;
            LabelStack.Text = "LabelStack";
            // 
            // Stacktb
            // 
            Stacktb.Location = new Point(125, 191);
            Stacktb.Name = "Stacktb";
            Stacktb.Size = new Size(100, 23);
            Stacktb.TabIndex = 3;
            // 
            // Push
            // 
            Push.Location = new Point(136, 220);
            Push.Name = "Push";
            Push.Size = new Size(75, 23);
            Push.TabIndex = 2;
            Push.Text = "Push";
            Push.UseVisualStyleBackColor = true;
            Push.Click += Push_Click;
            // 
            // Pop
            // 
            Pop.Location = new Point(55, 220);
            Pop.Name = "Pop";
            Pop.Size = new Size(75, 23);
            Pop.TabIndex = 1;
            Pop.Text = "Pop";
            Pop.UseVisualStyleBackColor = true;
            Pop.Click += Pop_Click;
            // 
            // Peek
            // 
            Peek.Location = new Point(217, 220);
            Peek.Name = "Peek";
            Peek.Size = new Size(75, 23);
            Peek.TabIndex = 0;
            Peek.Text = "Peek";
            Peek.UseVisualStyleBackColor = true;
            Peek.Click += Peek_Click;
            // 
            // QueueText
            // 
            QueueText.AutoSize = true;
            QueueText.Location = new Point(176, 83);
            QueueText.Name = "QueueText";
            QueueText.Size = new Size(45, 15);
            QueueText.TabIndex = 5;
            QueueText.Text = "Cherha";
            // 
            // LabelQueue
            // 
            LabelQueue.AutoSize = true;
            LabelQueue.Location = new Point(155, 289);
            LabelQueue.Name = "LabelQueue";
            LabelQueue.Size = new Size(70, 15);
            LabelQueue.TabIndex = 4;
            LabelQueue.Text = "LabelQueue";
            // 
            // Queuetb
            // 
            Queuetb.Location = new Point(150, 144);
            Queuetb.Name = "Queuetb";
            Queuetb.Size = new Size(100, 23);
            Queuetb.TabIndex = 3;
            // 
            // Peek_q
            // 
            Peek_q.Location = new Point(150, 220);
            Peek_q.Name = "Peek_q";
            Peek_q.Size = new Size(75, 23);
            Peek_q.TabIndex = 2;
            Peek_q.Text = "Peek_q";
            Peek_q.UseVisualStyleBackColor = true;
            Peek_q.Click += Peek_q_Click;
            // 
            // Dequeue
            // 
            Dequeue.Location = new Point(253, 220);
            Dequeue.Name = "Dequeue";
            Dequeue.Size = new Size(75, 23);
            Dequeue.TabIndex = 1;
            Dequeue.Text = "Dequeue";
            Dequeue.UseVisualStyleBackColor = true;
            Dequeue.Click += Dequeue_Click;
            // 
            // Enqueue
            // 
            Enqueue.Location = new Point(48, 220);
            Enqueue.Name = "Enqueue";
            Enqueue.Size = new Size(75, 23);
            Enqueue.TabIndex = 0;
            Enqueue.Text = "Enqueue";
            Enqueue.UseVisualStyleBackColor = true;
            Enqueue.Click += Enqueue_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(listBox1);
            tabPage4.Controls.Add(groupBox2);
            tabPage4.Controls.Add(groupBox1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(792, 394);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Com Port";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(206, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(583, 379);
            listBox1.TabIndex = 13;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox6);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBox5);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(0, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 302);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Port settings";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "75", "110", "134", "150", "300", "600", "1200", "1800", "2400", "4800", "7200", "9600", "14400", "19200", "38400", "57600", "115200", "128000" });
            comboBox2.Location = new Point(6, 37);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 14;
            comboBox2.Text = "115200";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Xon/Xoff", "Hardware", "No" });
            comboBox6.Location = new Point(8, 213);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 5;
            comboBox6.Text = "No";
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(52, 268);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 6;
            label2.Text = "Speed(bit/s)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 195);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 10;
            label6.Text = "Thread control";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 151);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 9;
            label5.Text = "Stop bites";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "4", "5", "6", "7", "8" });
            comboBox3.Location = new Point(6, 81);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 2;
            comboBox3.Text = "8";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 107);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "Evenness";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "even", "", "odd", "", "no", "", "marker", "", "space" });
            comboBox4.Location = new Point(6, 125);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 3;
            comboBox4.Text = "No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 63);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 7;
            label3.Text = "Data bit";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "1", "1.5", "2", "No" });
            comboBox5.Location = new Point(6, 169);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 4;
            comboBox5.Text = "1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(0, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 87);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 22);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 6;
            label7.Text = "Choose port";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(22, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // port
            // 
            port.DataReceived += port_DataReceived;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
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
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private ToolTip toolTip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private StatusStrip statusStrip1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private SplitContainer splitContainer1;
        private Label StackText;
        private Label LabelStack;
        private TextBox Stacktb;
        private Button Push;
        private Button Pop;
        private Button Peek;
        private Label QueueText;
        private Label LabelQueue;
        private TextBox Queuetb;
        private Button Peek_q;
        private Button Dequeue;
        private Button Enqueue;
        private ToolStripMenuItem tekstoviFailyToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem2;
        private ToolStripMenuItem saveAsToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private RichTextBox richTextBox1;
        private TabPage tabPage4;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private Button button2;
        private Label label2;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private ComboBox comboBox3;
        private Label label4;
        private ComboBox comboBox4;
        private Label label3;
        private ComboBox comboBox5;
        private GroupBox groupBox1;
        private Label label7;
        private ComboBox comboBox6;
        private ComboBox comboBox2;
        private System.IO.Ports.SerialPort port;
    }
}