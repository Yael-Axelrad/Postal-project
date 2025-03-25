namespace postProject.Gui
{
    partial class UcCChange
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
            this.clientpanel = new System.Windows.Forms.Panel();
            this.idlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.firstNamelabel = new System.Windows.Forms.Label();
            this.firstNametextBox = new System.Windows.Forms.TextBox();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.clientpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientpanel
            // 
            this.clientpanel.Controls.Add(this.idlabel);
            this.clientpanel.Controls.Add(this.button1);
            this.clientpanel.Controls.Add(this.firstNamelabel);
            this.clientpanel.Controls.Add(this.firstNametextBox);
            this.clientpanel.Controls.Add(this.idtextBox);
            this.clientpanel.Location = new System.Drawing.Point(125, 11);
            this.clientpanel.Name = "clientpanel";
            this.clientpanel.Size = new System.Drawing.Size(289, 377);
            this.clientpanel.TabIndex = 19;
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(190, 39);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(47, 13);
            this.idlabel.TabIndex = 0;
            this.idlabel.Text = "קוד עיר";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Location = new System.Drawing.Point(101, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "עדכן";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // firstNamelabel
            // 
            this.firstNamelabel.AutoSize = true;
            this.firstNamelabel.Location = new System.Drawing.Point(190, 84);
            this.firstNamelabel.Name = "firstNamelabel";
            this.firstNamelabel.Size = new System.Drawing.Size(44, 13);
            this.firstNamelabel.TabIndex = 1;
            this.firstNamelabel.Text = "שם עיר";
            // 
            // firstNametextBox
            // 
            this.firstNametextBox.BackColor = System.Drawing.Color.White;
            this.firstNametextBox.Location = new System.Drawing.Point(31, 84);
            this.firstNametextBox.Name = "firstNametextBox";
            this.firstNametextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNametextBox.TabIndex = 7;
            // 
            // idtextBox
            // 
            this.idtextBox.BackColor = System.Drawing.Color.White;
            this.idtextBox.Location = new System.Drawing.Point(31, 39);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(100, 20);
            this.idtextBox.TabIndex = 6;
            // 
            // UcCChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clientpanel);
            this.Name = "UcCChange";
            this.Size = new System.Drawing.Size(538, 399);
            this.clientpanel.ResumeLayout(false);
            this.clientpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel clientpanel;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label firstNamelabel;
        private System.Windows.Forms.TextBox firstNametextBox;
        private System.Windows.Forms.TextBox idtextBox;
    }
}
