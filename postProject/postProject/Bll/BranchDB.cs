using ExampleProject.Bll;
using postProject.Gui;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postProject.Bll
{
    class BranchDB : GeneralDB
    {
        //ליסט-רשימה שתכיל את כל הטבלה כאוסף של עצמים
        List<Branch> listBranch = new List<Branch>();
        //הפעולה בונה שולחת את שם הטבלה המתאימה לבונה של המחלקה הכללית
        public BranchDB() : base("tbl_branch")
        { }

        //פעולה השופכת את שורות הטבלה לליסטס
        public List<Branch> GetList()
        {
            listBranch.Clear();
            //לולאה העוברת על אוסף השורות שבטבלה
            foreach (DataRow dr in dt.Rows)
            {
                //הוספת פריט לרשימה עי שימוש בפעולה בונה של המחלקה 
                //המקבלת שורה ושופכת לתכונות העצם
                listBranch.Add(new Branch(dr));
            }
            return listBranch;
        }

        //מוסיפה לקוח חדש לטבלה
        public void AddNew(Branch b)
        {
            b.Dr = dt.NewRow();//בונה שורה חדשה ריקה לטבלה
            b.PutInto();//פעולה השופכת את תכונות העצם לשורה
            this.dt.Rows.Add(b.Dr);
            this.Update();
        }
        public int GetNextKeyB()
        {
            int key;
            if (GetList().Count() == 0)
                return 1;
            key = GetList().Max(x => x.KodB);//מחזיר את הקוד המקסימלי
            key++;
            return key;
        }

        public Branch SearchKod(int k)
        {
            return GetList().Find(x => x.KodB == k);
        }
        public void UpdateRow(Branch b)
        {
            b.PutInto();
            this.Update();
        }
        public Branch SearchNameBreanch(string name)// פעולה המחזירה שורה של סניף
        {
            return GetList().Find(x => x.NameB == name);
        }
    }
}
