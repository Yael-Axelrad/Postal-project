using ExampleProject.Bll;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postProject.Bll
{
    class GetTorDB : GeneralDB
    {
        //ליסט-רשימה שתכיל את כל הטבלה כאוסף של עצמים
        List<GetTor> listGetTor = new List<GetTor>();
        //הפעולה בונה שולחת את שם הטבלה המתאימה לבונה של המחלקה הכללית
        public GetTorDB() : base("tbl_getTor")
        { }

        //פעולה השופכת את שורות הטבלה לליסטס
        public List<GetTor> GetList()
        {
            listGetTor.Clear();
            //לולאה העוברת על אוסף השורות שבטבלה
            foreach (DataRow dr in dt.Rows)
            {
                //הוספת פריט לרשימה עי שימוש בפעולה בונה של המחלקה 
                //המקבלת שורה ושופכת לתכונות העצם
                listGetTor.Add(new GetTor(dr));
            }
            return listGetTor;
        }

        //מוסיפה לקוח חדש לטבלה
        public void AddNew(GetTor g)
        {
            g.Dr = dt.NewRow();//בונה שורה חדשה ריקה לטבלה
            g.PutInto();//פעולה השופכת את תכונות העצם לשורה
            this.dt.Rows.Add(g.Dr);
            this.Update();

        }
        public int GetNextKeyT()
        {
            int key;
            if (GetList().Count() == 0)
                return 1;
            key = GetList().Max(x => x.KodT);//מחזיר את הקוד המקסימלי
            key++;
            return key;
        }
    }
}