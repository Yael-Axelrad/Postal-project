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
        City cty = new City(); 
        public UcCity()// פעולה בונה להצגת טבלת ערים
        {
            InitializeComponent();
            tbl_city = new cityDB();
            //מילוי הגריד
            dataGridView1.DataSource = tbl_city.GetList().Where(x => x.StatusC == true).Select(x=> new {קוד = x.KodCity,שם = x.NameCity}).OrderBy(x => x.שם).ToList();
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
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UcCAdd ucW = new UcCAdd();
            Parent.Controls.Add(ucW);
            ucW.Dock = DockStyle.Fill;
            Parent.Controls.Remove(this);
        }

        private void buttonChange_Click(object sender, EventArgs e)//מעבר ליוזר של עדכון עיר
        {
            int kod = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UcCAdd ucW = new UcCAdd();
            Parent.Controls.Add(ucW);
            ucW.Dock = DockStyle.Fill;
            Parent.Controls.Remove(this);
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

        private void buttonDelate_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            cty = tbl_city.SearchKodCity(kod);
            cty.StatusC = false;
            tbl_city.UpdateRow(cty);
            tbl_city = new cityDB();
            //מילוי הגריד
            dataGridView1.DataSource = tbl_city.GetList().Where(x => x.StatusC == true).Select(x => new { קוד = x.KodCity, שם = x.NameCity }).ToList();
            //מאפיינים של dataGridView
            //מאפיין המגדיר שיבחר כל פעם שורה שלמה
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //מימין לשמאל
            dataGridView1.RightToLeft = RightToLeft;
            //לקריאה בלבד
            dataGridView1.ReadOnly = true;
        }
    }
}
