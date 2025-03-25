using ExampleProject.Bll;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postProject.Bll
{
    class ServisKindDB : GeneralDB
    {
        //ליסט-רשימה שתכיל את כל הטבלה כאוסף של עצמים
        List<ServisKind> listServisKind = new List<ServisKind>();
        //הפעולה בונה שולחת את שם הטבלה המתאימה לבונה של המחלקה הכללית
        public ServisKindDB() : base("tbl_servisKind")
        { }

        //פעולה השופכת את שורות הטבלה לליסטס
        public List<ServisKind> GetList()
        {
            listServisKind.Clear();
            //לולאה העוברת על אוסף השורות שבטבלה
            foreach (DataRow dr in dt.Rows)
            {
                //הוספת פריט לרשימה עי שימוש בפעולה בונה של המחלקה 
                //המקבלת שורה ושופכת לתכונות העצם
                listServisKind.Add(new ServisKind(dr));
            }
            return listServisKind;
        }

        //מוסיפה לקוח חדש לטבלה
        public void AddNew(ServisKind s)
        {
            s.Dr = dt.NewRow();//בונה שורה חדשה ריקה לטבלה
            s.PutInto();//פעולה השופכת את תכונות העצם לשורה
            this.dt.Rows.Add(s.Dr);
            this.Update();

        }
        public ServisKind SearchKodServisKind(int kod)//פעולה המחזירה שורה של סוג שרות
        {
            return GetList().Find(x => x.KodS == kod);
        }

        public void UpdateRow(ServisKind s)
        {
            s.PutInto();
            this.Update();
        }
    }
}