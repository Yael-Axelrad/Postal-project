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
        private int cityT;
        private int breanchT;

        private DataRow dr;//עצם שיכיל שורה שלמה מטבלת לקוחות


        public GetTor()
        {

        }

        public GetTor(string tzClientT, int kodT, DateTime dateT, DateTime hourT, string statusT, int kindT,int cityT,int breanchT)
        {
            this.tzClientT = tzClientT;
            this.kodT = kodT;
            this.dateT = dateT;
            this.hourT = hourT;
            this.statusT = statusT;
            this.kindT = kindT;
            this.cityT = cityT;
            this.breanchT = breanchT;
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
        public int CityT { get => cityT; set => cityT = value; }
        public int BreanchT { get => breanchT; set => breanchT = value; }

        public void PutInto()
        {
            dr["tzClientT"] = tzClientT;
            dr["kodT"] = kodT;
            dr["dateT"] = dateT;
            dr["hourT"] = hourT;
            dr["statusT"] = statusT;
            dr["kindT"] = kindT;
            dr["cityT"] = cityT;
            dr["breanchT"] = breanchT;
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
            this.cityT = Convert.ToInt32(dr["cityT"]);
            this.breanchT = Convert.ToInt32(dr["breanchT"]);
        }
        public ServisKind servisKindOfTor()//פעולה המחזירה שורה של סוג שרות של התור
        {
            return new ServisKindDB().SearchKodServisKind(this.KindT);
        }
        public City CityOfTor()//פעולה המחזירה שורה של עיר
        {
            return new cityDB().SearchKodCity(this.CityT);
        }
        public Branch BreanchOfTor()//פעולה המחזירה שורה של סניף
        {
            return new BranchDB().SearchKod(this.BreanchT);
        }
    }
}
