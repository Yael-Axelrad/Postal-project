using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace postProject.Bll
{
    internal class WorkTime
    {
        private int branchkodT;
        private int numShiftT;
        private string dayT;
        private DateTime openT;
        private DateTime closseT;

        private DataRow dr;//עצם שיכיל שורה שלמה מטבלת לקוחות


        public WorkTime()
        {

        }
        public WorkTime(int branchkodT, int numShiftT, string dayT, DateTime openT, DateTime closseT)
        {
            this.branchkodT = branchkodT;
            this.numShiftT = numShiftT;
            this.dayT = dayT;
            this.openT = openT;
            this.closseT = closseT;
        }

        public int BranchkodT { get => branchkodT; set => branchkodT = value; }
        public int NumShiftT { get => numShiftT; set => numShiftT = value; }
        public string DayT { get => dayT; set => dayT = value; }
        public DateTime OpenT { get => openT; set => openT = value; }
        public DateTime ClosseT { get => closseT; set => closseT = value; }
        public DataRow Dr { get => dr; set => dr = value; }

        public void PutInto()
        {
            dr["branchkodT"] = branchkodT;
            dr["numShiftT"] = numShiftT;
            dr["dayT"] = dayT;
            dr["openT"] = openT;
            dr["closseT"] = closseT;
        }

        //פעולה בונה המקבלת שורה מהטבלת ושופכת את הנתונים לתכונות העצם
        public WorkTime(DataRow dr) : this()
        {
            //שומרת את השורה שהתקבלה כפרמטר לעצם שורה של המחלקה
            this.dr = dr;

            this.branchkodT = Convert.ToInt32(dr["branchkodT"]);
            this.numShiftT =Convert.ToInt32(dr["numShiftT"]);
            this.dayT = dr["dayT"].ToString();
            this.openT = Convert.ToDateTime(dr["openT"]);
            this.closseT = Convert.ToDateTime(dr["closseT"]);
        }
    }
}
