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
            this.label9 = new System.Windows.Forms.Label();
            this.citycomboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBoxC = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxO = new System.Windows.Forms.MaskedTextBox();
            this.kodcomboBox = new System.Windows.Forms.ComboBox();
            this.daycomboBox = new System.Windows.Forms.ComboBox();
            this.idlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.firstNamelabel = new System.Windows.Forms.Label();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.phonelabel = new System.Windows.Forms.Label();
            this.tellabel = new System.Windows.Forms.Label();
            this.shiftNumtextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.clientpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // clientpanel
            // 
            this.clientpanel.Controls.Add(this.label9);
            this.clientpanel.Controls.Add(this.citycomboBox);
            this.clientpanel.Controls.Add(this.textBox1);
            this.clientpanel.Controls.Add(this.maskedTextBoxC);
            this.clientpanel.Controls.Add(this.maskedTextBoxO);
            this.clientpanel.Controls.Add(this.kodcomboBox);
            this.clientpanel.Controls.Add(this.daycomboBox);
            this.clientpanel.Controls.Add(this.idlabel);
            this.clientpanel.Controls.Add(this.button1);
            this.clientpanel.Controls.Add(this.firstNamelabel);
            this.clientpanel.Controls.Add(this.lastNamelabel);
            this.clientpanel.Controls.Add(this.phonelabel);
            this.clientpanel.Controls.Add(this.tellabel);
            this.clientpanel.Controls.Add(this.shiftNumtextBox);
            this.clientpanel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientpanel.Location = new System.Drawing.Point(264, 51);
            this.clientpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clientpanel.Name = "clientpanel";
            this.clientpanel.Size = new System.Drawing.Size(562, 489);
            this.clientpanel.TabIndex = 17;
            this.clientpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.clientpanel_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(406, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(38, 30);
            this.label9.TabIndex = 44;
            this.label9.Text = "עיר";
            // 
            // citycomboBox
            // 
            this.citycomboBox.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citycomboBox.FormattingEnabled = true;
            this.citycomboBox.Location = new System.Drawing.Point(156, 52);
            this.citycomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.citycomboBox.Name = "citycomboBox";
            this.citycomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.citycomboBox.Size = new System.Drawing.Size(240, 38);
            this.citycomboBox.TabIndex = 43;
            this.citycomboBox.SelectedIndexChanged += new System.EventHandler(this.citycomboBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(38, 372);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(468, 31);
            this.textBox1.TabIndex = 40;
            this.textBox1.Visible = false;
            // 
            // maskedTextBoxC
            // 
            this.maskedTextBoxC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxC.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxC.Location = new System.Drawing.Point(154, 331);
            this.maskedTextBoxC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBoxC.Mask = "00:00";
            this.maskedTextBoxC.Name = "maskedTextBoxC";
            this.maskedTextBoxC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maskedTextBoxC.Size = new System.Drawing.Size(243, 31);
            this.maskedTextBoxC.TabIndex = 41;
            this.maskedTextBoxC.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxO
            // 
            this.maskedTextBoxO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxO.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxO.Location = new System.Drawing.Point(153, 268);
            this.maskedTextBoxO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maskedTextBoxO.Mask = "00:00";
            this.maskedTextBoxO.Name = "maskedTextBoxO";
            this.maskedTextBoxO.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maskedTextBoxO.Size = new System.Drawing.Size(243, 31);
            this.maskedTextBoxO.TabIndex = 40;
            this.maskedTextBoxO.ValidatingType = typeof(System.DateTime);
            // 
            // kodcomboBox
            // 
            this.kodcomboBox.BackColor = System.Drawing.Color.White;
            this.kodcomboBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.kodcomboBox.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.kodcomboBox, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.kodcomboBox.Location = new System.Drawing.Point(156, 103);
            this.kodcomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kodcomboBox.Name = "kodcomboBox";
            this.kodcomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kodcomboBox.Size = new System.Drawing.Size(240, 38);
            this.kodcomboBox.TabIndex = 13;
            this.kodcomboBox.SelectedIndexChanged += new System.EventHandler(this.kodcomboBox_SelectedIndexChanged);
            // 
            // daycomboBox
            // 
            this.daycomboBox.FormattingEnabled = true;
            this.daycomboBox.Location = new System.Drawing.Point(154, 157);
            this.daycomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.daycomboBox.Name = "daycomboBox";
            this.daycomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.daycomboBox.Size = new System.Drawing.Size(241, 38);
            this.daycomboBox.TabIndex = 12;
            this.daycomboBox.SelectedIndexChanged += new System.EventHandler(this.daycomboBox_SelectedIndexChanged);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.ForeColor = System.Drawing.Color.Red;
            this.idlabel.Location = new System.Drawing.Point(406, 109);
            this.idlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(46, 30);
            this.idlabel.TabIndex = 0;
            this.idlabel.Text = "סניף";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(156, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 37);
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
            this.firstNamelabel.Location = new System.Drawing.Point(406, 215);
            this.firstNamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNamelabel.Name = "firstNamelabel";
            this.firstNamelabel.Size = new System.Drawing.Size(118, 30);
            this.firstNamelabel.TabIndex = 1;
            this.firstNamelabel.Text = "מספר משמרת";
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.AutoSize = true;
            this.lastNamelabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNamelabel.ForeColor = System.Drawing.Color.Red;
            this.lastNamelabel.Location = new System.Drawing.Point(406, 163);
            this.lastNamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNamelabel.Name = "lastNamelabel";
            this.lastNamelabel.Size = new System.Drawing.Size(35, 30);
            this.lastNamelabel.TabIndex = 2;
            this.lastNamelabel.Text = "יום";
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelabel.ForeColor = System.Drawing.Color.Red;
            this.phonelabel.Location = new System.Drawing.Point(406, 265);
            this.phonelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(104, 30);
            this.phonelabel.TabIndex = 3;
            this.phonelabel.Text = "שעת פתיחה";
            // 
            // tellabel
            // 
            this.tellabel.AutoSize = true;
            this.tellabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tellabel.ForeColor = System.Drawing.Color.Red;
            this.tellabel.Location = new System.Drawing.Point(406, 325);
            this.tellabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tellabel.Name = "tellabel";
            this.tellabel.Size = new System.Drawing.Size(98, 30);
            this.tellabel.TabIndex = 4;
            this.tellabel.Text = "שעת סגירה";
            // 
            // shiftNumtextBox
            // 
            this.shiftNumtextBox.BackColor = System.Drawing.Color.White;
            this.shiftNumtextBox.Location = new System.Drawing.Point(156, 209);
            this.shiftNumtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shiftNumtextBox.Name = "shiftNumtextBox";
            this.shiftNumtextBox.ReadOnly = true;
            this.shiftNumtextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.shiftNumtextBox.Size = new System.Drawing.Size(240, 38);
            this.shiftNumtextBox.TabIndex = 7;
            this.shiftNumtextBox.TextChanged += new System.EventHandler(this.shiftNumtextBox_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::postProject.Properties.Resources.Israel_Post_svg;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9E-05F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(960, 5);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 118);
            this.button3.TabIndex = 39;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UcWAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clientpanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcWAdd";
            this.Size = new System.Drawing.Size(1200, 586);
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
        private System.Windows.Forms.Label lastNamelabel;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Label tellabel;
        private System.Windows.Forms.TextBox shiftNumtextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ComboBox daycomboBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox kodcomboBox;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxO;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox citycomboBox;
        private System.Windows.Forms.Label label9;
    }
}
