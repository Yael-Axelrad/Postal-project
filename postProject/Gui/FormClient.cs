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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UCzGetTor1 ucT1 = new UCzGetTor1();
            panel1.Controls.Add(ucT1);
            ucT1.Dock = DockStyle.Fill;
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLookAfter_Click(object sender, EventArgs e)
        {

        }
    }
}
