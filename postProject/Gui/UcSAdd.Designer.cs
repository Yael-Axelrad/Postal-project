﻿namespace postProject.Gui
{
    partial class UcSAdd
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
            this.kodlabel = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.branchlabel = new System.Windows.Forms.Label();
            this.longtextBox = new System.Windows.Forms.TextBox();
            this.streetlabel = new System.Windows.Forms.Label();
            this.deckribetextBox = new System.Windows.Forms.TextBox();
            this.kodtextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.clientpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientpanel
            // 
            this.clientpanel.Controls.Add(this.kodlabel);
            this.clientpanel.Controls.Add(this.addbutton);
            this.clientpanel.Controls.Add(this.branchlabel);
            this.clientpanel.Controls.Add(this.longtextBox);
            this.clientpanel.Controls.Add(this.streetlabel);
            this.clientpanel.Controls.Add(this.deckribetextBox);
            this.clientpanel.Controls.Add(this.kodtextBox);
            this.clientpanel.Location = new System.Drawing.Point(260, 59);
            this.clientpanel.Name = "clientpanel";
            this.clientpanel.Size = new System.Drawing.Size(289, 273);
            this.clientpanel.TabIndex = 16;
            // 
            // kodlabel
            // 
            this.kodlabel.AutoSize = true;
            this.kodlabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodlabel.ForeColor = System.Drawing.Color.Red;
            this.kodlabel.Location = new System.Drawing.Point(190, 39);
            this.kodlabel.Name = "kodlabel";
            this.kodlabel.Size = new System.Drawing.Size(57, 20);
            this.kodlabel.TabIndex = 0;
            this.kodlabel.Text = "קוד שרות";
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
            this.addbutton.Location = new System.Drawing.Point(31, 166);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(201, 27);
            this.addbutton.TabIndex = 11;
            this.addbutton.Text = "אישור";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // branchlabel
            // 
            this.branchlabel.AutoSize = true;
            this.branchlabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchlabel.ForeColor = System.Drawing.Color.Red;
            this.branchlabel.Location = new System.Drawing.Point(190, 84);
            this.branchlabel.Name = "branchlabel";
            this.branchlabel.Size = new System.Drawing.Size(67, 20);
            this.branchlabel.TabIndex = 1;
            this.branchlabel.Text = "תאור שרות";
            // 
            // longtextBox
            // 
            this.longtextBox.BackColor = System.Drawing.Color.White;
            this.longtextBox.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longtextBox.Location = new System.Drawing.Point(31, 124);
            this.longtextBox.Name = "longtextBox";
            this.longtextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.longtextBox.Size = new System.Drawing.Size(153, 28);
            this.longtextBox.TabIndex = 10;
            // 
            // streetlabel
            // 
            this.streetlabel.AutoSize = true;
            this.streetlabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetlabel.ForeColor = System.Drawing.Color.Red;
            this.streetlabel.Location = new System.Drawing.Point(190, 127);
            this.streetlabel.Name = "streetlabel";
            this.streetlabel.Size = new System.Drawing.Size(51, 20);
            this.streetlabel.TabIndex = 2;
            this.streetlabel.Text = "משך זמן";
            // 
            // deckribetextBox
            // 
            this.deckribetextBox.BackColor = System.Drawing.Color.White;
            this.deckribetextBox.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deckribetextBox.Location = new System.Drawing.Point(31, 84);
            this.deckribetextBox.Name = "deckribetextBox";
            this.deckribetextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deckribetextBox.Size = new System.Drawing.Size(153, 28);
            this.deckribetextBox.TabIndex = 7;
            // 
            // kodtextBox
            // 
            this.kodtextBox.BackColor = System.Drawing.Color.White;
            this.kodtextBox.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodtextBox.Location = new System.Drawing.Point(31, 39);
            this.kodtextBox.Name = "kodtextBox";
            this.kodtextBox.ReadOnly = true;
            this.kodtextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kodtextBox.Size = new System.Drawing.Size(153, 28);
            this.kodtextBox.TabIndex = 6;
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
            this.button3.Location = new System.Drawing.Point(640, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 77);
            this.button3.TabIndex = 38;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UcSAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.clientpanel);
            this.Name = "UcSAdd";
            this.Size = new System.Drawing.Size(800, 381);
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
        private System.Windows.Forms.TextBox longtextBox;
        private System.Windows.Forms.Label streetlabel;
        private System.Windows.Forms.TextBox deckribetextBox;
        private System.Windows.Forms.TextBox kodtextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
