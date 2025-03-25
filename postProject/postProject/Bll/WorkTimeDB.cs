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

        public WorkTime SearchKod(int k)
        {
            return GetList().Find(x => x.BranchkodT == k);
        }
    }
}