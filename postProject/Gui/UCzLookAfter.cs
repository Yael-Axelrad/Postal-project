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
    public partial class UCzLookAfter : UserControl
    {
        DeliversDB dlvrdb;
        Delivers dlvr;
        Delivers keep;
        Clients keepC;
        ClientsDB clntdb;
        cityDB ctdb;
        BranchDB brndb;
        Branch brnch;
       
        string kod;
        public UCzLookAfter()
        {
            dlvrdb = new DeliversDB();
            dlvr = new Delivers();
            keep = new Delivers();
            clntdb = new ClientsDB();
            keepC = new Clients();
            ctdb = new cityDB();
            brndb = new BranchDB();
            brnch = new Branch();
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            radioButton1.ForeColor = Color.Gray; radioButton1.Checked = false; 
            radioButton2.ForeColor = Color.Gray; radioButton2.Checked = false;
            radioButton3.ForeColor = Color.Gray; radioButton3.Checked = false;
            radioButton4.ForeColor = Color.Gray; radioButton4.Checked = false;
            radioButton5.ForeColor = Color.Gray; radioButton5.Checked = false;
            radioButton6.ForeColor = Color.Gray; radioButton6.Checked = false;
            button2.Visible= false;
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "שדה חובה");
            }
            else
            {
                dlvr = dlvrdb.SearchKod(textBox1.Text);
                if (dlvr == null)
                {
                    kod = textBox1.Text;
                    labelM.Visible = true;
                }
               else
                {
                    if ("נמסר" == dlvr.StatusD.ToString())
                    {
                        label9.Visible = true;
                    }
                    else
                    {
                        if (radioButton1.Text == dlvr.StatusD.ToString())
                        {
                            radioButton1.ForeColor = Color.Red;
                            radioButton1.Checked = true;
                        }
                        if (radioButton2.Text == dlvr.StatusD.ToString())
                        {
                            radioButton2.ForeColor = Color.Red;
                            radioButton2.Checked = true;
                        }
                        if (radioButton3.Text == dlvr.StatusD.ToString())
                        {
                            radioButton3.ForeColor = Color.Red;
                            radioButton3.Checked = true;
                        }
                        if (radioButton4.Text == dlvr.StatusD.ToString())
                        {
                            radioButton4.ForeColor = Color.Red;
                            radioButton4.Checked = true;
                        }
                        if (radioButton5.Text == dlvr.StatusD.ToString())
                        {
                            radioButton5.ForeColor = Color.Red;
                            radioButton5.Checked = true;
                            button2.Visible = true;
                        }
                        if (radioButton6.Text == dlvr.StatusD.ToString())
                        {
                            radioButton6.ForeColor = Color.Red;
                            radioButton6.Checked = true;
                        }
                        panel1.Visible = true;
                    }
                }
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (panel1.Visible||panel2.Visible)
            {
                if (textBox1.Text != kod)
                {
                    panel1.Visible = false;
                    panel2.Visible = false;
                }
            }
            
            if (labelM.Visible)
            {
                if (textBox1.Text=="")
                {
                   labelM.Visible = false;
                }
                if (textBox1.Text!=kod)
                {
                    labelM.Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = textBox1.Text;
            keep = dlvrdb.SearchKod(textBox1.Text);
            keepC = clntdb.SearchKodClient(keep.NameGetD);
            textBox2.Text = ctdb.SearchKodCity(keepC.CityC).NameCity.ToString();
            brnch = brndb.SearchKod(keepC.BranchC);
            textBox2.Text = brnch.CityOfBranch().NameCity.ToString();
            textBox3.Text = brnch.NameB.ToString();
            textBox5.Text = brnch.NumBildingB.ToString();
            textBox4.Text = brnch.StritB.ToString(); ;
            panel2.Visible = true;

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
          

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
