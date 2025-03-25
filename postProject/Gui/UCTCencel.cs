using postProject.Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace postProject.Gui
{
    public partial class UCTCencel : UserControl
    {
        public UCTCencel()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UCzFclient ucME = new UCzFclient();

            //modifier=public יש להגדיר את הפאנל בטופס המכיל שאליו רוצים לגשת כ 
            //לגשת לפאנל שבטופס המכיל//
            //הוספת היוזר החדש
            (this.ParentForm as FormEnter).panelMain.Controls.Add(ucME);
            //הסרת היוזר הנוכחי מהפאנל שבטופס המכיל
            (this.ParentForm as FormEnter).panelMain.Controls.Remove(this);

            ucME.Dock = DockStyle.Fill;
        }

        private void buttonContinyu_Click(object sender, EventArgs e)
        {
            if (!label9.Visible)
            {
                gt.StatusT = "false";
                gtdb.UpdateRow(gt);
                label9.Visible = true;
                button2.Visible = true;
            }

        }

        GetTorDB gtdb = new GetTorDB();
        GetTor gt = new GetTor();
        private void textBoxphone_TextChanged(object sender, EventArgs e)
        {
            string t = textBoxphone.Text;
            if (textBox7.Visible == true)
            {
                textBox7.Visible = false;
            }
            if (!Validation.IsPelepon(t))
            {
                textBox7.Text = "מספר פלפון אינו חוקי";
                textBox7.Visible = true;
                panel1.Visible = false;
            }
            else
            {

                gt = gtdb.GetList().Find(x => x.TzClientT == t && x.StatusT == "true" && x.DateT >= DateTime.Now);
                if (gt == null)
                {
                    textBox7.Text = "אין תורים במערכת!";
                    textBox7.Visible = true;
                }
                else 
                {
                    textBox1.Text = gt.CityOfTor().NameCity;
                    textBox2.Text = gt.BreanchOfTor().NameB;
                    textBox3.Text = gt.servisKindOfTor().DescribeS;
                    textBox4.Text = gt.DateT.Date.ToString();
                    textBox5.Text = gt.HourT.ToShortTimeString().ToString();
                    textBox6.Text = gt.TzClientT;
                    panel1.Visible = true;

                }
            }

        }
    }
}

