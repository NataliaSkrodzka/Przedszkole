namespace Przedszkole
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.wpisywanieDodaj = new System.Windows.Forms.TextBox();
            this.Dodaj = new System.Windows.Forms.Button();
            this.wpisywanieUsun = new System.Windows.Forms.TextBox();
            this.Usun = new System.Windows.Forms.Button();
            this.wpisywanieWyszukaj = new System.Windows.Forms.TextBox();
            this.Wyszukaj = new System.Windows.Forms.Button();
            this.wpisywanieZmien = new System.Windows.Forms.TextBox();
            this.Zmien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wyswietl Wszystkich";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.WyswietlWszystkich_Click);
            // 
            // wpisywanieDodaj
            // 
            this.wpisywanieDodaj.Location = new System.Drawing.Point(243, 67);
            this.wpisywanieDodaj.Name = "wpisywanieDodaj";
            this.wpisywanieDodaj.Size = new System.Drawing.Size(152, 22);
            this.wpisywanieDodaj.TabIndex = 1;
            this.wpisywanieDodaj.TextChanged += new System.EventHandler(this.wpisywanieDodaj_TextChanged);
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(243, 96);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(152, 23);
            this.Dodaj.TabIndex = 2;
            this.Dodaj.Text = "Dodaj przedszkolaka";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // wpisywanieUsun
            // 
            this.wpisywanieUsun.Location = new System.Drawing.Point(419, 68);
            this.wpisywanieUsun.Name = "wpisywanieUsun";
            this.wpisywanieUsun.Size = new System.Drawing.Size(152, 22);
            this.wpisywanieUsun.TabIndex = 3;
            this.wpisywanieUsun.TextChanged += new System.EventHandler(this.wpisywanieUsun_TextChanged);
            // 
            // Usun
            // 
            this.Usun.Location = new System.Drawing.Point(419, 96);
            this.Usun.Name = "Usun";
            this.Usun.Size = new System.Drawing.Size(152, 23);
            this.Usun.TabIndex = 4;
            this.Usun.Text = "Usuń przedszkolaka";
            this.Usun.UseVisualStyleBackColor = true;
            this.Usun.Click += new System.EventHandler(this.Usun_Click);
            // 
            // wpisywanieWyszukaj
            // 
            this.wpisywanieWyszukaj.Location = new System.Drawing.Point(243, 183);
            this.wpisywanieWyszukaj.Name = "wpisywanieWyszukaj";
            this.wpisywanieWyszukaj.Size = new System.Drawing.Size(166, 22);
            this.wpisywanieWyszukaj.TabIndex = 5;
            this.wpisywanieWyszukaj.TextChanged += new System.EventHandler(this.wpisywanieWyszukaj_TextChanged);
            // 
            // Wyszukaj
            // 
            this.Wyszukaj.Location = new System.Drawing.Point(243, 211);
            this.Wyszukaj.Name = "Wyszukaj";
            this.Wyszukaj.Size = new System.Drawing.Size(166, 23);
            this.Wyszukaj.TabIndex = 6;
            this.Wyszukaj.Text = "Wyszukaj przedszkolaka";
            this.Wyszukaj.UseVisualStyleBackColor = true;
            this.Wyszukaj.Click += new System.EventHandler(this.Wyszukaj_Click);
            // 
            // wpisywanieZmien
            // 
            this.wpisywanieZmien.Location = new System.Drawing.Point(419, 183);
            this.wpisywanieZmien.Name = "wpisywanieZmien";
            this.wpisywanieZmien.Size = new System.Drawing.Size(166, 22);
            this.wpisywanieZmien.TabIndex = 7;
            this.wpisywanieZmien.TextChanged += new System.EventHandler(this.wpisywanieZmien_TextChanged);
            // 
            // Zmien
            // 
            this.Zmien.Location = new System.Drawing.Point(419, 211);
            this.Zmien.Name = "Zmien";
            this.Zmien.Size = new System.Drawing.Size(152, 23);
            this.Zmien.TabIndex = 8;
            this.Zmien.Text = "Zmień saldo";
            this.Zmien.UseVisualStyleBackColor = true;
            this.Zmien.Click += new System.EventHandler(this.Zmien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Zmien);
            this.Controls.Add(this.wpisywanieZmien);
            this.Controls.Add(this.Wyszukaj);
            this.Controls.Add(this.wpisywanieWyszukaj);
            this.Controls.Add(this.Usun);
            this.Controls.Add(this.wpisywanieUsun);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.wpisywanieDodaj);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox wpisywanieDodaj;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.TextBox wpisywanieUsun;
        private System.Windows.Forms.Button Usun;
        private System.Windows.Forms.TextBox wpisywanieWyszukaj;
        private System.Windows.Forms.Button Wyszukaj;
        private System.Windows.Forms.TextBox wpisywanieZmien;
        private System.Windows.Forms.Button Zmien;
    }
}

