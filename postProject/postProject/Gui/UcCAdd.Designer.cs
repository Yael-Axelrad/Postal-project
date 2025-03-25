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
            this.idlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.firstNamelabel = new System.Windows.Forms.Label();
            this.cityNametextBox = new System.Windows.Forms.TextBox();
            this.kodCtextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.clientpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // clientpanel
            // 
            this.clientpanel.Controls.Add(this.idlabel);
            this.clientpanel.Controls.Add(this.button1);
            this.clientpanel.Controls.Add(this.firstNamelabel);
            this.clientpanel.Controls.Add(this.cityNametextBox);
            this.clientpanel.Controls.Add(this.kodCtextBox);
            this.clientpanel.Location = new System.Drawing.Point(178, 81);
            this.clientpanel.Name = "clientpanel";
            this.clientpanel.Size = new System.Drawing.Size(254, 204);
            this.clientpanel.TabIndex = 18;
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.ForeColor = System.Drawing.Color.Red;
            this.idlabel.Location = new System.Drawing.Point(190, 39);
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
            this.button1.Location = new System.Drawing.Point(89, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 26);
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
            this.firstNamelabel.Location = new System.Drawing.Point(190, 84);
            this.firstNamelabel.Name = "firstNamelabel";
            this.firstNamelabel.Size = new System.Drawing.Size(46, 20);
            this.firstNamelabel.TabIndex = 1;
            this.firstNamelabel.Text = "שם עיר";
            // 
            // cityNametextBox
            // 
            this.cityNametextBox.BackColor = System.Drawing.Color.White;
            this.cityNametextBox.Location = new System.Drawing.Point(31, 84);
            this.cityNametextBox.Name = "cityNametextBox";
            this.cityNametextBox.Size = new System.Drawing.Size(100, 20);
            this.cityNametextBox.TabIndex = 7;
            // 
            // kodCtextBox
            // 
            this.kodCtextBox.BackColor = System.Drawing.Color.White;
            this.kodCtextBox.Location = new System.Drawing.Point(31, 39);
            this.kodCtextBox.Name = "kodCtextBox";
            this.kodCtextBox.ReadOnly = true;
            this.kodCtextBox.Size = new System.Drawing.Size(100, 20);
            this.kodCtextBox.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // UcCAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.clientpanel);
            this.Name = "UcCAdd";
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
        private System.Windows.Forms.TextBox cityNametextBox;
        private System.Windows.Forms.TextBox kodCtextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
