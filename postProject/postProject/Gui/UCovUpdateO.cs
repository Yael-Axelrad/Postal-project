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
    public partial class UCovUpdateO : UserControl
    {
        DeliversDB dlvrdb;
        Delivers dlvr;

        string kod;
        public UCovUpdateO()
        {
            dlvrdb = new DeliversDB();
            dlvr = new Delivers();  
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (textBox1.Text=="")
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
                    label5.Text = dlvr.StatusD.ToString();
                    labelK.Text = dlvr.NumD;
                    if (radioButton1.Text == dlvr.StatusD.ToString())
                    {
                        radioButton1.Checked = true;
                    }
                    if (radioButton2.Text == dlvr.StatusD.ToString())
                    {
                        radioButton2.Checked = true;
                    }
                    if (radioButton3.Text == dlvr.StatusD.ToString())
                    {
                        radioButton3.Checked = true;
                    }
                    if (radioButton4.Text == dlvr.StatusD.ToString())
                    {
                        radioButton4.Checked = true;
                    }
                    if (radioButton5.Text == dlvr.StatusD.ToString())
                    {
                        radioButton5.Checked = true;
                    }
                    if (radioButton6.Text == dlvr.StatusD.ToString())
                    {
                        radioButton6.Checked = true;
                    }
                    panel1.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dlvr.StatusD = "";
            if (radioButton1.Checked) { dlvr.StatusD = radioButton1.Text; }
            if (radioButton2.Checked) { dlvr.StatusD = radioButton2.Text; }
            if (radioButton3.Checked) { dlvr.StatusD = radioButton3.Text; }
            if (radioButton4.Checked) { dlvr.StatusD = radioButton4.Text; }
            if (radioButton5.Checked) { dlvr.StatusD = radioButton5.Text; }
            if (radioButton6.Checked) { dlvr.StatusD = radioButton6.Text; }
            dlvrdb.UpdateRow(dlvr);
            panel1.Visible = false;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                if (textBox1.Text != kod)
                {
                    panel1.Visible = false;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
