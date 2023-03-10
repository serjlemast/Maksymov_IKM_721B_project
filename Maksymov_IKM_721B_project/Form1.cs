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
            this.Mode = true;
            About A = new About();
            A.tAbout.Start();
            A.ShowDialog(); // відображення діалогового вікна About
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
    }
}