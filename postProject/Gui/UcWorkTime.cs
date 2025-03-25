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
    public partial class UcWorkTime : UserControl
    {
        WorkTimeDB tbl_workTime;
        WorkTime wrktm = new WorkTime();
        public UcWorkTime()//פעולה בונה להצגת טבלת שעות עבודה
        {
            InitializeComponent();
            tbl_workTime = new WorkTimeDB();
            //מילוי הגריד
            dataGridView1.DataSource = tbl_workTime.GetList().Where(x => x.Status == true).Select(x=> new {סניף= x.BreanchOfWorkTime().NameB,מספר_משמרת = x.NumShiftT,יום= x.DayT,שעת_פתיחה = x.OpenT.ToShortTimeString()/*.Hour + ":" + x.OpenT.Minute*/,שעת_סגירה= x.ClosseT.ToShortTimeString()}).OrderBy(x => x.סניף).ToList(); ;
            //מאפיינים של dataGridView
            //מאפיין המגדיר שיבחר כל פעם שורה שלמה
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //מימין לשמאל
            dataGridView1.RightToLeft = RightToLeft;
            //לקריאה בלבד
            dataGridView1.ReadOnly = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)//מעבר ליוזר של הוספת שעות פעילות
        {
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UcWAdd ucW = new UcWAdd();
            Parent.Controls.Add(ucW);
            ucW.Dock = DockStyle.Fill;
            Parent.Controls.Remove(this);
        }

        private void buttonChange_Click(object sender, EventArgs e)//מעבר ליוזר של עדכון שעות פעילות
        {
     
            string kod1 = (dataGridView1.SelectedRows[0].Cells[0].Value).ToString();
            int kod2 = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
            string kod3 = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UcWAdd ucW = new UcWAdd(kod1 , kod2 ,kod3);
            Parent.Controls.Add(ucW);
            ucW.Dock = DockStyle.Fill;
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

            string kod1 = (dataGridView1.SelectedRows[0].Cells[0].Value).ToString();
            int kod2 = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
            string kod3 = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
            wrktm = tbl_workTime.SearchKod(kod1,kod2,kod3);
            wrktm.Status = false;
            tbl_workTime.UpdateRow(wrktm);
            tbl_workTime = new WorkTimeDB();
            //מילוי הגריד
            dataGridView1.DataSource = tbl_workTime.GetList().Where(x => x.Status == true).Select(x => new { סניף = x.BreanchOfWorkTime().NameB, מספר_משמרת = x.NumShiftT, יום = x.DayT, שעת_פתיחה = x.OpenT.ToShortTimeString()/*.Hour + ":" + x.OpenT.Minute*/, שעת_סגירה = x.ClosseT.ToShortTimeString() }).ToList();
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
