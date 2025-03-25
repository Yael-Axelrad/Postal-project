namespace postProject.Gui
{
    partial class FormPrincipal
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
            this.buttonBranch = new System.Windows.Forms.Button();
            this.panelMainOfPrincipal = new System.Windows.Forms.Panel();
            this.buttonCity = new System.Windows.Forms.Button();
            this.buttonGetTor = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonServisKind = new System.Windows.Forms.Button();
            this.buttonWorkOfTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBranch
            // 
            this.buttonBranch.Location = new System.Drawing.Point(624, 2);
            this.buttonBranch.Name = "buttonBranch";
            this.buttonBranch.Size = new System.Drawing.Size(173, 64);
            this.buttonBranch.TabIndex = 0;
            this.buttonBranch.Text = "סניפים";
            this.buttonBranch.UseVisualStyleBackColor = true;
            this.buttonBranch.Click += new System.EventHandler(this.buttonBranch_Click_1);
            // 
            // panelMainOfPrincipal
            // 
            this.panelMainOfPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelMainOfPrincipal.Name = "panelMainOfPrincipal";
            this.panelMainOfPrincipal.Size = new System.Drawing.Size(621, 438);
            this.panelMainOfPrincipal.TabIndex = 1;
            this.panelMainOfPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonCity
            // 
            this.buttonCity.Location = new System.Drawing.Point(623, 152);
            this.buttonCity.Name = "buttonCity";
            this.buttonCity.Size = new System.Drawing.Size(173, 64);
            this.buttonCity.TabIndex = 3;
            this.buttonCity.Text = "ערים";
            this.buttonCity.UseVisualStyleBackColor = true;
            this.buttonCity.Click += new System.EventHandler(this.buttonCity_Click_1);
            // 
            // buttonGetTor
            // 
            this.buttonGetTor.Location = new System.Drawing.Point(624, 374);
            this.buttonGetTor.Name = "buttonGetTor";
            this.buttonGetTor.Size = new System.Drawing.Size(173, 64);
            this.buttonGetTor.TabIndex = 4;
            this.buttonGetTor.Text = "זמון תור";
            this.buttonGetTor.UseVisualStyleBackColor = true;
            this.buttonGetTor.Click += new System.EventHandler(this.buttonGetTor_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(624, 301);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(173, 64);
            this.buttonClient.TabIndex = 5;
            this.buttonClient.Text = "לקוחות";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonServisKind
            // 
            this.buttonServisKind.Location = new System.Drawing.Point(623, 227);
            this.buttonServisKind.Name = "buttonServisKind";
            this.buttonServisKind.Size = new System.Drawing.Size(173, 64);
            this.buttonServisKind.TabIndex = 6;
            this.buttonServisKind.Text = "סוג שרות";
            this.buttonServisKind.UseVisualStyleBackColor = true;
            this.buttonServisKind.Click += new System.EventHandler(this.buttonServisKind_Click);
            // 
            // buttonWorkOfTime
            // 
            this.buttonWorkOfTime.Location = new System.Drawing.Point(624, 78);
            this.buttonWorkOfTime.Name = "buttonWorkOfTime";
            this.buttonWorkOfTime.Size = new System.Drawing.Size(173, 64);
            this.buttonWorkOfTime.TabIndex = 2;
            this.buttonWorkOfTime.Text = "זמני פעילות";
            this.buttonWorkOfTime.UseVisualStyleBackColor = true;
            this.buttonWorkOfTime.Click += new System.EventHandler(this.buttonWorkOfTime_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonServisKind);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonGetTor);
            this.Controls.Add(this.buttonCity);
            this.Controls.Add(this.buttonWorkOfTime);
            this.Controls.Add(this.panelMainOfPrincipal);
            this.Controls.Add(this.buttonBranch);
            this.Name = "FormPrincipal";
            this.Text = "principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBranch;
        public System.Windows.Forms.Panel panelMainOfPrincipal;
        private System.Windows.Forms.Button buttonCity;
        private System.Windows.Forms.Button buttonGetTor;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonServisKind;
        private System.Windows.Forms.Button buttonWorkOfTime;
    }
}