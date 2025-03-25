namespace postProject.Gui
{
    partial class UcCAdd
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
            this.idlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.firstNamelabel = new System.Windows.Forms.Label();
            this.cityNametextBox = new System.Windows.Forms.TextBox();
            this.kodCtextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.clientpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // clientpanel
            // 
            this.clientpanel.Controls.Add(this.label1);
            this.clientpanel.Controls.Add(this.idlabel);
            this.clientpanel.Controls.Add(this.button1);
            this.clientpanel.Controls.Add(this.firstNamelabel);
            this.clientpanel.Controls.Add(this.cityNametextBox);
            this.clientpanel.Controls.Add(this.kodCtextBox);
            this.clientpanel.Location = new System.Drawing.Point(283, 81);
            this.clientpanel.Name = "clientpanel";
            this.clientpanel.Size = new System.Drawing.Size(254, 204);
            this.clientpanel.TabIndex = 18;
            this.clientpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.clientpanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(53, 115);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "עיר זאת קיימת במערכת!";
            this.label1.Visible = false;
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.ForeColor = System.Drawing.Color.Red;
            this.idlabel.Location = new System.Drawing.Point(190, 43);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(46, 20);
            this.idlabel.TabIndex = 0;
            this.idlabel.Text = "קוד עיר";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(31, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "אישור";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // firstNamelabel
            // 
            this.firstNamelabel.AutoSize = true;
            this.firstNamelabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNamelabel.ForeColor = System.Drawing.Color.Red;
            this.firstNamelabel.Location = new System.Drawing.Point(190, 89);
            this.firstNamelabel.Name = "firstNamelabel";
            this.firstNamelabel.Size = new System.Drawing.Size(46, 20);
            this.firstNamelabel.TabIndex = 1;
            this.firstNamelabel.Text = "שם עיר";
            // 
            // cityNametextBox
            // 
            this.cityNametextBox.BackColor = System.Drawing.Color.White;
            this.cityNametextBox.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityNametextBox.Location = new System.Drawing.Point(31, 84);
            this.cityNametextBox.Name = "cityNametextBox";
            this.cityNametextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cityNametextBox.Size = new System.Drawing.Size(153, 28);
            this.cityNametextBox.TabIndex = 7;
            this.cityNametextBox.TextChanged += new System.EventHandler(this.cityNametextBox_TextChanged);
            // 
            // kodCtextBox
            // 
            this.kodCtextBox.BackColor = System.Drawing.Color.White;
            this.kodCtextBox.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodCtextBox.Location = new System.Drawing.Point(31, 39);
            this.kodCtextBox.Name = "kodCtextBox";
            this.kodCtextBox.ReadOnly = true;
            this.kodCtextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kodCtextBox.Size = new System.Drawing.Size(153, 28);
            this.kodCtextBox.TabIndex = 6;
            this.kodCtextBox.TextChanged += new System.EventHandler(this.kodCtextBox_TextChanged);
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
            this.button3.Location = new System.Drawing.Point(640, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 77);
            this.button3.TabIndex = 39;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // UcCAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clientpanel);
            this.Name = "UcCAdd";
            this.Size = new System.Drawing.Size(800, 381);
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
        private System.Windows.Forms.TextBox cityNametextBox;
        private System.Windows.Forms.TextBox kodCtextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}
