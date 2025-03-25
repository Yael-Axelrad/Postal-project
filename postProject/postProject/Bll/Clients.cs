using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace postProject.Bll
{
    internal class Clients
    {
        private string firstNameC;
        private string lastNameC;
        private string telC;
        private int cityC;
        private int branchC;
        private bool statusC;

        private DataRow dr;//עצם שיכיל שורה שלמה מטבלת לקוחות

        public Clients()
        {

        }

        public Clients(string tzC, string firstNameC, string lastNameC, string telC, int cityC, bool statusC)
        {
            this.firstNameC = firstNameC;
            this.lastNameC = lastNameC;
            this.telC = telC;
            this.cityC = cityC;
            this.branchC = branchC;
            this.statusC = statusC;
        }

        public string FirstNameC
        {
            get => firstNameC; set
            {
                if (!Validation.IsHebrew(value) == true)
                throw new Exception("אותיות בעברית בלבד"); 
                firstNameC = value;
            }
        }
        public string LastNameC 
        {
            get => lastNameC; set
            {
                if (!Validation.IsHebrew(value) == true)
                    throw new Exception("אותיות בעברית בלבד"); 
                    lastNameC = value;
            }
        }
        public string TelC 
        { 
            get => telC; set
            {
                if (!Validation.IsPelepon(value) == true)
                    throw new Exception("מספר פלאפון אינו תקין"); 
                    telC = value;
            }
        }
        public int CityC { get => cityC; set => cityC = value; }
        public bool StatusC { get => statusC; set => statusC = value; }
        public DataRow Dr { get => dr; set => dr = value; }
        public int BranchC { get => branchC; set => branchC = value; }

        public void PutInto()
        {
            dr["firstNameC"] = firstNameC;
            dr["lastNameC"] = lastNameC;
            dr["telC"] = telC;
            dr["cityC"] = cityC;
            dr["statusC"] = statusC;
            dr["branchC"] = branchC;
        }

        //פעולה בונה המקבלת שורה מהטבלת ושופכת את הנתונים לתכונות העצם
        public Clients(DataRow dr) : this()
        {
            //שומרת את השורה שהתקבלה כפרמטר לעצם שורה של המחלקה
            this.dr = dr;

            this.firstNameC = dr["firstNameC"].ToString();
            this.lastNameC = dr["lastNameC"].ToString();
            this.telC = dr["telC"].ToString();
            this.cityC = Convert.ToInt32(dr["cityC"]);
            this.statusC = Convert.ToBoolean(dr["statusC"]);
            this.branchC = Convert.ToInt32(dr["branchC"]);
        }
    }
}
