using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using postProject.Bll;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Reflection.Emit;
using System.Windows.Forms.VisualStyles;

namespace postProject.Gui
{
    public partial class UcCLAdd : UserControl
    {
        bool flagUpdate;
        cityDB ctdb;
        BranchDB bdb;  
        ClientsDB cbd = new ClientsDB();
        Clients c = new Clients();
        City cty;
        public UcCLAdd()
        {
            InitializeComponent();
            ctdb = new cityDB();
            bdb = new BranchDB();
            citycomboBox.DataSource = ctdb.GetList();//מילוי הקומבו של העיר
            citycomboBox.DataSource = ctdb.GetList().OrderBy(x => x.NameCity).ToList();
            citycomboBox.SelectedIndex = -1;
        }

        public UcCLAdd(string kod) : this()
        {
            c = cbd.SearchKodClient(kod);
            FillTxt();
            flagUpdate = true;
        }


        private bool CreateClient()//בדיקת תקינות לקוח
        {
            errorProvider1.Clear();
            bool flag = true;
            try
            {
                string t = textBoxTel.Text;
                Clients i = cbd.SearchKodClient(t);
                if (i != null)
                     throw new Exception("קיים לקוח זה במערכת");
                    
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxTel, ex.Message);
                flag = false;
            }
            try//בדיקת מס פלאפון
            {
                if (textBoxTel.Text == "")
                    throw new Exception("שדה חובה");
                c.TelC = textBoxTel.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxTel, ex.Message);
                flag = false;
            }
            try//בדיקת שם פרטי
            {
                if (textBox2.Text == "")
                    throw new Exception("שדה חובה");
                if (!Validation.IsHebrew(textBox2.Text))
                    throw new Exception("אותיות בעברית בלבד");
                if (Validation.IsNum(textBox2.Text))
                    throw new Exception("אותיות בלבד");
                if (textBox2.Text.Length < 2)
                    throw new Exception("הקש שם מלא");
                c.FirstNameC = textBox2.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox2, ex.Message);
                flag = false;
            }
            try//בדיקת שם משפחה
            {
                if (textBox3.Text == "")
                    throw new Exception("שדה חובה");
                if (!Validation.IsHebrew(textBox3.Text))
                    throw new Exception("אותיות בעברית בלבד");
                if (Validation.IsNum(textBox3.Text))
                    throw new Exception("אותיות בלבד");
                if (textBox3.Text.Length < 2)
                    throw new Exception("הקש שם מלא");
                c.LastNameC = textBox3.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox3, ex.Message);
                flag = false;
            }
            try//בדיקת עיר
            {
                if (citycomboBox.SelectedIndex == -1)
                {
                    if (citycomboBox.Text == "")
                    {
                        throw new Exception("שדה חובה");
                    }
                    throw new Exception("עיר אינה חוקית");
                }
                c.CityC = ((City)citycomboBox.SelectedItem).KodCity;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(citycomboBox, ex.Message);
                flag = false;
            }
            try//בדיקת סניף
            {
                if (comboBoxBreanch.SelectedIndex == -1)
                {
                    if (comboBoxBreanch.Text == "")
                    {
                        throw new Exception("שדה חובה");
                    }
                    throw new Exception("סניף אינו חוקי");
                }
                c.BranchC = ((Branch)comboBoxBreanch.SelectedItem).KodB;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(comboBoxBreanch, ex.Message);
                flag = false;
            }
            c.StatusC = true;
            return flag;
        }

        private void button1_Click(object sender, EventArgs e)//בדיקה אם הוספה או עדכון
        {
            if (CreateClient())
            {
                if (!flagUpdate)
                {
                    cbd.AddNew(c);
                }
                else
                {
                    cbd.UpdateRow(c);
                }
                //הצהרת מופע ליוזר שאותו רוצים להוסיף
                UcClient ucW = new UcClient();
                Parent.Controls.Add(ucW);
                ucW.Dock = DockStyle.Fill;
                Parent.Controls.Remove(this);
            }  
        }

        private void citycomboBox_SelectedIndexChanged(object sender, EventArgs e)//שמירת העיר ומילוי הקומבו של הסניף
        {
            cty = (City)citycomboBox.SelectedItem;
            comboBoxBreanch.SelectedIndex = -1;
            comboBoxBreanch.DataSource = bdb.GetList().Where(x => x.CityOfBranch().NameCity == citycomboBox.Text).ToList().OrderBy(x => x.NameB).ToList();
            comboBoxBreanch.SelectedIndex = -1;
        }

        public void FillTxt()//מילוי בעידכון
        {
            textBox2.Text = c.FirstNameC;
            textBox3.Text = c.LastNameC;
            textBoxTel.Text = c.TelC;
            citycomboBox.Text = ctdb.SearchKodCity(c.CityC).ToString();
            comboBoxBreanch.Text = bdb.SearchKod(c.BranchC).ToString();
        }

        private void comboBoxBreanch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cty.NameCity != citycomboBox.Text)//אם שינה עיר להסיר סניף
            {
                comboBoxBreanch.SelectedIndex = -1;
            }
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

        private void panelAdd_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
