namespace Zgadywanka_projekt_studia
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
            this.label1 = new System.Windows.Forms.Label();
            this.liczba = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.tabela = new System.Windows.Forms.ListView();
            this.Propozycja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Odpowiedź = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.od = new System.Windows.Forms.TextBox();
            this.nowaGra = new System.Windows.Forms.Button();
            this.doo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rozgrywka = new System.Windows.Forms.GroupBox();
            this.poddanie = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.rozgrywka.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Podaj liczbę";
            // 
            // liczba
            // 
            this.liczba.Location = new System.Drawing.Point(76, 24);
            this.liczba.Name = "liczba";
            this.liczba.Size = new System.Drawing.Size(142, 20);
            this.liczba.TabIndex = 4;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(225, 22);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 5;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            // 
            // tabela
            // 
            this.tabela.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Propozycja,
            this.Odpowiedź});
            this.tabela.Location = new System.Drawing.Point(6, 51);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(294, 153);
            this.tabela.TabIndex = 6;
            this.tabela.UseCompatibleStateImageBehavior = false;
            this.tabela.View = System.Windows.Forms.View.Details;
            // 
            // Propozycja
            // 
            this.Propozycja.Text = "Propozycja";
            this.Propozycja.Width = 147;
            // 
            // Odpowiedź
            // 
            this.Odpowiedź.Text = "Odpowiedź";
            this.Odpowiedź.Width = 147;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DO";
            // 
            // od
            // 
            this.od.Location = new System.Drawing.Point(9, 42);
            this.od.Name = "od";
            this.od.Size = new System.Drawing.Size(143, 20);
            this.od.TabIndex = 9;
            // 
            // nowaGra
            // 
            this.nowaGra.Location = new System.Drawing.Point(9, 68);
            this.nowaGra.Name = "nowaGra";
            this.nowaGra.Size = new System.Drawing.Size(290, 23);
            this.nowaGra.TabIndex = 0;
            this.nowaGra.Text = "Nowa Gra";
            this.nowaGra.UseVisualStyleBackColor = true;
            // 
            // doo
            // 
            this.doo.Location = new System.Drawing.Point(158, 42);
            this.doo.Name = "doo";
            this.doo.Size = new System.Drawing.Size(141, 20);
            this.doo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "OD";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.doo);
            this.groupBox1.Controls.Add(this.nowaGra);
            this.groupBox1.Controls.Add(this.od);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 110);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start";
            // 
            // rozgrywka
            // 
            this.rozgrywka.Controls.Add(this.poddanie);
            this.rozgrywka.Controls.Add(this.label1);
            this.rozgrywka.Controls.Add(this.liczba);
            this.rozgrywka.Controls.Add(this.tabela);
            this.rozgrywka.Controls.Add(this.ok);
            this.rozgrywka.Location = new System.Drawing.Point(12, 128);
            this.rozgrywka.Name = "rozgrywka";
            this.rozgrywka.Size = new System.Drawing.Size(305, 241);
            this.rozgrywka.TabIndex = 12;
            this.rozgrywka.TabStop = false;
            this.rozgrywka.Text = "Rozgrywka";
            // 
            // poddanie
            // 
            this.poddanie.Location = new System.Drawing.Point(6, 210);
            this.poddanie.Name = "poddanie";
            this.poddanie.Size = new System.Drawing.Size(293, 23);
            this.poddanie.TabIndex = 7;
            this.poddanie.Text = "Poddaję się";
            this.poddanie.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 384);
            this.Controls.Add(this.rozgrywka);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Zgadywanka";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.rozgrywka.ResumeLayout(false);
            this.rozgrywka.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox liczba;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.ListView tabela;
        private System.Windows.Forms.ColumnHeader Propozycja;
        private System.Windows.Forms.ColumnHeader Odpowiedź;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox od;
        private System.Windows.Forms.Button nowaGra;
        private System.Windows.Forms.TextBox doo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox rozgrywka;
        private System.Windows.Forms.Button poddanie;
    }
}

