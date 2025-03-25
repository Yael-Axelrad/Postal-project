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
        public List<GetTor> GetListFull()
        {
            List<GetTor> lisFulltGetTor = new List<GetTor>();

            listGetTor.Clear();
            //לולאה העוברת על אוסף השורות שבטבלה
            foreach (DataRow dr in dt.Rows)
            {
                //הוספת פריט לרשימה עי שימוש בפעולה בונה של המחלקה 
                //המקבלת שורה ושופכת לתכונות העצם
                lisFulltGetTor.Add(new GetTor(dr));
                GetTor gt=new GetTor(dr);
                GetTor gtNew=new GetTor(dr);
                for (int i = 1; i < gt.servisKindOfTor().LongS; i++)
                {
                    gtNew.HourT=gtNew.HourT.AddMinutes(1);
                    lisFulltGetTor.Add(gtNew);
                }
            }
            return lisFulltGetTor;
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
        public GetTor SearchKodTor(string kod)//פעולה המחזירה שורה של תור
        {
            return GetList().Find(x => x.TzClientT == kod);
        }
        public void UpdateRow(GetTor g)
        {
            g.PutInto();
            this.Update();
        }
    }
}