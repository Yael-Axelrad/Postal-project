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
    public partial class UCzGetTor1 : UserControl
    {
        cityDB cdb;
        BranchDB bdb;
        string c;
        string br;
        public UCzGetTor1()
        {
            InitializeComponent();
            cdb = new cityDB();
            bdb = new BranchDB();
            
            comboBoxCity.DataSource = cdb.GetList().OrderBy(x=>x.NameCity).ToList();
            comboBoxCity.SelectedIndex = -1;
           
        }

     
        private void buttonGetTor_Click(object sender, EventArgs e)//בדיקה האם נבחר ישוב וסניף אם לא לא יעבור ליוזר הבא
        {
            int c = 1;
            errorProvider1.Clear();
            if (comboBoxCity.SelectedIndex == -1)// האם עיר נבחרה
              {
                c = 2;
                errorProvider1.SetError(comboBoxCity, "שדה חובה");
              }

              if (comboBoxBranch.SelectedIndex == -1)//האם נבחר סניף
              {
                c = 2;
                errorProvider1.SetError(comboBoxBranch, "שדה חובה");
              }
           
              if(c==1)//אם שתיהם נבחרו מעבר ליוזר הבא
              {
                Branch br = (Branch)comboBoxBranch.SelectedItem;//שמירת הסניף הנבחר
                b = br;
                Validation.brnch = b;//   Validation  שמירת הסניף במחלקת  
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
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCity.Text=="")
            {
                if (clientpanel.Visible)
                {
                    clientpanel.Visible = false;
                }
            }
            if (c!=comboBoxCity.Text)
            {
                if(clientpanel.Visible)
                {
                    clientpanel.Visible = false;
                }
                comboBoxBranch.SelectedIndex = -1;   
            }
            comboBoxBranch.SelectedIndex = -1;
            comboBoxBranch.DataSource = bdb.GetList().Where(x => x.CityOfBranch().NameCity == comboBoxCity.Text).OrderBy(x => x.NameB).ToList();
            comboBoxBranch.SelectedIndex = -1;
           
        }
        Branch b;



        private void buttonDetail_Click(object sender, EventArgs e)
        {
            string c = comboBoxCity.Text;
            string br = comboBoxBranch.Text;
            errorProvider1.Clear();
            if(comboBoxCity.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxCity, "שדה חובה");
            }
            if(comboBoxBranch.SelectedIndex == -1)
            { 
                errorProvider1.SetError(comboBoxBranch, "שדה חובה");
            }
            if(comboBoxCity.SelectedIndex != -1 && comboBoxBranch.SelectedIndex != -1)
            { 
                clientpanel.Visible = true;
                FillTxt();
            }
        }
        public void FillTxt()
        {
            Branch br = (Branch)comboBoxBranch.SelectedItem;
            b = br;
            Validation.brnch = b;
            branchtextBox.Text = b.NameB;
            streettextBox.Text = b.StritB;
            bildingtextBox.Text = b.NumBildingB.ToString();
            textBoxCity.Text = b.CityOfBranch().NameCity;
        }
        


            private void buttonBack_Click(object sender, EventArgs e)
        {
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UCzFclient ucfc = new UCzFclient();

            //modifier=public יש להגדיר את הפאנל בטופס המכיל שאליו רוצים לגשת כ 
            //לגשת לפאנל שבטופס המכיל//
            //הוספת היוזר החדש
            (this.ParentForm as FormEnter).panelMain.Controls.Add(ucfc);
            //הסרת היוזר הנוכחי מהפאנל שבטופס המכיל
            (this.ParentForm as FormEnter).panelMain.Controls.Remove(this);

            ucfc.Dock = DockStyle.Fill;
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

        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (br != comboBoxBranch.Text)
            {
                if (clientpanel.Visible)
                {
                    clientpanel.Visible = false;
                }
                
            }
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
