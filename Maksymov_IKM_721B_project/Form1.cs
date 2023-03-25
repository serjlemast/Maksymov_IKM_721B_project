using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Maksymov_IKM_721B_project
{
    public partial class Form1 : Form
    {
        private bool Mode; // Rezhym dozvolu / zaborony vvedennia danykh
        private MajorWork MajorObject; // Stvorennia obiekta klasu MajorWork


        public Form1()
        {
            InitializeComponent();
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
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            tClock.Stop();
            tClock.Start();
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
            string s;
            s = (System.DateTime.Now - MajorObject.GetTime()).ToString();
            MessageBox.Show(s, "Час роботи програми"); // Vyvedennia chasu roboty prohramy i povidomlennia "Chas roboty prohramy" na ekran\
        }

        private void работаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog() == DialogResult.OK) // Виклик діалогового вікна відкриття файлу
            {
                MessageBox.Show(ofdOpen.FileName);
            }
        }

        private void puskToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void abouteProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About A = new About();
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
                    + (char)13;// змінній присвоюється ім’я диска, загальна кількість місця и вільне місце на диску
                }
                catch
                {
                    disk += disks[i] + "- не готовий" + (char)13; // якщо пристрій не готовий, то виведення на екран ім’я пристрою і повідомлення «не готовий»
                }
            }
            MessageBox.Show(disk, "Накопичувачі");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MajorObject.SaveFileNameExists()) // zadane im’ia failu isnuie?
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
    }
}