using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using postProject.Bll;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace postProject.Gui
{
    public partial class UcBAdd : UserControl
    {
        bool flagUpdate;
        BranchDB bdb = new BranchDB();
        Branch b;
        cityDB cdb;
        public UcBAdd()
        {
            InitializeComponent();
            b = new Branch();
            cdb=new cityDB();
            citycomboBox.DataSource = cdb.GetList();  
            citycomboBox.SelectedIndex = -1;
            kodtextBox.Text = bdb.GetNextKeyB().ToString();
        }

        public UcBAdd(int kod) : this()
        {
            b = bdb.SearchKod(kod);
            FillTxt();
            flagUpdate = true;
        }
        private bool CreateBranch()
        {
            bool flag = true;
            try//בדיקת שם סניף
            {
                if (branchtextBox.Text == "")
                    throw new Exception("שדה חובה");
                b.NameB=branchtextBox.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(branchtextBox, ex.Message);
                flag = false;
            }
            try//בדיקת שם עיר
            {
                if (citycomboBox.SelectedIndex == -1)
                    throw new Exception("שדה חובה");
                b.CityB = ((City)citycomboBox.SelectedItem).KodCity;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(citycomboBox, ex.Message);
                flag = false;
            }
            try//בדיקת מספר בנין
            {
                if (bildingtextBox.Text == "")
                    throw new Exception("שדה חובה");
                if(!Validation.IsNum(bildingtextBox.Text))
                    throw new Exception("ספרות בלבד");
                b.NumBildingB = Convert.ToInt32(bildingtextBox.Text);

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(bildingtextBox, ex.Message);
                flag = false;
            }
            try//בדיקת שם רחוב
            {
                if (streettextBox.Text == "")
                    throw new Exception("שדה חובה");
                b.StritB = streettextBox.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(streettextBox, ex.Message);
                flag = false;
            }
            b.KodB = Convert.ToInt32(kodtextBox.Text);
            b.StatusB = true;
            return flag;
        }

        private void addbutton_Click_1(object sender, EventArgs e)
        {
            if(CreateBranch())
            {
                 if (!flagUpdate)
                 {
                     bdb.AddNew(b);
                     kodtextBox.Text = bdb.GetNextKeyB().ToString(); 
                     branchtextBox.Text = "";
                     streettextBox.Text = "";
                     bildingtextBox.Text = "";
                     citycomboBox.Text = "";
                 }
                else
                {
                    bdb.UpdateRow(b);
                    kodtextBox.Text = "";
                    branchtextBox.Text = "";
                    streettextBox.Text = "";
                    bildingtextBox.Text = "";
                    citycomboBox.Text = "";
                }
             
            }  
            
        }
        public void FillTxt()
        {
            kodtextBox.Text = b.KodB.ToString();
            branchtextBox.Text = b.NameB;
            streettextBox.Text= b.StritB;
            bildingtextBox.Text = b.NumBildingB.ToString();
            citycomboBox.Text = b.CityOfBranch().NameCity;
        }

        private void citycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clientpanel_Paint(object sender, PaintEventArgs e)
        {

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
