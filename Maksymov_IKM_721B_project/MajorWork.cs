using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Maksymov_IKM_721B_project
{
    internal class MajorWork
    {
        // Vmist robochoho obiekta
        // Polia
        private System.DateTime TimeBegin; // chas pochatku roboty prohramy
        private string Data; // vkhidni dani
        private string Result; // Pole rezultatu
        public bool Modify;
        private int Key;// pole kliucha

        private string SaveFileName;// im’ia failu dlia zapysu
        private string OpenFileName;// im’ia failu dlia chytannia
        public void WriteSaveFileName(string S)// metod zapysu danykh v obiekt
        {
            this.SaveFileName = S;// zapamiataty im’ia failu dlia zapysu
        }
        public void WriteOpenFileName(string S)
        {
            this.OpenFileName = S;// zapamiataty im’ia failu dlia vidkryttia
        }

        // Metody
        public void Find(string Num) // poshuk
        {
            int N;
            try
            {
                N = Convert.ToInt16(Num); // peretvorennia nomera riadka v int16 dlia vidobrazhennia
            }
            catch
            {
                MessageBox.Show("помилка пошукового запиту"); // Vyvedennia na ekran povidomlennia "pomylka poshukovoho zapytu"

                return;
            }

            try
            {
                if (!File.Exists(this.OpenFileName))
                {
                    MessageBox.Show("файлу немає"); // Vyvedennia na ekran povidomlennia "failu nemaie"

                    return;
                }
                Stream S; // stvorennia potoku
                S = File.Open(this.OpenFileName, FileMode.Open); // vidkryttia failu
                Buffer D;
                object O; // buferna zminna dlia kontroliu formatu
                BinaryFormatter BF = new BinaryFormatter(); // stvorennia obiekta dlia formatuvannia

                while (S.Position < S.Length)
                {
                    O = BF.Deserialize(S);
                    D = O as Buffer;
                    if (D == null) break;
                    if (D.Key == N) // perevirka dorivniuie chy nomer poshuku nomeru riadka v tablytsi

                    {
                        string ST;
                        ST = "Запис містить:" + (char)13 + "No" + Num + "Вхідні дані:" +

                        D.Data + "Результат:" + D.Result;

                        MessageBox.Show(ST, "Запис знайдена"); // Vyvedennia na ekran povidomlennia "zapys mistyt", nomer, vkhidnykh danykh i rezultat

                        S.Close();
                        return;
                    }
                }
                S.Close();
                MessageBox.Show("Запис не знайдена"); // Vyvedennia na ekran povidomlennia "Zapys ne znaidena"
            }
            catch
            {
                MessageBox.Show("Помилка файлу"); // Vyvedennia na ekran povidomlennia "Pomylka failu"
            }
        } // Find zakinchyvsia

        public void NewRec() // novyi zapys
        {
            this.Data = ""; // "" - oznaka porozhnoho riadka
            this.Result = null; // dlia string- null
            this.Key = 0;
            this.SaveFileName = "";
            this.OpenFileName = "";
        }
        public bool SaveFileNameExists()
        {
            if (this.SaveFileName == null)
            {
                return false;
            }
            else return true;
        }
        public void Generator() // metod formuvannia kliuchovoho polia
        {
            try
            {
                if (!File.Exists(this.SaveFileName)) // isnuie fail?
                {
                    Key = 1;
                    return;
                }
                Stream S; // stvorennia potoku
                S = File.Open(this.SaveFileName, FileMode.Open); // Vidkryttia failu
                Buffer D;
                object O; // buferna zminna dlia kontroliu formatu
                BinaryFormatter BF = new BinaryFormatter(); // stvorennia elementu dlia formatuvannia
                while (S.Position < S.Length)
                {
                    O = BF.Deserialize(S);
                    D = O as Buffer;
                    if (D == null) break;
                    Key = D.Key;
                }
                Key++;
                S.Close();
            }
            catch
            {
                MessageBox.Show("Pomylka failu"); // Vyvedennia na ekran povidomlennia "Pomylka failu"
            }
        }

        public void ReadFromFile(System.Windows.Forms.DataGridView DG) // zchytuvannia z failu
        {
            try
            {
                if (!File.Exists(this.OpenFileName))
                {
                    MessageBox.Show("Failu nemaie"); // Vyvedennia na ekran povidomlennia "failu nemaie"
                    return;
                }
                Stream S; // stvorennia potoku
                S = File.Open(this.OpenFileName, FileMode.Open); // zchytuvannia danykh z failu
                Buffer D;
                object O; // buferna zminna dlia kontroliu formatu
                BinaryFormatter BF = new BinaryFormatter(); // stvorennia obiektu dlia formatuvannia

                // formuiemo tablytsiu
                System.Data.DataTable MT = new System.Data.DataTable();
                System.Data.DataColumn cKey = new System.Data.DataColumn("Key");// formuiemo kolonku "Kliuch"
                System.Data.DataColumn cInput = new System.Data.DataColumn("Incoming_data");// formuiemo kolonku "Vkhidni dani"
                System.Data.DataColumn cResult = new System.Data.DataColumn("Result");// formuiemo kolonku "Rezultat"

                MT.Columns.Add(cKey);// dodavannia kliucha
                MT.Columns.Add(cInput);// dodavannia vkhidnykh danykh
                MT.Columns.Add(cResult);// dodavannia rezultatu

                while (S.Position < S.Length)
                {
                    O = BF.Deserialize(S); // deserializatsiia
                    D = O as Buffer;
                    if (D == null) break;
                    System.Data.DataRow MR;
                    MR = MT.NewRow();
                    MR["Key"] = D.Key; // Zanesennia v tablytsiu nomer
                    MR["Incoming_data"] = D.Data; // Zanesennia v tablytsiu vkhidnykh danykh
                    MR["Result"] = D.Result; // Zanesennia v tablytsiu rezultativ
                    MT.Rows.Add(MR);
                }
                DG.DataSource = MT;
                S.Close(); // zakryttia
            }
            catch
            {
                MessageBox.Show("Pomylka failu"); // Vyvedennia na ekran povidomlennia "Pomylka failu"
            }
        } // ReadFromFile zakinchyvsia

        public void SetTime() // metod zapysu chasu pochatku roboty prohramy
        {
            this.TimeBegin = System.DateTime.Now;
        }
        public System.DateTime GetTime() // Metod otrymannia chasu zavershennia prohramy
        {
            return this.TimeBegin;
        }
        public void Write(string D)// metod zapysu danykh v obiekt.
        {
            this.Data = D;
        }
        public string Read()
        {
            return this.Result;// metod vidobrazhennia rezultatu
        }
        public void Task() // metod realizatsii prohramnoho zavdannia
        {
            if (this.Data.Length > 5)
            {
                this.Result = Convert.ToString(true);

            }
            else
            {
                this.Result = Convert.ToString(false);
            }
            this.Modify = true; // Dozvil zapysu
        }
        public void SaveToFile() // Zapys danykh do failu
        {
            if (!this.Modify)
                return;
            try
            {
                Stream S; // stvorennia potoku
                if (File.Exists(this.SaveFileName)) // isnuie fail?
                { 
                    S = File.Open(this.SaveFileName, FileMode.Append);// Vidkryttia failu dlia zberezhennia
                }
                else {
                    S = File.Open(this.SaveFileName, FileMode.Create);// stvoryty fail
                }    
                Buffer D = new Buffer(); // stvorennia bufernoi zminnoi
                D.Data = this.Data;
                D.Result = Convert.ToString(this.Result);
                D.Key = Key;
                Key++;
                BinaryFormatter BF = new BinaryFormatter(); // stvorennia obiekta dlia formatuvannia
                BF.Serialize(S, D);
                S.Flush(); // ochyshchennia bufera potoku
                S.Close(); // zakryttia potoku
                this.Modify = false; // Zaborona povtornoho zapysu
            }
            catch
            {
                MessageBox.Show("Pomylka roboty z failom"); // Vyvedennia na ekran povidomlennia "Pomylka roboty z failom"
            }
        }
    }
}
