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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace postProject.Gui
{
    public partial class UcSAdd : UserControl
    {
        bool flagUpdate;
        ServisKindDB sdb ;
        ServisKind s;
        public UcSAdd()
        {
            InitializeComponent();
            s = new ServisKind();
            sdb = new ServisKindDB();
           
        }
        public UcSAdd(int kod) : this()
        {
            s = sdb.SearchKodServisKind(kod);
            FillTxt();
        }

        public bool createSevice()
        {
            errorProvider1.Clear();
            bool flag = true;
            try//בדיקת שם סניף
            {
                if (deckribetextBox.Text == "")
                    throw new Exception("שדה חובה");
                if (!Validation.IsHebrew(deckribetextBox.Text))
                    throw new Exception("אותיות בעברית בלבד");
                if (Validation.IsNum(deckribetextBox.Text))
                    throw new Exception("אותיות בלבד");
                if (deckribetextBox.Text.Length < 2)
                    throw new Exception("הקש שם מלא");
                s.DescribeS = deckribetextBox.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(deckribetextBox, ex.Message);
                flag = false;
            }

            try//בדיקת שם סניף
            {
                if (longtextBox.Text == "")
                    throw new Exception("שדה חובה");
                s.LongS = Convert.ToInt32(longtextBox.Text);

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(longtextBox, ex.Message);
                flag = false;
            }
            s.KodS =Convert.ToInt32( kodtextBox.Text);
            return flag;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UCmainEnter ucME = new UCmainEnter();
            Parent.Parent.Parent.Controls.Add(ucME);
            ucME.Dock = DockStyle.Fill;
            Parent.Parent.Parent.Controls.Remove(this.Parent.Parent);
        }
        public void FillTxt()
        {
            kodtextBox.Text = s.KodS.ToString();
            deckribetextBox.Text = s.DescribeS;
            longtextBox.Text = s.LongS.ToString();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if(createSevice())
            {
                sdb.UpdateRow(s);
                //הצהרת מופע ליוזר שאותו רוצים להוסיף
                UcServisKinde ucW = new UcServisKinde();
                Parent.Controls.Add(ucW);
                ucW.Dock = DockStyle.Fill;
                Parent.Controls.Remove(this);
            }
          
        }
    }   
}
