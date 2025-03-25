using postProject.Bll;
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
    public partial class UCzGetTor5 : UserControl
    {
        GetTorDB gTdb = new GetTorDB(); 
        public UCzGetTor5()
        {
            InitializeComponent();
            textBox1.Text = Validation.brnch.CityOfBranch().NameCity;
            textBox2.Text = Validation.brnch.StritB;
            textBox3.Text = Validation.myTor.servisKindOfTor().DescribeS;
            textBox4.Text = Validation.myTor.DateT.Date.ToString();
            textBox5.Text = Validation.myTor.HourT.ToShortTimeString().ToString();
            textBox6.Text = Validation.myTor.TzClientT.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Text = Validation.choosH.ToString();
        }

        private void buttonContinyu_Click(object sender, EventArgs e)
        {
            if (label1.Visible!= true)
            {
               Validation.myTor.KodT = gTdb.GetNextKeyT();
               Validation.myTor.StatusT = "true";
               Validation.myTor.CityT = Validation.brnch.CityOfBranch().KodCity;
               Validation.myTor.BreanchT = Validation.brnch.KodB;
               gTdb.AddNew(Validation.myTor);
               label1.Visible = true;
               button1.Visible = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void UCzGetTor5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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
