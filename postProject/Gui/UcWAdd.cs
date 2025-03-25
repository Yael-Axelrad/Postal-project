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
        cityDB ctdb;
        City cty;
        public UcWAdd()
        {
           InitializeComponent();
            ctdb = new cityDB();
            bdb = new BranchDB();
            wdb = new WorkTimeDB();
            w = new WorkTime();
            bdb = new BranchDB();
           
            citycomboBox.DataSource = ctdb.GetList();//מילוי הקומבו של העיר
            citycomboBox.DataSource = ctdb.GetList().OrderBy(x => x.NameCity).ToList();
            citycomboBox.SelectedIndex = -1;
        }

        public UcWAdd(string kod1, int kod2 ,String kod3) : this()
        {
            w = wdb.SearchKod(kod1,kod2,kod3);
            flagUpdate = true;
            citycomboBox.Enabled = false;
            kodcomboBox.Enabled = false;
            daycomboBox.Enabled = false;
            FillTxt();
            
        }
        private bool CreateWorkTime()
        {
            textBox1.Visible = false;
            errorProvider1.Clear();
            bool flag = true;
            try// סניף
            {
                if (citycomboBox.SelectedIndex == -1)
                {
                    if (citycomboBox.Text == "")
                    {
                        throw new Exception("שדה חובה");
                    }
                    throw new Exception("עיר אינה חוקי");
                }

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(citycomboBox, ex.Message);
                flag = false;
            }
            try
            {
                if (maskedTextBoxC.Text == ""||maskedTextBoxO.Text == "")//שעת סגירה
                    throw new Exception("שדה חובה");
                w.ClosseT = Convert.ToDateTime(maskedTextBoxC.Text);
                w.OpenT = Convert.ToDateTime(maskedTextBoxO.Text);
                if(w.OpenT.Hour > w.ClosseT.Hour)
                {
                    textBox1.Text = "שעת פתיחה מוקדמת יותר משעת סגירה החלף את השעות!";
                    textBox1.Visible= true;
                    flag = false;
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(maskedTextBoxC, "שעה אינה חוקית");
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
            try// סניף
            {
                if (kodcomboBox.SelectedIndex == -1)
                {
                    if (kodcomboBox.Text == "")
                    {
                        throw new Exception("שדה חובה");
                    }
                    throw new Exception("סניף אינו חוקי");
                }
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
                {
                    if (daycomboBox.Text == "")
                    {
                        throw new Exception("שדה חובה");
                    }
                    throw new Exception("יום אינו חוקי");
                }
                w.DayT = daycomboBox.SelectedItem.ToString();

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(daycomboBox, ex.Message);
                flag = false;
            }
            try//שעת פתיחה
            {
                if (maskedTextBoxO.Text == "")
                    throw new Exception("שדה חובה");
                w.OpenT = Convert.ToDateTime(maskedTextBoxO.Text);

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(maskedTextBoxO, "שעה אינה חוקית");
                flag = false;
            }
            w.Status = true;
            return flag;
        }
        private bool CheckHours()
        {
            textBox1.Visible = false;
            textBox1.Text = "יש שעות פעילות בזמן זה!";
            foreach (WorkTime item in wdb.GetList().Where(x => x.BranchkodT == w.BranchkodT && x.DayT == w.DayT))
            {
                //שעת פתיחה גדולה משת פתיחה ושעת סגירה גדולה משעת סגירה
                if ((w.OpenT > item.OpenT && w.OpenT < item.ClosseT))
                { 
                    textBox1.Visible = true;
                    return false;
                }
                //שעת פתיחה גדולה משעת פתיחה ושעת סגירה קטנה משעת סגירה   
                if (w.OpenT > item.OpenT && w.ClosseT < item.ClosseT)
                { 
                    textBox1.Visible = true;
                    return false;
                }
                //שעת פתיחה קטנה משעת פתיחה ושעת סגירה בין שעת פתיחה לשעת סגירה
                if (w.OpenT < item.OpenT && (w.ClosseT > item.OpenT&& w.ClosseT < item.ClosseT))
                {
                    textBox1.Visible = true;
                    return false;
                }
                //שעת פתיחה קטנה משעת פתיחה ושעת סגירה גדולה משעת סגירה
                if(w.OpenT < item.OpenT && w.ClosseT > item.ClosseT)
                {
                    textBox1.Visible = true;
                    return false;
                }
                   
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CreateWorkTime() && CheckHours())
            {
                if (!flagUpdate)
                {
                    wdb.AddNew(w);
                    kodcomboBox.Text = "";
                    shiftNumtextBox.Text = "";
                    daycomboBox.Text = "";
                    maskedTextBoxO.Text = "";
                    maskedTextBoxC.Text = "";
                }
                else
                { 
                    wdb.UpdateRow(w);
                }
                //הצהרת מופע ליוזר שאותו רוצים להוסיף
                UcWorkTime ucW = new UcWorkTime();
                Parent.Controls.Add(ucW);
                ucW.Dock = DockStyle.Fill;
                Parent.Controls.Remove(this);
            }    
        }

        public void FillTxt()
        {
            citycomboBox.Text = bdb.SearchKod(w.BranchkodT).CityOfBranch().NameCity;
            kodcomboBox.Text = bdb.SearchKod(w.BranchkodT).ToString();
            daycomboBox.Text = w.DayT;
            maskedTextBoxC.Text = w.ClosseT.ToShortTimeString();
            if (w.OpenT.Minute<10)
            {
                maskedTextBoxO.Text = w.OpenT.Hour + ":" +"0"+ w.OpenT.Minute;
            }
            else
            {
                maskedTextBoxO.Text = w.OpenT.Hour + ":" + w.OpenT.Minute;
            }
            shiftNumtextBox.Text = w.NumShiftT.ToString();
            //  if (w.ClosseT.Minute<10)
            //   {
            //      maskedTextBoxC.Text = w.ClosseT.Hour + ":" +"0"+ w.ClosseT.Minute;
            //  }
            //  else 
            //  {
            //      maskedTextBoxC.Text = w.ClosseT.Hour + ":" + w.ClosseT.Minute;
            //  }
        }

        private void daycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (daycomboBox.SelectedIndex != -1)
            {
                shiftNumtextBox.Text = "";
                if (!flagUpdate)
                {
                    Branch b = new Branch();
                    b = kodcomboBox.SelectedItem as Branch;
                    string d = daycomboBox.Text;
                    shiftNumtextBox.Text = wdb.GetNextKeyW(b, d).ToString();
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UCmainEnter ucME = new UCmainEnter();
            Parent.Parent.Parent.Controls.Add(ucME);
            ucME.Dock = DockStyle.Fill;
            Parent.Parent.Parent.Controls.Remove(this.Parent.Parent);
        }

        private void citycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            shiftNumtextBox.Text = "";
            cty = (City)citycomboBox.SelectedItem;
            kodcomboBox.SelectedIndex = -1;
            kodcomboBox.DataSource = bdb.GetList().Where(x => x.CityOfBranch().NameCity == citycomboBox.Text).ToList().OrderBy(x => x.NameB).ToList();
            kodcomboBox.SelectedIndex = -1;
        }

        private void kodcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            shiftNumtextBox.Text = "";
            daycomboBox.SelectedIndex = -1;
            daycomboBox.Items.Clear();
            if (kodcomboBox.SelectedIndex != -1)
            {
                daycomboBox.Items.Clear();
                daycomboBox.Items.AddRange(new string[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "שישי" });
            }     
            daycomboBox.Text = "";
           
        }

        private void shiftNumtextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void clientpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
