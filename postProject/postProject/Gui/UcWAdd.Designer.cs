namespace postProject.Gui
{
    partial class UcWAdd
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clientpanel = new System.Windows.Forms.Panel();
            this.kodcomboBox = new System.Windows.Forms.ComboBox();
            this.daycomboBox = new System.Windows.Forms.ComboBox();
            this.idlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.firstNamelabel = new System.Windows.Forms.Label();
            this.closeTimetextBox = new System.Windows.Forms.TextBox();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.startTimetextBox = new System.Windows.Forms.TextBox();
            this.phonelabel = new System.Windows.Forms.Label();
            this.tellabel = new System.Windows.Forms.Label();
            this.shiftNumtextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.clientpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // clientpanel
            // 
            this.clientpanel.Controls.Add(this.kodcomboBox);
            this.clientpanel.Controls.Add(this.daycomboBox);
            this.clientpanel.Controls.Add(this.idlabel);
            this.clientpanel.Controls.Add(this.button1);
            this.clientpanel.Controls.Add(this.firstNamelabel);
            this.clientpanel.Controls.Add(this.closeTimetextBox);
            this.clientpanel.Controls.Add(this.lastNamelabel);
            this.clientpanel.Controls.Add(this.startTimetextBox);
            this.clientpanel.Controls.Add(this.phonelabel);
            this.clientpanel.Controls.Add(this.tellabel);
            this.clientpanel.Controls.Add(this.shiftNumtextBox);
            this.clientpanel.Location = new System.Drawing.Point(141, 33);
            this.clientpanel.Name = "clientpanel";
            this.clientpanel.Size = new System.Drawing.Size(289, 318);
            this.clientpanel.TabIndex = 17;
            // 
            // kodcomboBox
            // 
            this.kodcomboBox.FormattingEnabled = true;
            this.kodcomboBox.Location = new System.Drawing.Point(23, 37);
            this.kodcomboBox.Name = "kodcomboBox";
            this.kodcomboBox.Size = new System.Drawing.Size(108, 21);
            this.kodcomboBox.TabIndex = 13;
            // 
            // daycomboBox
            // 
            this.daycomboBox.FormattingEnabled = true;
            this.daycomboBox.Items.AddRange(new object[] {
            "ראשון",
            "שני",
            "שלישי",
            "רביעי",
            "חמישי",
            "שישי"});
            this.daycomboBox.Location = new System.Drawing.Point(22, 122);
            this.daycomboBox.Name = "daycomboBox";
            this.daycomboBox.Size = new System.Drawing.Size(109, 21);
            this.daycomboBox.TabIndex = 12;
            this.daycomboBox.SelectedIndexChanged += new System.EventHandler(this.daycomboBox_SelectedIndexChanged);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.ForeColor = System.Drawing.Color.Red;
            this.idlabel.Location = new System.Drawing.Point(190, 39);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(52, 20);
            this.idlabel.TabIndex = 0;
            this.idlabel.Text = "קוד סניף";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(92, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "אישור";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstNamelabel
            // 
            this.firstNamelabel.AutoSize = true;
            this.firstNamelabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNamelabel.ForeColor = System.Drawing.Color.Red;
            this.firstNamelabel.Location = new System.Drawing.Point(190, 84);
            this.firstNamelabel.Name = "firstNamelabel";
            this.firstNamelabel.Size = new System.Drawing.Size(84, 20);
            this.firstNamelabel.TabIndex = 1;
            this.firstNamelabel.Text = "מספר משמרת";
            // 
            // closeTimetextBox
            // 
            this.closeTimetextBox.BackColor = System.Drawing.Color.White;
            this.closeTimetextBox.Location = new System.Drawing.Point(23, 206);
            this.closeTimetextBox.Name = "closeTimetextBox";
            this.closeTimetextBox.Size = new System.Drawing.Size(108, 20);
            this.closeTimetextBox.TabIndex = 10;
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.AutoSize = true;
            this.lastNamelabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNamelabel.ForeColor = System.Drawing.Color.Red;
            this.lastNamelabel.Location = new System.Drawing.Point(190, 127);
            this.lastNamelabel.Name = "lastNamelabel";
            this.lastNamelabel.Size = new System.Drawing.Size(23, 20);
            this.lastNamelabel.TabIndex = 2;
            this.lastNamelabel.Text = "יום";
            // 
            // startTimetextBox
            // 
            this.startTimetextBox.BackColor = System.Drawing.Color.White;
            this.startTimetextBox.Location = new System.Drawing.Point(23, 165);
            this.startTimetextBox.Name = "startTimetextBox";
            this.startTimetextBox.Size = new System.Drawing.Size(108, 20);
            this.startTimetextBox.TabIndex = 9;
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelabel.ForeColor = System.Drawing.Color.Red;
            this.phonelabel.Location = new System.Drawing.Point(190, 168);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(73, 20);
            this.phonelabel.TabIndex = 3;
            this.phonelabel.Text = "שעת פתיחה";
            // 
            // tellabel
            // 
            this.tellabel.AutoSize = true;
            this.tellabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tellabel.ForeColor = System.Drawing.Color.Red;
            this.tellabel.Location = new System.Drawing.Point(190, 207);
            this.tellabel.Name = "tellabel";
            this.tellabel.Size = new System.Drawing.Size(68, 20);
            this.tellabel.TabIndex = 4;
            this.tellabel.Text = "שעת סגירה";
            // 
            // shiftNumtextBox
            // 
            this.shiftNumtextBox.BackColor = System.Drawing.Color.White;
            this.shiftNumtextBox.Location = new System.Drawing.Point(23, 80);
            this.shiftNumtextBox.Name = "shiftNumtextBox";
            this.shiftNumtextBox.Size = new System.Drawing.Size(108, 20);
            this.shiftNumtextBox.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // UcWAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.clientpanel);
            this.Name = "UcWAdd";
            this.Size = new System.Drawing.Size(582, 354);
            this.clientpanel.ResumeLayout(false);
            this.clientpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel clientpanel;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label firstNamelabel;
        private System.Windows.Forms.TextBox closeTimetextBox;
        private System.Windows.Forms.Label lastNamelabel;
        private System.Windows.Forms.TextBox startTimetextBox;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Label tellabel;
        private System.Windows.Forms.TextBox shiftNumtextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ComboBox daycomboBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox kodcomboBox;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}
