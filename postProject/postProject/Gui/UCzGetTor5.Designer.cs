namespace postProject.Gui
{
    partial class UCzGetTor5
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonContinyu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 154);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "פגישתך נקבעה בהצלחה!";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonContinyu
            // 
            this.buttonContinyu.BackColor = System.Drawing.Color.White;
            this.buttonContinyu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContinyu.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonContinyu.FlatAppearance.BorderSize = 2;
            this.buttonContinyu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonContinyu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonContinyu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonContinyu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinyu.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinyu.ForeColor = System.Drawing.Color.Red;
            this.buttonContinyu.Location = new System.Drawing.Point(535, 150);
            this.buttonContinyu.Name = "buttonContinyu";
            this.buttonContinyu.Size = new System.Drawing.Size(84, 26);
            this.buttonContinyu.TabIndex = 6;
            this.buttonContinyu.Text = "המשך";
            this.buttonContinyu.UseVisualStyleBackColor = false;
            this.buttonContinyu.Click += new System.EventHandler(this.buttonContinyu_Click);
            // 
            // UCzGetTor5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonContinyu);
            this.Controls.Add(this.label1);
            this.Name = "UCzGetTor5";
            this.Size = new System.Drawing.Size(800, 454);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonContinyu;
    }
}
