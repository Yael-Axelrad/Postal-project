using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using postProject.Bll;

namespace postProject.Gui
{
    public partial class UcBranch : UserControl
    {
        BranchDB tbl_branch;
        Branch btch1= new Branch();
        public UcBranch()//פעולה בונה למילוי טבלת סניפים
        {
            InitializeComponent();
            tbl_branch = new BranchDB();
            //מילוי הגריד
            dataGridView1.DataSource = tbl_branch.GetList().Where(x=>x.StatusB==true).ToList();
            //מאפיינים של dataGridView
            //מאפיין המגדיר שיבחר כל פעם שורה שלמה
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //מימין לשמאל
            dataGridView1.RightToLeft = RightToLeft;
            //לקריאה בלבד
            dataGridView1.ReadOnly = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)//מעבר ליוזר של הוספת סניף
        {
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UcBAdd ucME = new UcBAdd();
            panel1.Controls.Add(ucME);
            ucME.Dock = DockStyle.Fill;
            panel1.Controls.Remove(dataGridView1);


           
        }

        private void buttonChange_Click(object sender, EventArgs e)//מעבר ליוזר של עדכון סניף
        {
            int kod = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UcBAdd ucB = new UcBAdd(kod);
            panel1.Controls.Add(ucB);
            ucB.Dock = DockStyle.Fill;
            panel1.Controls.Remove(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UCmainEnter ucME = new UCmainEnter();
            Parent.Parent.Parent.Controls.Add(ucME);
            ucME.Dock = DockStyle.Fill;
            Parent.Parent.Parent.Controls.Remove(this.Parent.Parent);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDelate_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            btch1 = tbl_branch.SearchKod(kod);
            btch1.StatusB = false;
            tbl_branch.UpdateRow(btch1);
            tbl_branch = new BranchDB();
            //מילוי הגריד
            dataGridView1.DataSource = tbl_branch.GetList().Where(x => x.StatusB == true).ToList();
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
