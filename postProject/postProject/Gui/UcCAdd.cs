using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            bool flag = true;
            try
            {
                if (cityNametextBox.Text == "")
                    throw new Exception("שדה חובה");
                c.NameCity = cityNametextBox.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cityNametextBox, ex.Message);
                flag = false;
            }
            c.KodCity = Convert.ToInt32(kodCtextBox.Text);
            return flag;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (CreateCity())
            {
                if (!flagUpdate)
                {
                    cdb.AddNew(c);
                    kodCtextBox.Text = cdb.GetNextKeyC().ToString();
                    cityNametextBox.Text = "";
                }
                else
                {
                    cdb.UpdateRow(c);
                    kodCtextBox.Text = "";
                    cityNametextBox.Text = "";
                }
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
    }
}

