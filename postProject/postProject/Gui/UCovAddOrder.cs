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
    public partial class UCovAddOrder : UserControl
    {
        cityDB cdb;
        BranchDB bdb;
        DeliversDB dbd;
        int check;
        public UCovAddOrder()
        {
            InitializeComponent();
            cdb = new cityDB();
            bdb =new BranchDB();
            dbd= new DeliversDB();
            citycomboBox.DataSource = cdb.GetList();
            citycomboBox.SelectedIndex = -1;
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
            check = 1;

        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
            check = 2;
        }
        ClientsDB cbd = new ClientsDB();
        private void textBoxTelS_TextChanged(object sender, EventArgs e)
        {
            string t = textBoxTelS.Text;
            if (label11.Visible==true)
            {
                label11.Visible = false;
            }
            if (!Validation.IsPelepon(t))
            {
                labelSend.Text = "מספר פלפון אינו חוקי";
                labelSend.Visible = true;
                buttonSend.Visible = false;
                panelAdd.Visible = false;
            }
            else
            {

           
            if (cbd.SearchKodClient(t) == null)
            {
                labelSend.Text = "השולח אינו קיים במאגר";
                labelSend.Visible = true;
                buttonSend.Visible = true;
            }
            else
            {
                labelSend.Visible = false;
                buttonSend.Visible = false;

            }
            }
            if (textBoxTelS.Text == "")
            {
                labelSend.Visible = false;
                buttonSend.Visible = false;
            }
        }

        private void textBoxTelG_TextChanged(object sender, EventArgs e)
        {
            string y = textBoxTelG.Text;
            if (!Validation.IsPelepon(y))
            {
                labelGet.Text = "מספר פלפון אינו חוקי";
                labelGet.Visible = true;
                buttonGet.Visible = false;
                panelAdd.Visible = false;
            }
            else
            {
            
            if (cbd.SearchKodClient(y) == null)
            {
                labelGet.Text = "השולח אינו קיים במאגר";
                labelGet.Visible = true;
                buttonGet.Visible = true;
            }
            else
            {
                labelGet.Visible = false;
                buttonGet.Visible = false;

            }
            }
            if (textBoxTelG.Text == "")
            {
                labelGet.Visible = false;
                buttonGet.Visible = false;
            }
        }
        Clients c = new Clients();
        cityDB cty = new cityDB();
        private bool CreateClient()
        {
            errorProvider1.Clear();
            bool flag = true;
            try//בדיקת מס פלאפון
            {
                if (textBoxTel.Text == "")
                    throw new Exception("שדה חובה");
                c.TelC = textBoxTel.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxTel, ex.Message);
                flag = false;
            }
            try//בדיקת שם פרטי
            {
                if (textBox2.Text == "")
                    throw new Exception("שדה חובה");
                c.FirstNameC = textBox2.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox2, ex.Message);
                flag = false;
            }
            try//בדיקת שם משפחה
            {
                if (textBox3.Text == "")
                    throw new Exception("שדה חובה");
                c.LastNameC = textBox3.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox3, ex.Message);
                flag = false;
            }
            try//בדיקת עיר
            {
                if (citycomboBox.SelectedIndex == -1)
                    throw new Exception("שדה חובה");
                c.CityC = ((City)citycomboBox.SelectedItem).KodCity;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(citycomboBox, ex.Message);
                flag = false;
            }
            try//בדיקת סניף
            {
                if (comboBoxBreanch.SelectedIndex == -1)
                    throw new Exception("שדה חובה");
                c.BranchC = ((Branch)comboBoxBreanch.SelectedItem).KodB;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(comboBoxBreanch, ex.Message);
                flag = false;
            }
            return flag;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (CreateClient())
            {
                cbd.AddNew(c);
                panelAdd.Visible=false;
                if (check==1)
                {
                    buttonSend.Visible = false;
                    labelSend.Visible = false;
                    label4.Visible = true;
                    label4.Text = "הלקוח נוסף בהצלחה";
                }
                if (check==2)
                {
                    buttonGet.Visible = false;
                    labelGet.Visible = false;
                    label5.Visible = true;
                    label5.Text = "הלקוח נוסף בהצלחה";
                }
                textBoxTel.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                citycomboBox.Text = "";
                comboBoxBreanch.Text = "";
            }
        }
        Delivers d;
        DeliversDB ddb;
        private bool CreateOrder()
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            ddb = new DeliversDB();
            d = new Delivers();
            bool flag = true;
            try// בדיקת טלפון שולח
            {
                if(textBoxTelS.Text == "")
                    throw new Exception("שדה חובה");
                if (labelSend.Visible)
                    throw new Exception("מספר פלפון אינו חוקי");
                d.NameSendD = textBoxTelS.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxTelS, ex.Message);
                flag = false;
            }
           
            try//בדיקת טלפון נמען
            {
                if (textBoxTelG.Text == "")
                    throw new Exception("שדה חובה");
                if (labelGet.Visible)
                    throw new Exception("מספר פלפון אינו חוקי");
                d.NameGetD = textBoxTelG.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxTelG, ex.Message);
                flag = false;
            }
            try//בדיקת שתי הטלפונים שאינם זהים
            {
                if (textBoxTelS.Text == textBoxTelG.Text && textBoxTelG.Text!="")
                    throw new Exception("מספר פלאפון של שולח ונמען זהה!");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxTelS, ex.Message);
                errorProvider2.SetError(textBoxTelG, ex.Message);
                flag = false;
            }
            try//בדיקת מספר משלוח
            {
                if (textBoxNumO.Text == "")
                    throw new Exception("שדה חובה");
                if (dbd.SearchKod(textBoxNumO.Text) != null)
                    throw new Exception("קוד משלוח קיים במאגר! ");
                if(!Validation.IsNum(textBoxNumO.Text))
                    throw new Exception("ספרות בלבד! ");
                d.NumD = textBoxNumO.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBoxNumO, ex.Message);
                flag = false;
            }
            d.StatusD = "התקבל מידע על המשלוח";
            return flag;
        }

            private void button2_Click(object sender, EventArgs e)
        {
            if (CreateOrder())
            {
                ddb.AddNew(d);
                textBoxTelS.Text = "";
                textBoxTelG.Text = "";
                textBoxNumO.Text = "";
                label4.Visible = false;
                label5.Visible = false;
                label11.Visible = true;

            }
        }

        private void citycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxBreanch.DataSource = bdb.GetList().Where(x => x.CityOfBranch().NameCity == citycomboBox.Text).ToList();
            comboBoxBreanch.SelectedIndex = -1;
        }

        private void textBoxNumO_TextChanged(object sender, EventArgs e)
        {
            string t = textBoxNumO.Text;
            if (dbd.SearchKod(t) != null)
            {
                label12.Visible = true;
            }
            if (dbd.SearchKod(t) == null)
            {
                label12.Visible = false;
            }
            if (textBoxNumO.Text == "")
            {
                labelGet.Visible = false;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //הצהרת מופע ליוזר שאותו רוצים להוסיף
            UCmainEnter ucME = new UCmainEnter();

            //modifier=public יש להגדיר את הפאנל בטופס המכיל שאליו רוצים לגשת כ 
            //לגשת לפאנל שבטופס המכיל//
            //הוספת היוזר החדש
            (this.ParentForm as FormEnter).panelMain.Controls.Add(ucME);
            //הסרת היוזר הנוכחי מהפאנל שבטופס המכיל
            (this.ParentForm as FormEnter).panelMain.Controls.Remove(this);

            ucME.Dock = DockStyle.Fill;
        }

        private void UCovAddOrder_Load(object sender, EventArgs e)
        {

        }
    }
}

