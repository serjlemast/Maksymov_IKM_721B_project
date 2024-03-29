using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.IO.Ports;


namespace Maksymov_IKM_721B_project
{
    public partial class Form1 : Form
    {
        private bool Mode; // Rezhym dozvolu / zaborony vvedennia danykh
        private SaveFileDialog sf;
        private MajorWork MajorObject; // Stvorennia obiekta klasu MajorWork

        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        System.Windows.Forms.Timer timer;

        string InputData = String.Empty;
        delegate void SetTextCallback(string text);
        public Form1()
        {
            InitializeComponent();
            infoLabel = new ToolStripLabel();
            infoLabel.Text = "������� ���� � �����:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);
            timer = new System.Windows.Forms.Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void AddData(string text)
        {
            listBox1.Items.Add(text);
        }
        private void SetText(string text)
        {
            if (this.listBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.AddData(text);
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();

            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() == DialogResult.OK) // Vyklyk dialohu vidkryttia failu
            {
                MajorObject.WriteOpenFileName(ofdOpen.FileName); // vidkryttia failu
                MajorObject.ReadFromFile(dgwOpen); // chytannia danykh z failu
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Mode)
            {
                tbInput.Enabled = true;// Rezhym dozvolu vvedennia
                tbInput.Focus();
                tClock.Start();
                bStart.Text = "Stop"; // zmina tekstu na knoptsi na "Stop"
                this.Mode = false;
                puskToolStripMenuItem.Text = "Stop";
            }
            else
            {
                tbInput.Enabled = false;// Rezhym zaborony vvedennia
                tClock.Stop();
                bStart.Text = "Pusk";// zmina tekstu na knoptsi na "Pusk"
                this.Mode = true;
                MajorObject.Write(tbInput.Text);// Zapys danykh u obiekt
                MajorObject.Task();// Obrobka danykh
                label1.Text = MajorObject.Read();// Vidobrazhennia rezultatu
                puskToolStripMenuItem.Text = "Start";
            }
        }

        private void tClock_Tick(object sender, EventArgs e)
        {
            tClock.Stop();
            MessageBox.Show("Mynulo 25 sekund", "Uvaha");// Vyvedennia povidomlennia "Mynulo 25 sekund" na ekran
            tClock.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MajorObject = new MajorWork();
            MajorObject.SetTime();
            MajorObject.Modify = false;// zaborona zapysu
            this.Mode = true;
            About A = new About();
            A.tAbout.Start();
            A.ShowDialog(); // vidobrazhennia dialohovoho vikna About

            toolTip1.SetToolTip(bSearch, "Click on the search button");
            toolTip1.IsBalloon = true;

            // �������� ������ ��� ������ �������
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            };

        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            tClock.Stop();
            tClock.Start();
            if (tbInput.Text.Length > 99)
            {
                tClock.Stop();
                MessageBox.Show("Zabagato symvoliv", "Pomylka");
                tClock.Start();
                e.KeyChar = (char)0;
                tbInput.Text = tbInput.Text.Remove(tbInput.Text.Length - 1);
            }
            // Check if the entered key is a number
            if (Char.IsDigit(e.KeyChar) && tbInput.Text.Length < 100)
            {
                // Append a comma to the current value of the text box
                if (tbInput.Text.Length != 0 && !(tbInput.Text.EndsWith(',')))
                {
                    tbInput.Text += ",";
                }
                // Set the cursor position to the end of the text box
                tbInput.SelectionStart = tbInput.Text.Length;
            }
            if ((e.KeyChar >= '0') & (e.KeyChar <= '9') | (e.KeyChar == (char)8))
            {
                return;
            }
            else
            {
                tClock.Stop();
                MessageBox.Show("Nepravylnyi symvol", "Pomylka");
                tClock.Start();
                e.KeyChar = (char)0;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.DoEvents();//�������� �� ����������� Windows, �� � ����� ������ // ����������� � ���� ����������.

            string s;
            s = (System.DateTime.Now - MajorObject.GetTime()).ToString();
            MessageBox.Show(s, "��� ������ ��������"); // Vyvedennia chasu roboty prohramy i povidomlennia "Chas roboty prohramy" na ekran\
        }

        private void workToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() == DialogResult.OK) // Vyklyk dialohovoho vikna vidkryttia failu
            {
                MessageBox.Show(ofdOpen.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void abouteProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About A = new About();
            A.progressBar1.Hide();
            A.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog() == DialogResult.OK)// Vyklyk dialohovoho vikna zberezhennia failu
            {
                MajorObject.WriteSaveFileName(sfdSave.FileName); // napysannia imeni failu
                MajorObject.Generator();
                MajorObject.SaveToFile(); // metod zberezhennia v fail
            }
        }

        private void proNakopychuvachiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] disks = System.IO.Directory.GetLogicalDrives(); // Strokovyi masyv z lohichnikh dyskiv
            string disk = "";
            for (int i = 0; i < disks.Length; i++)
            {
                try
                {
                    System.IO.DriveInfo D = new System.IO.DriveInfo(disks[i]);
                    disk += D.Name + "-" + D.TotalSize.ToString() + "-" + D.TotalFreeSpace.ToString()
                    + (char)13;// ������ ������������ ��� �����, �������� ������� ���� � ����� ���� �� �����
                }
                catch
                {
                    disk += disks[i] + "- �� �������" + (char)13; // ���� ������� �� �������, �� ��������� �� ����� ��� �������� � ����������� ��� �������
                }
            }
            MessageBox.Show(disk, "������������");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MajorObject.SaveFileNameExists()) // zadane im�ia failu isnuie?
                MajorObject.SaveToFile(); // zberehty dani v fail
            else
                saveAsToolStripMenuItem_Click(sender, e); //
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MajorObject.NewRec();
            tbInput.Clear();// ochystyty vmist tekstu
            label1.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MajorObject.Modify)
                if (MessageBox.Show("Dani ne buly zberezheni. Prodovzhyty vykhid?", "UVAHA",
                MessageBoxButtons.YesNo) == DialogResult.No)
                    e.Cancel = true; // prypynyty zakryttia
        }

        private void bSearch_Click_1(object sender, EventArgs e)
        {
            MajorObject.Find(tbSearch.Text); //poshuk
        }

        private void Push_Click(object sender, EventArgs e)
        {
            MajorObject.myStack.Push(Stacktb.Text);
            MajorObject.myArr[MajorObject.myArr.Length - MajorObject.myStack.Count] = Stacktb.Text;
            LabelStack.Text = "";
            for (int i = 0; i < MajorObject.myArr.Length; i++)
            {
                if (MajorObject.myArr[i] != null)
                {
                    LabelStack.Text += MajorObject.myArr[i] + (char)13;
                }
                else

                {
                    continue;
                }
            }
        }

        private void Peek_Click(object sender, EventArgs e)
        {
            if (MajorObject.myStack.Count > 0)

            {
                MessageBox.Show("Peek " + MajorObject.myStack.Peek());
            }
            if (MajorObject.myStack.Count == 0)
                MessageBox.Show("\nStek pust!");
        }

        private void Pop_Click(object sender, EventArgs e)
        {
            if (MajorObject.myStack.Count == 0)
                MessageBox.Show("\nStek pust!");
            else
            {
                MajorObject.myArr[MajorObject.myArr.Length - MajorObject.myStack.Count] =

                null;

                if (MajorObject.myStack.Count > 0)
                {
                    MessageBox.Show("Pop " + MajorObject.myStack.Pop());
                }
                LabelStack.Text = "";
                for (int i = 0; i < MajorObject.myArr.Length; i++)
                {
                    if (MajorObject.myArr[i] != null)

                    {
                        LabelStack.Text += MajorObject.myArr[i] + (char)13;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (MajorObject.myStack.Count == 0)
                    MessageBox.Show("\nStek pust!");
            }
        }

        private void Enqueue_Click(object sender, EventArgs e)
        {
            MajorObject.myQueue.Enqueue(Queuetb.Text);
            MajorObject.smyQueue[MajorObject.myQueue.Count - 1] = Queuetb.Text;
            LabelQueue.Text = "";
            for (int i = 0; i < MajorObject.smyQueue.Length; i++)
            {
                if (MajorObject.smyQueue[i] != null)
                {
                    LabelQueue.Text += MajorObject.smyQueue[i] + (char)13;
                }
                else
                {
                    continue;
                }
            }
        }

        private void Peek_q_Click(object sender, EventArgs e)
        {
            if (MajorObject.myQueue.Count > 0)
            {
                MessageBox.Show("Peek " + MajorObject.myQueue.Peek());
            }
            if (MajorObject.myQueue.Count == 0)
                MessageBox.Show("\nOchered pustaia!");
        }

        private void Dequeue_Click(object sender, EventArgs e)
        {
            if (MajorObject.myQueue.Count == 0)

                MessageBox.Show("\nCherha porozhnia!");
            else
            {
                MajorObject.smyQueue[0] = null;

                // Zrushennia elementiv vlivo na 1 pozytsiiu
                for (int i = 0; i < MajorObject.smyQueue.Length - 1; i++)
                {
                    MajorObject.smyQueue[i] = MajorObject.smyQueue[i + 1];
                }
                // Vytiah elementa z cherhy
                if (MajorObject.myQueue.Count > 0)
                {
                    MessageBox.Show("Dequeue " + MajorObject.myQueue.Dequeue());
                }
                // Formuvannia teksta dlia vyvedennia na ekran
                LabelQueue.Text = "";
                for (int i = 0; i < MajorObject.smyQueue.Length - 1; i++)
                {
                    if (MajorObject.smyQueue[i] != null)
                    {
                        LabelQueue.Text += MajorObject.smyQueue[i] + (char)13;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (MajorObject.myQueue.Count == 0)
                    MessageBox.Show("\nOchered pustaia!");
            }
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();

            sf.Filter = @"��������� ���� (*.txt)|*.txt|������� ����� TXT(*.txt)|*.txt|CSV-���� (*.csv)|*.csv|Bin-���� (*.bin)|*.bin";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                MajorObject.WriteSaveTextFileName(sf.FileName);
                MajorObject.SaveToTextFile(sf.FileName, dgwOpen);
            }
        }

        private void saveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MajorObject.SaveTextFileNameExists())

                MajorObject.SaveToTextFile(MajorObject.ReadSaveTextFileName(), dgwOpen);
            else
                saveAsToolStripMenuItem1_Click(sender, e);
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();

            o.Filter = @"Tekstovyi file (*.txt)|*.txt|Tekstovyi file TXT(*.txt)|*.txt|CSV-file (*.csv)|*.csv|Bin-file (*.bin)|*.bin";

            if (o.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(o.FileName, Encoding.Default);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Start")

            {
                if (port.IsOpen) port.Close();
                #region ������ ��������� �����
                port.PortName = comboBox1.Text;
                port.BaudRate = Convert.ToInt32(comboBox2.Text);
                port.DataBits = Convert.ToInt32(comboBox3.Text);
                switch (comboBox4.Text)
                {
                    case "space":
                        port.Parity = Parity.Space;
                        break;
                    case "even":
                        port.Parity = Parity.Even;
                        break;
                    case "odd":
                        port.Parity = Parity.Odd;
                        break;
                    case "marker":
                        port.Parity = Parity.Mark;
                        break;
                    default:
                        port.Parity = Parity.None;
                        break;
                }
                switch (comboBox5.Text)
                {
                    case "2":
                        port.StopBits = StopBits.Two;
                        break;
                    case "1.5":
                        port.StopBits = StopBits.OnePointFive;
                        break;
                    case "No":
                        port.StopBits = StopBits.None;
                        break;

                    default:
                        port.StopBits = StopBits.One;
                        break;
                }
                switch (comboBox6.Text)
                {
                    case "Xon/Xoff":
                        port.Handshake = Handshake.XOnXOff;
                        break;
                    case "Hardware":
                        port.Handshake = Handshake.RequestToSend;
                        break;
                    default:
                        port.Handshake = Handshake.None;
                        break;
                }
                #endregion
                try
                {
                    port.Open();
                    button2.Text = "Stop";
                    // button2.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("���� " + port.PortName + " ��������� �������!",

                    "�������!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    comboBox1.SelectedText = "";
                    button2.Text = "Start";
                }
            }
            else
            {
                if (port.IsOpen) port.Close();
                button2.Text = "Start";
                // button2.Enabled = true;
            }
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            InputData = port.ReadExisting();
            if (InputData != String.Empty)
            {
                SetText(InputData);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")

            {
                groupBox2.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
                button2.Enabled = false;
            }
        }

    }
}