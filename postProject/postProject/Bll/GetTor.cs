using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace postProject.Bll
{
    internal class GetTor
    {

        private string tzClientT;
        private int kodT;
        private DateTime dateT;
        private DateTime hourT;
        private string statusT;
        private int kindT;

        private DataRow dr;//עצם שיכיל שורה שלמה מטבלת לקוחות


        public GetTor()
        {

        }

        public GetTor(string tzClientT, int kodT, DateTime dateT, DateTime hourT, string statusT, int kindT)
        {
            this.tzClientT = tzClientT;
            this.kodT = kodT;
            this.dateT = dateT;
            this.hourT = hourT;
            this.statusT = statusT;
            this.kindT = kindT;
        }

   //     public string TzClientT 
   //     { 
   //         get => tzClientT; set
   //         {
             //   if (!Validation.CheckId(tzClientT) == true)
             //       throw new Exception("ת.ז אינה תקינה");tzClientT = value;
  //          }
  //      }
        public int KodT { get => kodT; set => kodT = value; }
        public DateTime DateT { get => dateT; set => dateT = value; }
        public DateTime HourT { get => hourT; set => hourT = value; }
        public string StatusT { get => statusT; set => statusT = value; }
        public int KindT { get => kindT; set => kindT = value; }
        public DataRow Dr { get => dr; set => dr = value; }
        public string TzClientT { get => tzClientT; set => tzClientT = value; }

        public void PutInto()
        {
            dr["tzClientT"] = tzClientT;
            dr["kodT"] = kodT;
            dr["dateT"] = dateT;
            dr["hourT"] = hourT;
            dr["statusT"] = statusT;
            dr["kindT"] = kindT;
        }

        //פעולה בונה המקבלת שורה מהטבלת ושופכת את הנתונים לתכונות העצם
        public GetTor(DataRow dr) : this()
        {
            //שומרת את השורה שהתקבלה כפרמטר לעצם שורה של המחלקה
            this.dr = dr;

            this.tzClientT = dr["tzClientT"].ToString();
            this.kodT = Convert.ToInt32(dr["kodT"]);
            this.dateT = Convert.ToDateTime(dr["dateT"]);
            this.hourT = Convert.ToDateTime(dr["hourT"]);
            this.statusT = dr["statusT"].ToString();
            this.kindT = Convert.ToInt32(dr["kindT"]);
        }
        public ServisKind servisKindOfTor()//פעולה המחזירה שורה של סוג שרות של התור
        {
            return new ServisKindDB().SearchKodServisKind(this.KindT);
        }
    }
}
