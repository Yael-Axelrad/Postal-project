using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace postProject.Bll
{
    public class ServisKind
    {
        private int kodS;
        private string describeS;
        private int longS;
        private string statusS;

        private DataRow dr;//עצם שיכיל שורה שלמה מטבלת לקוחות


        public ServisKind()
        {

        }
        public ServisKind(int kodS, string describeS, int longS, string statusS)
        {
            this.kodS = kodS;
            this.describeS = describeS;
            this.longS = longS;
            this.statusS = statusS;
        }

        public int KodS { get => kodS; set => kodS = value; }
        public string DescribeS { get => describeS; set => describeS = value; }
        public int LongS { get => longS; set => longS = value; }
        public string StatusS { get => statusS; set => statusS = value; }
        public DataRow Dr { get => dr; set => dr = value; }

        public void PutInto()
        {
            dr["kodS"] = kodS;
            dr["describeS"] = describeS;
            dr["longS"] = longS;
            dr["statusS"] = statusS;
        }

        //פעולה בונה המקבלת שורה מהטבלת ושופכת את הנתונים לתכונות העצם
        public ServisKind(DataRow dr) : this()
        {
            //שומרת את השורה שהתקבלה כפרמטר לעצם שורה של המחלקה
            this.dr = dr;

            this.kodS = Convert.ToInt32(dr["kodS"]);
            this.describeS = dr["describeS"].ToString();
            this.longS = Convert.ToInt32(dr["longS"]);
            this.statusS = dr["statusS"].ToString();
        }
    }
}
