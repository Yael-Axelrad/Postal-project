using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using postProject.Bll;

namespace postProject.Gui
{
    public partial class UCzGetTor3 : UserControl
    {
        ServisKind sk;
        GetTorDB gtDB;
        GetTor gt = null;
        public UCzGetTor3(ServisKind sk)
        {
            InitializeComponent();
            this.sk = sk;

            textBox1.Text = Validation.brnch.CityOfBranch().NameCity;
            textBox2.Text = Validation.brnch.StritB;
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(13);
        }

        private void FillCombo()
        {
            DateTime dt = dateTimePicker1.Value;
            DateTime dtCheck = dateTimePicker1.Value;
            
            //שליפה של המשמרות של היום שנבחר בסניף הרצוי
            List<WorkTime> workTimes = new WorkTimeDB().GetList().Where(x =>x.BranchkodT==Validation.brnch.KodB && x.DayT == Validation.GetNameDay(dt.Date.DayOfWeek.GetHashCode()).ToString()).OrderBy(K=>K.OpenT.Hour).ToList();
            //לןלאה שעוברת על כל המשמרות של אותו סניף ויום שנבחר ברשימה שנוצרה בשורה הקודמת
            foreach (WorkTime workTime in workTimes)
            {
                //שמירת התאריך שבחר עם שעת הפתיחה של הסניף
                dt = new DateTime(dt.Year, dt.Month, dt.Day, workTime.OpenT.TimeOfDay.Hours, workTime.OpenT.TimeOfDay.Minutes, 0); 
                dtCheck = new DateTime(dt.Year, dt.Month, dt.Day, workTime.OpenT.TimeOfDay.Hours, workTime.OpenT.TimeOfDay.Minutes, 0); 
                dtCheck = new DateTime(dt.Year, dt.Month, dt.Day, workTime.OpenT.TimeOfDay.Hours, workTime.OpenT.TimeOfDay.Minutes, 0); 
              
                //משעת הפתיחה עד הסגירה של משמרת מסויימת combo  לולאה הממלא את ה
                while (dt.TimeOfDay < workTime.ClosseT.TimeOfDay) //שעת סגירה
                {
                    dtCheck = dt;
                    dtCheck = dtCheck.AddMinutes(Validation.sss.LongS);
                    //חיפוש עם שאילתא תור בשעה ובזמן וסניף אם לא ריק לא יוסיף
                    gt = new GetTorDB().GetListFull().FirstOrDefault(x => x.DateT.Date == dt.Date && (x.HourT.TimeOfDay >=dt.TimeOfDay && x.HourT.TimeOfDay<dtCheck.TimeOfDay) && x.StatusT == "true");
                    if (gt == null)
                    {                        
                        comboBoxTime.Items.Add(dt.TimeOfDay.ToString());

                        dt = dt.AddMinutes(Validation.sss.LongS);
                    }
                   else
                    {
                        //אם מצא תור מוסיף לזמן את משך זמן התור התפוס
                        dt = dt.AddMinutes(gt.servisKindOfTor().LongS);
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UCzGetTor2 ucG2 = new UCzGetTor2();

            //modifier=public יש להגדיר את הפאנל בטופס המכיל שאליו רוצים לגשת כ 
            //לגשת לפאנל שבטופס המכיל//
            //הוספת היוזר החדש
            (this.ParentForm as FormEnter).panelMain.Controls.Add(ucG2);
            //הסרת היוזר הנוכחי מהפאנל שבטופס המכיל
            (this.ParentForm as FormEnter).panelMain.Controls.Remove(this);

            ucG2.Dock = DockStyle.Fill;
        }
       // DateTime dchH = new DateTime();
        private void buttonContinyu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (comboBoxTime.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxTime, "לא הוקשה בחירה");
            }
            else
            {
                string s = comboBoxTime.SelectedItem.ToString();
                string sh = s.Substring(0, 2);// s[0] + s[1];// (comboBoxTime.Text.ToString()[0] + comboBoxTime.SelectedItem.ToString()[1]).ToString();
                string sm = s.Substring(3, 2);// (comboBoxTime.Text.ToString()[3] + comboBoxTime.SelectedItem.ToString()[4]).ToString();
                DateTime  dchH =new DateTime(dateTimePicker1.Value.Year,dateTimePicker1.Value.Month,dateTimePicker1.Value.Day,Convert.ToInt32(sh) ,Convert.ToInt32(sm), 0);

                Validation.myTor.DateT = dateTimePicker1.Value;
                Validation.myTor.HourT = dchH;
                Validation.myTor.KindT = Validation.sss.KodS;

                //הצהרת מופע ליוזר שאותו רוצים להוסיף
                UCzGetTor4 ucG4 = new UCzGetTor4();

               //modifier=public יש להגדיר את הפאנל בטופס המכיל שאליו רוצים לגשת כ 
               //לגשת לפאנל שבטופס המכיל//
               //הוספת היוזר החדש
               (this.ParentForm as FormEnter).panelMain.Controls.Add(ucG4);
               //הסרת היוזר הנוכחי מהפאנל שבטופס המכיל
               (this.ParentForm as FormEnter).panelMain.Controls.Remove(this);

               ucG4.Dock = DockStyle.Fill;
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//מעבר לכניסה ראשית
        {
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UCmainEnter ucME = new UCmainEnter();

            //modifier=public יש להגדיר את הפאנל בטופס המכיל שאליו רוצים לגשת כ 
            //לגשת לפאנל שבטופס המכיל//
            //הוספת היוזר החדש
            (this.ParentForm as FormEnter).panelMain.Controls.Add(ucME);
            //הסרת היוזר הנוכחי מהפאנל שבטופס המכיל
            (this.ParentForm as FormEnter).panelMain.Controls.Remove(this);

            ucME.Dock = DockStyle.Fill;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            comboBoxTime.Items.Clear();
            if (dateTimePicker1.Value.DayOfWeek != DayOfWeek.Saturday)
            {
                label6.Visible = false;
            }
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                label6.Visible = true;
            }
            else 
                FillCombo();
        }

        private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UCzGetTor3_Load(object sender, EventArgs e)
        {

        }
    }
}
