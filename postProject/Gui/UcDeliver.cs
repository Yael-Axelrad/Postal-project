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
    public partial class UcDeliver : UserControl
    {
        DeliversDB dlvrdb;
        Delivers keep;
        string kod;
        public UcDeliver()
        {
            dlvrdb = new DeliversDB();
            keep = new Delivers();
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
                    if (keep.StatusD != "המשלוח בנקודת החלוקה")
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

        private void addbutton_Click(object sender, EventArgs e)
        {
            keep.StatusD = "נמסר";
            dlvrdb.UpdateRow(keep);
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
    }
}
