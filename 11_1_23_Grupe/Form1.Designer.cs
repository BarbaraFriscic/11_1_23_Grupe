namespace _11_1_23_Grupe
{
    partial class Form1
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
            this.gbxStvaranjeGrupe = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtbrUcenika = new System.Windows.Forms.TextBox();
            this.lblBrUcenika = new System.Windows.Forms.Label();
            this.gbxUnosUcenika = new System.Windows.Forms.GroupBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblOIB = new System.Windows.Forms.Label();
            this.lstUcenici = new System.Windows.Forms.ListBox();
            this.gbxStvaranjeGrupe.SuspendLayout();
            this.gbxUnosUcenika.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxStvaranjeGrupe
            // 
            this.gbxStvaranjeGrupe.Controls.Add(this.btnCreate);
            this.gbxStvaranjeGrupe.Controls.Add(this.txtbrUcenika);
            this.gbxStvaranjeGrupe.Controls.Add(this.lblBrUcenika);
            this.gbxStvaranjeGrupe.Location = new System.Drawing.Point(12, 12);
            this.gbxStvaranjeGrupe.Name = "gbxStvaranjeGrupe";
            this.gbxStvaranjeGrupe.Size = new System.Drawing.Size(343, 66);
            this.gbxStvaranjeGrupe.TabIndex = 0;
            this.gbxStvaranjeGrupe.TabStop = false;
            this.gbxStvaranjeGrupe.Text = "Stvaranje grupe";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(234, 28);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(62, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Kreiraj";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtbrUcenika
            // 
            this.txtbrUcenika.Location = new System.Drawing.Point(96, 30);
            this.txtbrUcenika.Name = "txtbrUcenika";
            this.txtbrUcenika.Size = new System.Drawing.Size(100, 20);
            this.txtbrUcenika.TabIndex = 1;
            // 
            // lblBrUcenika
            // 
            this.lblBrUcenika.AutoSize = true;
            this.lblBrUcenika.Location = new System.Drawing.Point(21, 34);
            this.lblBrUcenika.Name = "lblBrUcenika";
            this.lblBrUcenika.Size = new System.Drawing.Size(69, 13);
            this.lblBrUcenika.TabIndex = 0;
            this.lblBrUcenika.Text = "Broj učenika:";
            // 
            // gbxUnosUcenika
            // 
            this.gbxUnosUcenika.Controls.Add(this.btnUnesi);
            this.gbxUnosUcenika.Controls.Add(this.txtIme);
            this.gbxUnosUcenika.Controls.Add(this.txtPrezime);
            this.gbxUnosUcenika.Controls.Add(this.txtOIB);
            this.gbxUnosUcenika.Controls.Add(this.lblIme);
            this.gbxUnosUcenika.Controls.Add(this.lblPrezime);
            this.gbxUnosUcenika.Controls.Add(this.lblOIB);
            this.gbxUnosUcenika.Controls.Add(this.lstUcenici);
            this.gbxUnosUcenika.Location = new System.Drawing.Point(12, 104);
            this.gbxUnosUcenika.Name = "gbxUnosUcenika";
            this.gbxUnosUcenika.Size = new System.Drawing.Size(343, 259);
            this.gbxUnosUcenika.TabIndex = 1;
            this.gbxUnosUcenika.TabStop = false;
            this.gbxUnosUcenika.Text = "Unos učenika";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(210, 185);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(100, 23);
            this.btnUnesi.TabIndex = 6;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(210, 65);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 3;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(210, 106);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 4;
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(210, 145);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(100, 20);
            this.txtOIB.TabIndex = 5;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(207, 49);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 3;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(207, 90);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Location = new System.Drawing.Point(207, 129);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(28, 13);
            this.lblOIB.TabIndex = 5;
            this.lblOIB.Text = "OIB:";
            // 
            // lstUcenici
            // 
            this.lstUcenici.FormattingEnabled = true;
            this.lstUcenici.Location = new System.Drawing.Point(6, 28);
            this.lstUcenici.Name = "lstUcenici";
            this.lstUcenici.Size = new System.Drawing.Size(170, 225);
            this.lstUcenici.TabIndex = 0;
            this.lstUcenici.SelectedIndexChanged += new System.EventHandler(this.lstUcenici_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 374);
            this.Controls.Add(this.gbxUnosUcenika);
            this.Controls.Add(this.gbxStvaranjeGrupe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxStvaranjeGrupe.ResumeLayout(false);
            this.gbxStvaranjeGrupe.PerformLayout();
            this.gbxUnosUcenika.ResumeLayout(false);
            this.gbxUnosUcenika.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStvaranjeGrupe;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtbrUcenika;
        private System.Windows.Forms.Label lblBrUcenika;
        private System.Windows.Forms.GroupBox gbxUnosUcenika;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.ListBox lstUcenici;
    }
}

