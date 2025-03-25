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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace postProject.Gui
{
    public partial class UCplaicOfOrder : UserControl
    {
        DeliversDB dlvrdb;
        Delivers keep;
        Clients keepC;
        ClientsDB clntdb;
        cityDB ctdb;
        BranchDB brndb;
        Bll.Branch brnch;

        string kod;
        public UCplaicOfOrder()
        {
            dlvrdb = new DeliversDB();
            keep = new Delivers();
            clntdb = new ClientsDB();
            keepC = new Clients();
            ctdb = new cityDB();
            brndb = new BranchDB();
            brnch = new Bll.Branch();
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "שדה חובה");
            }
            else
            {
                keep = dlvrdb.SearchKod(textBox1.Text);
                if (keep == null)
                {
                    kod = textBox1.Text;
                    labelM.Visible = true;
                }
                else
                { 
                   if (keep.StatusD!= "המשלוח בנקודת החלוקה")
                   {
                        labelM.Visible = true;
                   }
                    else
                    {
                        panel2.Visible = true;
                    }
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                if (textBox1.Text != kod)
                {
                    panel2.Visible = false;
                }
            }

            if (labelM.Visible)
            {
                if (textBox1.Text == "")
                {
                    labelM.Visible = false;
                }
                if (textBox1.Text != kod)
                {
                    labelM.Visible = false;
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            label9.Text = textBox1.Text;
            keep = dlvrdb.SearchKod(textBox1.Text);
            keepC = clntdb.SearchKodClient(keep.NameGetD);
            textBox2.Text = ctdb.SearchKodCity(keepC.CityC).NameCity;
            brnch = brndb.SearchKod(keepC.BranchC);
            textBox3.Text = brnch.NameB;
            textBox4.Text = brnch.StritB;
            textBox5.Text = Convert.ToInt32(brnch.NumBildingB).ToString();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelM_Click(object sender, EventArgs e)
        {

        }
    }
}
