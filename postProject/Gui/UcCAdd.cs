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
using System.Xml.Linq;
using postProject.Bll;

namespace postProject.Gui
{
    public partial class UcCAdd : UserControl
    {
        bool flagUpdate;
        cityDB cdb = new cityDB();
        City c;

        public UcCAdd(int kod) : this()
        {
            c = cdb.SearchKodCity(kod);
            FillTxt();
            flagUpdate = true;
        }
        public UcCAdd()
        { 
            InitializeComponent();
            c = new City();
            cdb = new cityDB();
            kodCtextBox.Text = cdb.GetNextKeyC().ToString();
        }
        private bool CreateCity()
        {
            City cty;
            label1.Visible=false;
            errorProvider1.Clear();
            errorProvider2.Clear();
            bool flag = true;
            try
            {
                if (cityNametextBox.Text == "")
                    throw new Exception("שדה חובה");
                if (Validation.IsNum(cityNametextBox.Text))
                    throw new Exception("אותיות בלבד");
                if (!Validation.IsHebrew(cityNametextBox.Text))
                    throw new Exception("אותיות בעברית בלבד");
                if (cityNametextBox.Text.Length < 2)
                    throw new Exception("הקש שם מלא");
                c.NameCity = cityNametextBox.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cityNametextBox, ex.Message);
                flag = false;
            }
           
            cty = cdb.SearchNameCity(cityNametextBox.Text);
            if (cty!=null)
            {
                    label1.Visible = true;
                    errorProvider1.SetError(label1, " ");
                    flag = false;
                
            }   
            c.KodCity = Convert.ToInt32(kodCtextBox.Text);
            c.StatusC = true;
            return flag;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (CreateCity())
            {
                if (!flagUpdate)
                {
                    cdb.AddNew(c);
                   
                }
                else
                {
                    cdb.UpdateRow(c);
                    kodCtextBox.Text = "";
                    cityNametextBox.Text = "";
                }
                //הצהרת מופע ליוזר שאותו רוצים להוסיף
                UcCity ucW = new UcCity();
                Parent.Controls.Add(ucW);
                ucW.Dock = DockStyle.Fill;
                Parent.Controls.Remove(this);
            }
        }
        public void FillTxt()
        {
            kodCtextBox.Text = c.KodCity.ToString();
            cityNametextBox.Text = c.NameCity;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UCmainEnter ucME = new UCmainEnter();
            Parent.Parent.Parent.Controls.Add(ucME);
            ucME.Dock = DockStyle.Fill;
            Parent.Parent.Parent.Controls.Remove(this.Parent.Parent);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UCmainEnter ucME = new UCmainEnter();
            Parent.Parent.Parent.Controls.Add(ucME);
            ucME.Dock = DockStyle.Fill;
            Parent.Parent.Parent.Controls.Remove(this.Parent.Parent);
        }

        private void clientpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kodCtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cityNametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

