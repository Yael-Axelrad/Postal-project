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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace postProject.Gui
{
    public partial class UcWAdd : UserControl
    {
        bool flagUpdate;
        WorkTimeDB wdb = new WorkTimeDB();
        WorkTime w;
        BranchDB bdb;
        public UcWAdd()
        {
           InitializeComponent();
            wdb = new WorkTimeDB();
            w = new WorkTime();
            bdb = new BranchDB();
            kodcomboBox.DataSource = bdb.GetList();
            kodcomboBox.SelectedIndex = -1;

        }

        public UcWAdd(int kod) : this()
        {
            w = wdb.SearchKod(kod);
            FillTxt();
            flagUpdate = true;
        }
        private bool CreateWorkTime()
        {
            errorProvider1.Clear();
            bool flag = true;
            try
            {
                if (closeTimetextBox.Text == "")//שעת סגירה
                    throw new Exception("שדה חובה");
                w.ClosseT = Convert.ToDateTime(closeTimetextBox.Text);

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(closeTimetextBox, ex.Message);
                flag = false;
            }
            try//מספר משמרת
            {
                if (shiftNumtextBox.Text == "")
                    throw new Exception("שדה חובה");
                if(!Validation.IsNum(shiftNumtextBox.Text))
                    throw new Exception("הכנס ספרות בלבד");
                w.NumShiftT = Convert.ToInt32(shiftNumtextBox.Text);

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(shiftNumtextBox, ex.Message);
                flag = false;
            }
            try//קוד סניף
            {
                if (kodcomboBox.SelectedIndex == -1)
                    throw new Exception("שדה חובה");
                w.BranchkodT = ((Branch)kodcomboBox.SelectedItem).KodB;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(kodcomboBox, ex.Message);
                flag = false;
            }
            try//יום
            {
                if (daycomboBox.SelectedIndex == -1)
                    throw new Exception("שדה חובה");
                w.DayT = daycomboBox.SelectedItem.ToString();

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(daycomboBox, ex.Message);
                flag = false;
            }
            try//שעת פתיחה
            {
                if (startTimetextBox.Text == "")
                    throw new Exception("שדה חובה");
                w.OpenT = Convert.ToDateTime(startTimetextBox.Text);

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(startTimetextBox, ex.Message);
                flag = false;
            }

            return flag;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CreateWorkTime())
            {
                if (!flagUpdate)
                {
                    wdb.AddNew(w);
                    kodcomboBox.Text = "";
                    shiftNumtextBox.Text = "";
                    daycomboBox.Text = "";
                    startTimetextBox.Text = "";
                    closeTimetextBox.Text = "";
                }
                else
                { 
                    wdb.UpdateRow(w);
                    kodcomboBox.Text = "";
                    shiftNumtextBox.Text = "";
                    daycomboBox.Text = "";
                    startTimetextBox.Text = "";
                    closeTimetextBox.Text = "";
                }
            }    
        }

        public void FillTxt()
        {
            kodcomboBox.Text = w.BranchkodT.ToString();
            shiftNumtextBox.Text = w.NumShiftT.ToString();
            daycomboBox.Text = w.DayT;
            startTimetextBox.Text = w.OpenT.ToString();
            closeTimetextBox.Text = w.ClosseT.ToString();
        }

        private void daycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
