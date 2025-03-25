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
    public partial class UCzGetTor2 : UserControl
    {
        ServisKind sk;
        public UCzGetTor2()
        {
            InitializeComponent();
            label4.Text = Validation.brnch.CityOfBranch().NameCity;
            label5.Text = Validation.brnch.StritB;
            sk=new ServisKind();
        }

        private void buttonContinyu_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                label6.Visible = true;
                errorProvider1.SetError(label6, "לא הוקשה בחירה");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    sk = new ServisKindDB().GetList().FirstOrDefault(x => x.KodS == 1);
                }
                else
                {
                    sk = new ServisKindDB().GetList().FirstOrDefault(x => x.KodS == 2);
                }
            
        
           
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UCzGetTor3 ucG3 = new UCzGetTor3(sk);

            //modifier=public יש להגדיר את הפאנל בטופס המכיל שאליו רוצים לגשת כ 
            //לגשת לפאנל שבטופס המכיל//
            //הוספת היוזר החדש
            (this.ParentForm as FormEnter).panelMain.Controls.Add(ucG3);
            //הסרת היוזר הנוכחי מהפאנל שבטופס המכיל
            (this.ParentForm as FormEnter).panelMain.Controls.Remove(this);

            ucG3.Dock = DockStyle.Fill;
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
             
           
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UCzGetTor1 ucG1 = new UCzGetTor1();

            //modifier=public יש להגדיר את הפאנל בטופס המכיל שאליו רוצים לגשת כ 
            //לגשת לפאנל שבטופס המכיל//
            //הוספת היוזר החדש
            (this.ParentForm as FormEnter).panelMain.Controls.Add(ucG1);
            //הסרת היוזר הנוכחי מהפאנל שבטופס המכיל
            (this.ParentForm as FormEnter).panelMain.Controls.Remove(this);

            ucG1.Dock = DockStyle.Fill;
        }

        private void UCzGetTor2_Load(object sender, EventArgs e)
        {

        }

        private void buttonM_Click(object sender, EventArgs e)
        {

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //sk = new ServisKindDB().GetList().FirstOrDefault(x => x.KodS == 1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          //  sk = new ServisKindDB().GetList().FirstOrDefault(x => x.KodS ==2);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
