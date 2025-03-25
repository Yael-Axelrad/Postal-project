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
            this.label1 = new System.Windows.Forms.Label();
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
            this.button3 = new System.Windows.Forms.Button();
            this.clientpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientpanel
            // 
            this.clientpanel.Controls.Add(this.label1);
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
            this.clientpanel.Location = new System.Drawing.Point(422, 49);
            this.clientpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clientpanel.Name = "clientpanel";
            this.clientpanel.Size = new System.Drawing.Size(399, 497);
            this.clientpanel.TabIndex = 15;
            this.clientpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.clientpanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(89, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "קיים סניף בשם זה בעיר זאת";
            this.label1.Visible = false;
            // 
            // citycomboBox
            // 
            this.citycomboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.citycomboBox.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citycomboBox.FormattingEnabled = true;
            this.citycomboBox.Location = new System.Drawing.Point(80, 311);
            this.citycomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.citycomboBox.Name = "citycomboBox";
            this.citycomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.citycomboBox.Size = new System.Drawing.Size(197, 37);
            this.citycomboBox.TabIndex = 14;
            this.citycomboBox.SelectedIndexChanged += new System.EventHandler(this.citycomboBox_SelectedIndexChanged);
            // 
            // kodlabel
            // 
            this.kodlabel.AutoSize = true;
            this.kodlabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodlabel.ForeColor = System.Drawing.Color.Red;
            this.kodlabel.Location = new System.Drawing.Point(285, 106);
            this.kodlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kodlabel.Name = "kodlabel";
            this.kodlabel.Size = new System.Drawing.Size(37, 30);
            this.kodlabel.TabIndex = 0;
            this.kodlabel.Text = "קוד";
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.White;
            this.addbutton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.addbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbutton.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.Red;
            this.addbutton.Location = new System.Drawing.Point(80, 394);
            this.addbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(242, 38);
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
            this.branchlabel.Location = new System.Drawing.Point(285, 163);
            this.branchlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.branchlabel.Name = "branchlabel";
            this.branchlabel.Size = new System.Drawing.Size(76, 30);
            this.branchlabel.TabIndex = 1;
            this.branchlabel.Text = "שם סניף";
            // 
            // streettextBox
            // 
            this.streettextBox.BackColor = System.Drawing.Color.White;
            this.streettextBox.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streettextBox.Location = new System.Drawing.Point(80, 209);
            this.streettextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.streettextBox.Name = "streettextBox";
            this.streettextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.streettextBox.Size = new System.Drawing.Size(197, 37);
            this.streettextBox.TabIndex = 10;
            // 
            // streetlabel
            // 
            this.streetlabel.AutoSize = true;
            this.streetlabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetlabel.ForeColor = System.Drawing.Color.Red;
            this.streetlabel.Location = new System.Drawing.Point(285, 217);
            this.streetlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.streetlabel.Name = "streetlabel";
            this.streetlabel.Size = new System.Drawing.Size(49, 30);
            this.streetlabel.TabIndex = 2;
            this.streetlabel.Text = "רחוב";
            // 
            // bildingtextBox
            // 
            this.bildingtextBox.BackColor = System.Drawing.Color.White;
            this.bildingtextBox.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bildingtextBox.Location = new System.Drawing.Point(80, 262);
            this.bildingtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bildingtextBox.Name = "bildingtextBox";
            this.bildingtextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bildingtextBox.Size = new System.Drawing.Size(197, 37);
            this.bildingtextBox.TabIndex = 9;
            // 
            // bildinglabel
            // 
            this.bildinglabel.AutoSize = true;
            this.bildinglabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bildinglabel.ForeColor = System.Drawing.Color.Red;
            this.bildinglabel.Location = new System.Drawing.Point(285, 268);
            this.bildinglabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bildinglabel.Name = "bildinglabel";
            this.bildinglabel.Size = new System.Drawing.Size(67, 30);
            this.bildinglabel.TabIndex = 3;
            this.bildinglabel.Text = "מס בנין";
            // 
            // citylabel
            // 
            this.citylabel.AutoSize = true;
            this.citylabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citylabel.ForeColor = System.Drawing.Color.Red;
            this.citylabel.Location = new System.Drawing.Point(285, 322);
            this.citylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.citylabel.Name = "citylabel";
            this.citylabel.Size = new System.Drawing.Size(38, 30);
            this.citylabel.TabIndex = 4;
            this.citylabel.Text = "עיר";
            // 
            // branchtextBox
            // 
            this.branchtextBox.BackColor = System.Drawing.Color.White;
            this.branchtextBox.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchtextBox.Location = new System.Drawing.Point(80, 155);
            this.branchtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.branchtextBox.Name = "branchtextBox";
            this.branchtextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.branchtextBox.Size = new System.Drawing.Size(197, 37);
            this.branchtextBox.TabIndex = 7;
            // 
            // kodtextBox
            // 
            this.kodtextBox.BackColor = System.Drawing.Color.White;
            this.kodtextBox.Font = new System.Drawing.Font("Myanmar Text", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodtextBox.Location = new System.Drawing.Point(80, 102);
            this.kodtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kodtextBox.Name = "kodtextBox";
            this.kodtextBox.ReadOnly = true;
            this.kodtextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kodtextBox.Size = new System.Drawing.Size(197, 37);
            this.kodtextBox.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // UcBAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clientpanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcBAdd";
            this.Size = new System.Drawing.Size(1200, 586);
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
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox citycomboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}
