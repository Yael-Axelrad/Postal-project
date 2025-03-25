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

namespace postProject.Gui
{
    public partial class UcSAdd : UserControl
    {
        bool flagUpdate;
        ServisKindDB sdb = new ServisKindDB();
        ServisKind s;
        public UcSAdd()
        {
            InitializeComponent();
            s = new ServisKind();
            sdb = new ServisKindDB();

        }

        private void addbutton_Click(object sender, EventArgs e)
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
