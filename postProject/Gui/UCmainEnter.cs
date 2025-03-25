using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace postProject.Gui
{
    public partial class UCmainEnter : UserControl
    {
        public UCmainEnter()
        {
            InitializeComponent();
            panel1.Visible= false;
            panel3.Visible= false;
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrincipal_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonClient_Click_1(object sender, EventArgs e)
        {
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UCzFclient ucG1 = new UCzFclient();

            //modifier=public יש להגדיר את הפאנל בטופס המכיל שאליו רוצים לגשת כ 
            //לגשת לפאנל שבטופס המכיל//
            //הוספת היוזר החדש
            (this.ParentForm as FormEnter).panelMain.Controls.Add(ucG1);
            //הסרת היוזר הנוכחי מהפאנל שבטופס המכיל
            (this.ParentForm as FormEnter).panelMain.Controls.Remove(this);

            ucG1.Dock = DockStyle.Fill;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            if (textBox3.Text != "1234")
            {
                label6.Visible = true;
            }
            else
            {
                //הצהרת מופע ליוזר שאותו רוצים להוסיף
                UCFPrincipl ucG1 = new UCFPrincipl();

                //modifier=public יש להגדיר את הפאנל בטופס המכיל שאליו רוצים לגשת כ 
                //לגשת לפאנל שבטופס המכיל//
                //הוספת היוזר החדש
                (this.ParentForm as FormEnter).panelMain.Controls.Add(ucG1);
                //הסרת היוזר הנוכחי מהפאנל שבטופס המכיל
                (this.ParentForm as FormEnter).panelMain.Controls.Remove(this);

                ucG1.Dock = DockStyle.Fill;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (textBox1.Text != "123")
            {
                label1.Visible = true;
            }
            else
            {
                //הצהרת מופע ליוזר שאותו רוצים להוסיף
                UCovForm ucG1 = new UCovForm();

                //modifier=public יש להגדיר את הפאנל בטופס המכיל שאליו רוצים לגשת כ 
                //לגשת לפאנל שבטופס המכיל//
                //הוספת היוזר החדש
                (this.ParentForm as FormEnter).panelMain.Controls.Add(ucG1);
                //הסרת היוזר הנוכחי מהפאנל שבטופס המכיל
                (this.ParentForm as FormEnter).panelMain.Controls.Remove(this);

                ucG1.Dock = DockStyle.Fill;
            }
        }
    }
}
