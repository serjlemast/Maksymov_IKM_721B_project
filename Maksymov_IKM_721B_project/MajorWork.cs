using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maksymov_IKM_721B_project
{
    internal class MajorWork
    {
        // Vmist robochoho obiekta
        // Polia
        private System.DateTime TimeBegin; // chas pochatku roboty prohramy
        private string Data; // vkhidni dani
        private string Result; // Pole rezultatu

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
        }
    }
}
