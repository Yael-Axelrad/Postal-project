namespace postProject.Gui
{
    partial class FormClient
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTor = new System.Windows.Forms.Button();
            this.buttonMikud = new System.Windows.Forms.Button();
            this.buttonLookAfter = new System.Windows.Forms.Button();
            this.buttonSale = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 112);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(271, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "אנחנו כאן כדי לעזור מה מענין אותך?";
            this.label1.UseWaitCursor = true;
            // 
            // buttonTor
            // 
            this.buttonTor.BackColor = System.Drawing.Color.White;
            this.buttonTor.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonTor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.buttonTor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonTor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonTor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTor.Location = new System.Drawing.Point(535, 180);
            this.buttonTor.Name = "buttonTor";
            this.buttonTor.Size = new System.Drawing.Size(97, 111);
            this.buttonTor.TabIndex = 1;
            this.buttonTor.Text = "איתור סניפים וזימון תורים";
            this.buttonTor.UseVisualStyleBackColor = false;
            this.buttonTor.UseWaitCursor = true;
            this.buttonTor.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMikud
            // 
            this.buttonMikud.BackColor = System.Drawing.Color.White;
            this.buttonMikud.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonMikud.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.buttonMikud.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonMikud.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonMikud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMikud.Location = new System.Drawing.Point(279, 180);
            this.buttonMikud.Name = "buttonMikud";
            this.buttonMikud.Size = new System.Drawing.Size(97, 111);
            this.buttonMikud.TabIndex = 2;
            this.buttonMikud.Text = "איתור מיקוד";
            this.buttonMikud.UseVisualStyleBackColor = false;
            this.buttonMikud.UseWaitCursor = true;
            // 
            // buttonLookAfter
            // 
            this.buttonLookAfter.BackColor = System.Drawing.Color.White;
            this.buttonLookAfter.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonLookAfter.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.buttonLookAfter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonLookAfter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonLookAfter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLookAfter.Location = new System.Drawing.Point(409, 180);
            this.buttonLookAfter.Name = "buttonLookAfter";
            this.buttonLookAfter.Size = new System.Drawing.Size(97, 111);
            this.buttonLookAfter.TabIndex = 3;
            this.buttonLookAfter.Text = "מעקב משלוחים";
            this.buttonLookAfter.UseVisualStyleBackColor = false;
            this.buttonLookAfter.UseWaitCursor = true;
            this.buttonLookAfter.Click += new System.EventHandler(this.buttonLookAfter_Click);
            // 
            // buttonSale
            // 
            this.buttonSale.BackColor = System.Drawing.Color.White;
            this.buttonSale.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonSale.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.buttonSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSale.Location = new System.Drawing.Point(151, 180);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(97, 111);
            this.buttonSale.TabIndex = 4;
            this.buttonSale.Text = "מחירון דואר";
            this.buttonSale.UseVisualStyleBackColor = false;
            this.buttonSale.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonSale);
            this.panel1.Controls.Add(this.buttonTor);
            this.panel1.Controls.Add(this.buttonLookAfter);
            this.panel1.Controls.Add(this.buttonMikud);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 5;
            this.panel1.UseWaitCursor = true;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTor;
        private System.Windows.Forms.Button buttonMikud;
        private System.Windows.Forms.Button buttonLookAfter;
        private System.Windows.Forms.Button buttonSale;
        public System.Windows.Forms.Panel panel1;
    }
}