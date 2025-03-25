using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace postProject.Bll
{
    internal class Delivers
    {
        private string numD;
        private string statusD;
        private string numSendD;
        private string numGetD;
    

        private DataRow dr;//עצם שיכיל שורה שלמה מטבלת לקוחות


        public Delivers()
        {

        }

        public Delivers(string numD, string statusD, int branchD, string nameSendD, int sendAdressD, string nameGetD, string getAdressD, int getCityD)
        {
            this.numD = numD;
            this.statusD = statusD;
            this.numSendD = nameSendD;
            this.numGetD = nameGetD;
        }

        public string NumD { get => numD; set => numD = value; }
        public string StatusD { get => statusD; set => statusD = value; }
        public string NameSendD { get => numSendD; set => numSendD = value; }
        public string NameGetD { get => numGetD; set => numGetD = value; }
        public DataRow Dr { get => dr; set => dr = value; }

        public void PutInto()
        {
            dr["numD"] = numD;
            dr["statusD"] = statusD;
            dr["telSendD"] = numSendD;
            dr["telGetD"] = numGetD;
        }

        //פעולה בונה המקבלת שורה מהטבלת ושופכת את הנתונים לתכונות העצם
        public Delivers(DataRow dr) : this()
        {
            //שומרת את השורה שהתקבלה כפרמטר לעצם שורה של המחלקה
            this.dr = dr;

            this.numD = dr["numD"].ToString();
            this.statusD = dr["statusD"].ToString();
            this.numSendD = dr["telSendD"].ToString();
            this.numGetD = dr["telGetD"].ToString();
        }
    }
}
