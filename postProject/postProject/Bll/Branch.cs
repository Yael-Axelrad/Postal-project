using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace postProject.Bll
{
    public class Branch
    {
        private int kodB;
        private string nameB;
        private string stritB;
        private int numBildingB;
        private int cityB;
        private bool statusB;
        private DataRow dr;//עצם שיכיל שורה שלמה מטבלת לקוחות

        public Branch()
        {

        }

        public Branch(int kodB, string nameB, string stritB, int numBildingB, int cityB, bool statusB, bool isTorB)
        {
            this.kodB = kodB;
            this.nameB = nameB;
            this.stritB = stritB;
            this.numBildingB = numBildingB;
            this.cityB = cityB;
            this.statusB = statusB;
        }

        public int KodB { get => kodB; set => kodB = value; }
        public string NameB { get => nameB; set => nameB = value; }
        public string StritB { get => stritB; set => stritB = value; }
        public int NumBildingB { get => numBildingB; set => numBildingB = value; }
        public int CityB { get => cityB; set => cityB = value; }
        public bool StatusB { get => statusB; set => statusB = value; }
        public DataRow Dr { get => dr; set => dr = value; }

        public void PutInto()
        {
            dr["kodB"] = kodB;
            dr["nameB"] = nameB;
            dr["stritB"] = stritB;
            dr["numBildingB"] = numBildingB;
            dr["cityB"] = cityB;
            dr["statusB"] = statusB;
        }

        //פעולה בונה המקבלת שורה מהטבלת ושופכת את הנתונים לתכונות העצם
        public Branch(DataRow dr) : this()
        {
            //שומרת את השורה שהתקבלה כפרמטר לעצם שורה של המחלקה
            this.dr = dr;

            this.kodB = Convert.ToInt32(dr["kodB"]);
            this.nameB = dr["nameB"].ToString();
            this.stritB = dr["stritB"].ToString();
            this.numBildingB = Convert.ToInt32(dr["numBildingB"]);
            this.cityB = Convert.ToInt32(dr["cityB"]);
            this.statusB = Convert.ToBoolean(dr["statusB"]);
        }
        public City CityOfBranch()//פעולה המקבלת שורה של עיר
        {
            return new cityDB().SearchKodCity(this.CityB);
        }
        public override string ToString()
        {
            return nameB;
        }
    }
}
