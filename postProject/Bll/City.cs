using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace postProject.Bll
{
    public class City
    {
        private int kodCity;
        private string nameCity;
        private bool statusC;

       

        private DataRow dr;//עצם שיכיל שורה שלמה מטבלת לקוחות


        public City()
        {

        }
        public City(int kodCity, string nameCity)
        {
            this.kodCity = kodCity;
            this.nameCity = nameCity;
            this.statusC = statusC;
        }

        public int KodCity { get => kodCity; set => kodCity = value; }
        public string NameCity { get => nameCity; set => nameCity = value; }
        public DataRow Dr { get => dr; set => dr = value; }
        public bool StatusC { get => statusC; set => statusC = value; }

        public void PutInto()
        {
            dr["kodCity"] = kodCity;
            dr["nameCity"] = nameCity;
            dr["statusC"] = statusC;
        }

        //פעולה בונה המקבלת שורה מהטבלת ושופכת את הנתונים לתכונות העצם
        public City(DataRow dr) : this()
        {
            //שומרת את השורה שהתקבלה כפרמטר לעצם שורה של המחלקה
            this.dr = dr;

            this.kodCity = Convert.ToInt32(dr["kodCity"]);
            this.nameCity = dr["nameCity"].ToString();
            this.statusC = Convert.ToBoolean(dr["statusC"]);
        }
        public override string ToString()
        {
            return nameCity;
        }
    }
}
