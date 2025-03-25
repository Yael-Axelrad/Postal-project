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
    public partial class UcGetTor : UserControl
    {
        GetTorDB tbl_getTor;
        public UcGetTor()
        {
            InitializeComponent();
            tbl_getTor = new GetTorDB();
            //מילוי הגריד
            dataGridView1.DataSource = tbl_getTor.GetList().Where(x=> x.StatusT == "true").Select(x => new {פלאפון_לקוח=x.TzClientT,קוד_תור = x.KodT,תאריך = x.DateT.Date,שעה=x.HourT.ToShortTimeString(), סוג_שירות= x.servisKindOfTor().DescribeS,סניף = x.BreanchOfTor(),עיר = x.CityOfTor()}).ToList();
            //מאפיינים של dataGridView
            //מאפיין המגדיר שיבחר כל פעם שורה שלמה
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //מימין לשמאל
            dataGridView1.RightToLeft = RightToLeft;
            //לקריאה בלבד
            dataGridView1.ReadOnly = true;
        }

        private void buttonChange_Click(object sender, EventArgs e)
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
