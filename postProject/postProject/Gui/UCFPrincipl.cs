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
    public partial class UCFPrincipl : UserControl
    {
        public UCFPrincipl()
        {
            InitializeComponent();
        }

        private void buttonBranch_Click(object sender, EventArgs e)
        {
            panelMainOfPrincipal.Controls.Clear();
            UcBranch ucb = new UcBranch();
            panelMainOfPrincipal.Controls.Add(ucb);
            ucb.Dock = DockStyle.Fill;
        }

        private void buttonWorkOfTime_Click(object sender, EventArgs e)
        {
            panelMainOfPrincipal.Controls.Clear();
            UcWorkTime ucb = new UcWorkTime();
            panelMainOfPrincipal.Controls.Add(ucb);
            ucb.Dock = DockStyle.Fill;
        }

        private void buttonCity_Click(object sender, EventArgs e)
        {
            panelMainOfPrincipal.Controls.Clear();
            UcCity ucb = new UcCity();
            panelMainOfPrincipal.Controls.Add(ucb);
            ucb.Dock = DockStyle.Fill;
        }

        private void buttonServisKind_Click(object sender, EventArgs e)
        {
            panelMainOfPrincipal.Controls.Clear();
            UcServisKinde ucb = new UcServisKinde();
            panelMainOfPrincipal.Controls.Add(ucb);
            ucb.Dock = DockStyle.Fill;
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            panelMainOfPrincipal.Controls.Clear();
            UcClient ucb = new UcClient();
            panelMainOfPrincipal.Controls.Add(ucb);
            ucb.Dock = DockStyle.Fill;
        }

        private void buttonGetTor_Click(object sender, EventArgs e)
        {
            panelMainOfPrincipal.Controls.Clear();
            UcGetTor ucb = new UcGetTor();
            panelMainOfPrincipal.Controls.Add(ucb);
            ucb.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
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
