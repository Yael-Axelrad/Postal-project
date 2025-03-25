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
    public partial class UcClient : UserControl
    {
        ClientsDB tbl_clients;
        Clients clnt;
        public UcClient()
        {
            InitializeComponent();
            tbl_clients = new ClientsDB();
            //מילוי הגריד
            dataGridView1.DataSource = tbl_clients.GetList().Where(x => x.StatusC == true).Select(x=> new {שם = x.FirstNameC,משפחה = x.LastNameC,פלאפון= x.TelC,עיר = x.CityOfClient(),סניף = x.BreanchOfClient()}).OrderBy(x => x.משפחה).ToList();
            //מאפיינים של dataGridView
            //מאפיין המגדיר שיבחר כל פעם שורה שלמה
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //מימין לשמאל
            dataGridView1.RightToLeft = RightToLeft;
            //לקריאה בלבד
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UcCLAdd ucW = new UcCLAdd();
            Parent.Controls.Add(ucW);
            ucW.Dock = DockStyle.Fill;
            Parent.Controls.Remove(this);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string kod = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UcCLAdd ucB = new UcCLAdd(kod);
            Parent.Controls.Add(ucB);
            ucB.Dock = DockStyle.Fill;
            Parent.Controls.Remove(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UCmainEnter ucME = new UCmainEnter();
            Parent.Parent.Parent.Controls.Add(ucME);
            ucME.Dock = DockStyle.Fill;
            Parent.Parent.Parent.Controls.Remove(this.Parent.Parent);
        }

        private void buttonDelate_Click(object sender, EventArgs e)
        {
            string kod = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            clnt = tbl_clients.SearchKodClient(kod);
            clnt.StatusC = false;
            tbl_clients.UpdateRow(clnt);
            tbl_clients = new ClientsDB();
            //מילוי הגריד
            dataGridView1.DataSource = tbl_clients.GetList().Where(x => x.StatusC == true).Select(x => new { שם = x.FirstNameC, משפחה = x.LastNameC, פלאפון = x.TelC, עיר = x.CityOfClient(), סניף = x.BreanchOfClient() }).ToList();
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
