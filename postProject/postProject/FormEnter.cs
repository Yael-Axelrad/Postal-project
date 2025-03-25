using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using postProject.Gui;

namespace postProject
{
    public partial class FormEnter : Form
    {
        public FormEnter()
        {
            InitializeComponent();

            panelMain.Controls.Clear();
            UCmainEnter ucME = new UCmainEnter();
            panelMain.Controls.Add(ucME);
            ucME.Dock = DockStyle.Fill;

            
        }

    }
}
