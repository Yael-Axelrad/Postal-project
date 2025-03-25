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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonBranch_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBranch_Click_1(object sender, EventArgs e)//מציג את היוזר של הסניפים
        {
            panelMainOfPrincipal.Controls.Clear();
            UcBranch ucb = new UcBranch();
            panelMainOfPrincipal.Controls.Add(ucb);
            ucb.Dock = DockStyle.Fill;
        }

        private void buttonWorkOfTime_Click(object sender, EventArgs e)//מציג את היוזר של שעות העבודה
        {
            panelMainOfPrincipal.Controls.Clear();
            UcWorkTime ucw = new UcWorkTime();
            panelMainOfPrincipal.Controls.Add(ucw);
            ucw.Dock = DockStyle.Fill;
        }

        private void buttonCity_Click_1(object sender, EventArgs e)//מציג את היוזר של הערים
        {
            panelMainOfPrincipal.Controls.Clear();
            UcCity ucc = new UcCity();
            panelMainOfPrincipal.Controls.Add(ucc);
            ucc.Dock = DockStyle.Fill;
        }

        private void buttonGetTor_Click(object sender, EventArgs e)//מציג את היוזר של זמון תור
        {
            panelMainOfPrincipal.Controls.Clear();
            UcGetTor ucg = new UcGetTor();
            panelMainOfPrincipal.Controls.Add(ucg);
            ucg.Dock = DockStyle.Fill;
        }

        private void buttonClient_Click(object sender, EventArgs e)//מציג את היוזר של לקוחות
        {
            panelMainOfPrincipal.Controls.Clear();
            UcClient ucc = new UcClient();
            panelMainOfPrincipal.Controls.Add(ucc);
            ucc.Dock = DockStyle.Fill;
        }

        private void buttonServisKind_Click(object sender, EventArgs e)//מציג את היוזר של סוג שרות
        {
            panelMainOfPrincipal.Controls.Clear();
            UcServisKinde ucs = new UcServisKinde();
            panelMainOfPrincipal.Controls.Add(ucs);
            ucs.Dock = DockStyle.Fill;
        }
    }
}
