namespace WypozyczlniaGierIKsiazek
{
    partial class GlowneOkno
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
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.listBoxListaGier = new System.Windows.Forms.ListBox();
            this.listBoxListaKsiazek = new System.Windows.Forms.ListBox();
            this.buttonUsunKsiazke = new System.Windows.Forms.Button();
            this.buttonDodajKsiazke = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteka gier";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(82, 306);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj gre";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(82, 335);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 23);
            this.buttonUsun.TabIndex = 2;
            this.buttonUsun.Text = "Usuń gre";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // listBoxListaGier
            // 
            this.listBoxListaGier.FormattingEnabled = true;
            this.listBoxListaGier.Location = new System.Drawing.Point(12, 42);
            this.listBoxListaGier.Name = "listBoxListaGier";
            this.listBoxListaGier.Size = new System.Drawing.Size(246, 251);
            this.listBoxListaGier.TabIndex = 4;
            // 
            // listBoxListaKsiazek
            // 
            this.listBoxListaKsiazek.FormattingEnabled = true;
            this.listBoxListaKsiazek.Location = new System.Drawing.Point(305, 42);
            this.listBoxListaKsiazek.Name = "listBoxListaKsiazek";
            this.listBoxListaKsiazek.Size = new System.Drawing.Size(246, 251);
            this.listBoxListaKsiazek.TabIndex = 8;
            // 
            // buttonUsunKsiazke
            // 
            this.buttonUsunKsiazke.Location = new System.Drawing.Point(375, 335);
            this.buttonUsunKsiazke.Name = "buttonUsunKsiazke";
            this.buttonUsunKsiazke.Size = new System.Drawing.Size(90, 23);
            this.buttonUsunKsiazke.TabIndex = 7;
            this.buttonUsunKsiazke.Text = "Usuń książkę";
            this.buttonUsunKsiazke.UseVisualStyleBackColor = true;
            this.buttonUsunKsiazke.Click += new System.EventHandler(this.buttonUsunKsiazke_Click);
            // 
            // buttonDodajKsiazke
            // 
            this.buttonDodajKsiazke.Location = new System.Drawing.Point(375, 306);
            this.buttonDodajKsiazke.Name = "buttonDodajKsiazke";
            this.buttonDodajKsiazke.Size = new System.Drawing.Size(90, 23);
            this.buttonDodajKsiazke.TabIndex = 6;
            this.buttonDodajKsiazke.Text = "Dodaj książkę";
            this.buttonDodajKsiazke.UseVisualStyleBackColor = true;
            this.buttonDodajKsiazke.Click += new System.EventHandler(this.buttonDodajKsiazke_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(299, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Biblioteka książek";
            // 
            // GlowneOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 381);
            this.Controls.Add(this.listBoxListaKsiazek);
            this.Controls.Add(this.buttonUsunKsiazke);
            this.Controls.Add(this.buttonDodajKsiazke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxListaGier);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label1);
            this.Name = "GlowneOkno";
            this.Text = "GlowneOkno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GlowneOkno_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.ListBox listBoxListaGier;
        private System.Windows.Forms.ListBox listBoxListaKsiazek;
        private System.Windows.Forms.Button buttonUsunKsiazke;
        private System.Windows.Forms.Button buttonDodajKsiazke;
        private System.Windows.Forms.Label label2;
    }
}