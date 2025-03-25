using ExampleProject.Bll;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postProject.Bll
{
    class ClientsDB : GeneralDB
    {
        //ליסט-רשימה שתכיל את כל הטבלה כאוסף של עצמים
        List<Clients> listClients = new List<Clients>();
        //הפעולה בונה שולחת את שם הטבלה המתאימה לבונה של המחלקה הכללית
        public ClientsDB() : base("tbl_clients")
        { }

        //פעולה השופכת את שורות הטבלה לליסטס
        public List<Clients> GetList()
        {
            listClients.Clear();
            //לולאה העוברת על אוסף השורות שבטבלה
            foreach (DataRow dr in dt.Rows)
            {
                //הוספת פריט לרשימה עי שימוש בפעולה בונה של המחלקה 
                //המקבלת שורה ושופכת לתכונות העצם
                listClients.Add(new Clients(dr));
            }
            return listClients;
        }

        //מוסיפה לקוח חדש לטבלה
        public void AddNew(Clients c)
        {
            c.Dr = dt.NewRow();//בונה שורה חדשה ריקה לטבלה
            c.PutInto();//פעולה השופכת את תכונות העצם לשורה
            this.dt.Rows.Add(c.Dr);
            this.Update();

        }
        public Clients SearchKodClient(string tel)//פעולה המחזירה שורה של לקוח
        {
            return GetList().Find(x => x.TelC == tel);
        }
    }
}