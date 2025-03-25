namespace postProject.Gui
{
    partial class UcBAdd
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
            this.citycomboBox = new System.Windows.Forms.ComboBox();
            this.kodlabel = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.branchlabel = new System.Windows.Forms.Label();
            this.streettextBox = new System.Windows.Forms.TextBox();
            this.streetlabel = new System.Windows.Forms.Label();
            this.bildingtextBox = new System.Windows.Forms.TextBox();
            this.bildinglabel = new System.Windows.Forms.Label();
            this.citylabel = new System.Windows.Forms.Label();
            this.branchtextBox = new System.Windows.Forms.TextBox();
            this.kodtextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.clientpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientpanel
            // 
            this.clientpanel.Controls.Add(this.citycomboBox);
            this.clientpanel.Controls.Add(this.kodlabel);
            this.clientpanel.Controls.Add(this.addbutton);
            this.clientpanel.Controls.Add(this.branchlabel);
            this.clientpanel.Controls.Add(this.streettextBox);
            this.clientpanel.Controls.Add(this.streetlabel);
            this.clientpanel.Controls.Add(this.bildingtextBox);
            this.clientpanel.Controls.Add(this.bildinglabel);
            this.clientpanel.Controls.Add(this.citylabel);
            this.clientpanel.Controls.Add(this.branchtextBox);
            this.clientpanel.Controls.Add(this.kodtextBox);
            this.clientpanel.Location = new System.Drawing.Point(163, 28);
            this.clientpanel.Name = "clientpanel";
            this.clientpanel.Size = new System.Drawing.Size(266, 323);
            this.clientpanel.TabIndex = 15;
            this.clientpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.clientpanel_Paint);
            // 
            // citycomboBox
            // 
            this.citycomboBox.FormattingEnabled = true;
            this.citycomboBox.Location = new System.Drawing.Point(53, 202);
            this.citycomboBox.Name = "citycomboBox";
            this.citycomboBox.Size = new System.Drawing.Size(111, 21);
            this.citycomboBox.TabIndex = 14;
            this.citycomboBox.SelectedIndexChanged += new System.EventHandler(this.citycomboBox_SelectedIndexChanged);
            // 
            // kodlabel
            // 
            this.kodlabel.AutoSize = true;
            this.kodlabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodlabel.ForeColor = System.Drawing.Color.Red;
            this.kodlabel.Location = new System.Drawing.Point(190, 69);
            this.kodlabel.Name = "kodlabel";
            this.kodlabel.Size = new System.Drawing.Size(26, 20);
            this.kodlabel.TabIndex = 0;
            this.kodlabel.Text = "קוד";
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.White;
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbutton.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.Red;
            this.addbutton.Location = new System.Drawing.Point(53, 265);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(68, 25);
            this.addbutton.TabIndex = 11;
            this.addbutton.Text = "אישור";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click_1);
            // 
            // branchlabel
            // 
            this.branchlabel.AutoSize = true;
            this.branchlabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchlabel.ForeColor = System.Drawing.Color.Red;
            this.branchlabel.Location = new System.Drawing.Point(190, 106);
            this.branchlabel.Name = "branchlabel";
            this.branchlabel.Size = new System.Drawing.Size(52, 20);
            this.branchlabel.TabIndex = 1;
            this.branchlabel.Text = "שם סניף";
            // 
            // streettextBox
            // 
            this.streettextBox.BackColor = System.Drawing.Color.White;
            this.streettextBox.Location = new System.Drawing.Point(53, 136);
            this.streettextBox.Name = "streettextBox";
            this.streettextBox.Size = new System.Drawing.Size(111, 20);
            this.streettextBox.TabIndex = 10;
            // 
            // streetlabel
            // 
            this.streetlabel.AutoSize = true;
            this.streetlabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetlabel.ForeColor = System.Drawing.Color.Red;
            this.streetlabel.Location = new System.Drawing.Point(190, 141);
            this.streetlabel.Name = "streetlabel";
            this.streetlabel.Size = new System.Drawing.Size(34, 20);
            this.streetlabel.TabIndex = 2;
            this.streetlabel.Text = "רחוב";
            // 
            // bildingtextBox
            // 
            this.bildingtextBox.BackColor = System.Drawing.Color.White;
            this.bildingtextBox.Location = new System.Drawing.Point(53, 170);
            this.bildingtextBox.Name = "bildingtextBox";
            this.bildingtextBox.Size = new System.Drawing.Size(111, 20);
            this.bildingtextBox.TabIndex = 9;
            // 
            // bildinglabel
            // 
            this.bildinglabel.AutoSize = true;
            this.bildinglabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bildinglabel.ForeColor = System.Drawing.Color.Red;
            this.bildinglabel.Location = new System.Drawing.Point(190, 174);
            this.bildinglabel.Name = "bildinglabel";
            this.bildinglabel.Size = new System.Drawing.Size(46, 20);
            this.bildinglabel.TabIndex = 3;
            this.bildinglabel.Text = "מס בנין";
            // 
            // citylabel
            // 
            this.citylabel.AutoSize = true;
            this.citylabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citylabel.ForeColor = System.Drawing.Color.Red;
            this.citylabel.Location = new System.Drawing.Point(190, 209);
            this.citylabel.Name = "citylabel";
            this.citylabel.Size = new System.Drawing.Size(26, 20);
            this.citylabel.TabIndex = 4;
            this.citylabel.Text = "עיר";
            // 
            // branchtextBox
            // 
            this.branchtextBox.BackColor = System.Drawing.Color.White;
            this.branchtextBox.Location = new System.Drawing.Point(53, 101);
            this.branchtextBox.Name = "branchtextBox";
            this.branchtextBox.Size = new System.Drawing.Size(111, 20);
            this.branchtextBox.TabIndex = 7;
            // 
            // kodtextBox
            // 
            this.kodtextBox.BackColor = System.Drawing.Color.White;
            this.kodtextBox.Location = new System.Drawing.Point(53, 66);
            this.kodtextBox.Name = "kodtextBox";
            this.kodtextBox.ReadOnly = true;
            this.kodtextBox.Size = new System.Drawing.Size(111, 20);
            this.kodtextBox.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UcBAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.clientpanel);
            this.Name = "UcBAdd";
            this.Size = new System.Drawing.Size(582, 354);
            this.clientpanel.ResumeLayout(false);
            this.clientpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel clientpanel;
        private System.Windows.Forms.Label kodlabel;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label branchlabel;
        private System.Windows.Forms.TextBox streettextBox;
        private System.Windows.Forms.Label streetlabel;
        private System.Windows.Forms.TextBox bildingtextBox;
        private System.Windows.Forms.Label bildinglabel;
        private System.Windows.Forms.Label citylabel;
        private System.Windows.Forms.TextBox branchtextBox;
        private System.Windows.Forms.TextBox kodtextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox citycomboBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
