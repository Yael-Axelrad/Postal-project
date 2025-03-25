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
    public partial class UCzGetTor4 : UserControl
    {
        public UCzGetTor4()
        {
            InitializeComponent();
            textBox1.Text = Validation.brnch.CityOfBranch().NameCity;
            textBox2.Text = Validation.brnch.StritB;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UCzGetTor3 ucG3 = new UCzGetTor3(null);

            //modifier=public יש להגדיר את הפאנל בטופס המכיל שאליו רוצים לגשת כ 
            //לגשת לפאנל שבטופס המכיל//
            //הוספת היוזר החדש
            (this.ParentForm as FormEnter).panelMain.Controls.Add(ucG3);
            //הסרת היוזר הנוכחי מהפאנל שבטופס המכיל
            (this.ParentForm as FormEnter).panelMain.Controls.Remove(this);

            ucG3.Dock = DockStyle.Fill;
        }

        private bool MoovePage()
        {
            bool flag = true;
            try
            {
                if (textBoxphone.Text == "")
                    throw new Exception("שדה חובה");
                if (!Validation.IsNum(textBoxphone.Text))
                    throw new Exception("ספרות בלבד");
                if (!Validation.IsPelepon(textBoxphone.Text))
                    throw new Exception("מספר פאלפון אינו חוקי");


            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxphone, ex.Message);
                flag = false;
            }
            try
            {
                if (textBoxagain.Text == "")
                    throw new Exception("שדה חובה");
                if (textBoxagain.Text != textBoxphone.Text)
                    throw new Exception("מספר סוללרי אינו זהה");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxagain, ex.Message);
                flag = false;
            }
            GetTorDB gTdb = new GetTorDB();
            GetTor gt = new GetTor();
            gt = gTdb.GetList().Find(x => x.TzClientT == textBoxphone.Text && x.StatusT == "true" && x.DateT >= DateTime.Now);
            if (gt != null)
            {
              //  DateTime d = gt.DateT;
              //  if (DateTime.Now < d.Date)
             //   {
                   label8.Visible = true;
                   flag = false;
            //    }
                
            }
            //   Validation.phoneNumber = textBoxphone.Text;
            Validation.myTor.TzClientT = textBoxphone.Text;
            return flag;
        }
        private void buttonContinyu_Click(object sender, EventArgs e)
        {
            if (MoovePage())
            {
                Validation.myTor.TzClientT = textBoxphone.Text;
                //הצהרת מופע ליוזר שאותו רוצים להוסיף
                UCzGetTor5 ucG5 = new UCzGetTor5();

                //modifier=public יש להגדיר את הפאנל בטופס המכיל שאליו רוצים לגשת כ 
                //לגשת לפאנל שבטופס המכיל//
                //הוספת היוזר החדש
                (this.ParentForm as FormEnter).panelMain.Controls.Add(ucG5);
                //הסרת היוזר הנוכחי מהפאנל שבטופס המכיל
                (this.ParentForm as FormEnter).panelMain.Controls.Remove(this);

                ucG5.Dock = DockStyle.Fill;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void UCzGetTor4_Load(object sender, EventArgs e)
        {

        }

        private void UCzGetTor4_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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
    }
}

