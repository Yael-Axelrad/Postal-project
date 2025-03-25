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
    public partial class UcCity : UserControl
    {
        cityDB tbl_city;
        public UcCity()// פעולה בונה להצגת טבלת ערים
        {
            InitializeComponent();
            tbl_city = new cityDB();
            //מילוי הגריד
            dataGridView1.DataSource = tbl_city.GetList();
            //מאפיינים של dataGridView
            //מאפיין המגדיר שיבחר כל פעם שורה שלמה
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //מימין לשמאל
            dataGridView1.RightToLeft = RightToLeft;
            //לקריאה בלבד
            dataGridView1.ReadOnly = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)//מעבר ליוזר של הוספת עיר
        {
            UcCAdd ucC = new UcCAdd();
            panel1.Controls.Add(ucC);
            ucC.Dock = DockStyle.Fill;
            panel1.Controls.Remove(dataGridView1);
        }

        private void buttonChange_Click(object sender, EventArgs e)//מעבר ליוזר של עדכון עיר
        {
            int kod = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UcCAdd ucC = new UcCAdd(kod);
            panel1.Controls.Add(ucC);
            ucC.Dock = DockStyle.Fill;
            panel1.Controls.Remove(dataGridView1);
        }

        private void UcCity_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
