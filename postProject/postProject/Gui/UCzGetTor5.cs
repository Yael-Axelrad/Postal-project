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
    public partial class UCzGetTor5 : UserControl
    {
        GetTorDB gTdb = new GetTorDB(); 
        public UCzGetTor5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = Validation.choosH.ToString();
        }

        private void buttonContinyu_Click(object sender, EventArgs e)
        {
            Validation.myTor.KodT = gTdb.GetNextKeyT();
            Validation.myTor.StatusT = "true";
            gTdb.AddNew(Validation.myTor);
            label1.Visible = true;



        }
    }
}
