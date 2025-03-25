using ExampleProject.Bll;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postProject.Bll
{
    class WorkTimeDB : GeneralDB
    {
        //ליסט-רשימה שתכיל את כל הטבלה כאוסף של עצמים
        List<WorkTime> listWorkTime = new List<WorkTime>();
        //הפעולה בונה שולחת את שם הטבלה המתאימה לבונה של המחלקה הכללית
        public WorkTimeDB() : base("tbl_workTime")
        { }

        //פעולה השופכת את שורות הטבלה לליסטס
        public List<WorkTime> GetList()
        {
            listWorkTime.Clear();
            //לולאה העוברת על אוסף השורות שבטבלה
            foreach (DataRow dr in dt.Rows)
            {
                //הוספת פריט לרשימה עי שימוש בפעולה בונה של המחלקה 
                //המקבלת שורה ושופכת לתכונות העצם
                listWorkTime.Add(new WorkTime(dr));
            }
            return listWorkTime;
        }

        //מוסיפה לקוח חדש לטבלה
        public void AddNew(WorkTime w)
        {
            w.Dr = dt.NewRow();//בונה שורה חדשה ריקה לטבלה
            w.PutInto();//פעולה השופכת את תכונות העצם לשורה
            this.dt.Rows.Add(w.Dr);
            this.Update();

        }
        public void UpdateRow(WorkTime w)
        {
            w.PutInto();
            this.Update();
        }
        BranchDB bbbb =new BranchDB();
        public WorkTime SearchKod(string k1,int k2,string k3)//מחפש שורה של שעת פעילות
        {
            return GetList().Find(x => x.BranchkodT == bbbb.SearchNameBreanch(k1).KodB && x.NumShiftT == k2 && x.DayT == k3);
        }
        public int GetNextKeyW(Branch b,string d)
        {
            int key;
            if (GetList().Where(x=> new BranchDB().SearchKod(x.BranchkodT).KodB == b.KodB && x.DayT == d).Count() == 0)
                return 1;
            key = GetList().Where(x => new BranchDB().SearchKod(x.BranchkodT).KodB == b.KodB && x.DayT == d).Max(x => x.NumShiftT);//מחזיר את הקוד המקסימלי
            key++;
            return key;
        }

    }
}