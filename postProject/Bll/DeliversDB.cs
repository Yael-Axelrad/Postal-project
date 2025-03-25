using ExampleProject.Bll;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postProject.Bll
{
    class DeliversDB : GeneralDB
    {
        //ליסט-רשימה שתכיל את כל הטבלה כאוסף של עצמים
        List<Delivers> listDelivers = new List<Delivers>();
        //הפעולה בונה שולחת את שם הטבלה המתאימה לבונה של המחלקה הכללית
        public DeliversDB() : base("tb_delivers")
        { }

        //פעולה השופכת את שורות הטבלה לליסטס
        public List<Delivers> GetList()
        {
            listDelivers.Clear();
            //לולאה העוברת על אוסף השורות שבטבלה
            foreach (DataRow dr in dt.Rows)
            {
                //הוספת פריט לרשימה עי שימוש בפעולה בונה של המחלקה 
                //המקבלת שורה ושופכת לתכונות העצם
                listDelivers.Add(new Delivers(dr));
            }
            return listDelivers;
        }

        //מוסיפה לקוח חדש לטבלה
        public void AddNew(Delivers d)
        {
            d.Dr = dt.NewRow();//בונה שורה חדשה ריקה לטבלה
            d.PutInto();//פעולה השופכת את תכונות העצם לשורה
            this.dt.Rows.Add(d.Dr);
            this.Update();

        }
        public void UpdateRow(Delivers b)
        {
            b.PutInto();
            this.Update();
        }
        public Delivers SearchKod(string k)
        {
            return GetList().Find(x => x.NumD == k);
        }
    }
}