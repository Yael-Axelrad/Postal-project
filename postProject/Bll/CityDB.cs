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
    class cityDB : GeneralDB
    {
        //ליסט-רשימה שתכיל את כל הטבלה כאוסף של עצמים
        List<City> listCity = new List<City>();
        //הפעולה בונה שולחת את שם הטבלה המתאימה לבונה של המחלקה הכללית
        public cityDB() : base("tbl_city")
        { }

        //פעולה השופכת את שורות הטבלה לליסטס
        public List<City> GetList()
        {
            listCity.Clear();
            //לולאה העוברת על אוסף השורות שבטבלה
            foreach (DataRow dr in dt.Rows)
            {
                //הוספת פריט לרשימה עי שימוש בפעולה בונה של המחלקה 
                //המקבלת שורה ושופכת לתכונות העצם
                listCity.Add(new City(dr));
            }
            return listCity;
        }

        //מוסיפה לקוח חדש לטבלה
        public void AddNew(City c)
        {
            c.Dr = dt.NewRow();//בונה שורה חדשה ריקה לטבלה
            c.PutInto();//פעולה השופכת את תכונות העצם לשורה
            this.dt.Rows.Add(c.Dr);
            this.Update();

        }
        public City SearchKodCity(int kod)//פעולה המחזירה שורה של עיר
        {
            return GetList().Find(x => x.KodCity == kod);
        }

        public City SearchNameCity(string name)//פעולה המחזירה שורה של עיר
        {
            return GetList().Find(x => x.NameCity == name);
        }

        public int GetNextKeyC()
        {
            int key;
            if (GetList().Count() == 0)
                return 1;
            key = GetList().Max(x => x.KodCity);//מחזיר את הקוד המקסימלי
            key++;
            return key;
        }
        public void UpdateRow(City c)
        {
            c.PutInto();
            this.Update();
        }
    }
}
