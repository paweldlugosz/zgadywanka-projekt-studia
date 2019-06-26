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
            this.input = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.ListView();
            this.Propozycja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Odpowiedź = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Czas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.TextBox();
            this.newGame = new System.Windows.Forms.Button();
            this.to = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.configGroup = new System.Windows.Forms.GroupBox();
            this.cheat = new System.Windows.Forms.CheckBox();
            this.gameGroup = new System.Windows.Forms.GroupBox();
            this.response = new System.Windows.Forms.Label();
            this.giveUp = new System.Windows.Forms.Button();
            this.configGroup.SuspendLayout();
            this.gameGroup.SuspendLayout();
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
            // input
            // 
            this.input.Location = new System.Drawing.Point(76, 23);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(142, 20);
            this.input.TabIndex = 4;
            this.input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Input_KeyUp);
            // 
            // check
            // 
            this.check.Enabled = false;
            this.check.Location = new System.Drawing.Point(225, 22);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 5;
            this.check.Text = "OK";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.Check_Click);
            // 
            // table
            // 
            this.table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Propozycja,
            this.Odpowiedź,
            this.Czas});
            this.table.Location = new System.Drawing.Point(5, 82);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(294, 153);
            this.table.TabIndex = 6;
            this.table.UseCompatibleStateImageBehavior = false;
            this.table.View = System.Windows.Forms.View.Details;
            // 
            // Propozycja
            // 
            this.Propozycja.Text = "Propozycja";
            this.Propozycja.Width = 67;
            // 
            // Odpowiedź
            // 
            this.Odpowiedź.Text = "Odpowiedź";
            this.Odpowiedź.Width = 89;
            // 
            // Czas
            // 
            this.Czas.Text = "Czas";
            this.Czas.Width = 133;
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
            // from
            // 
            this.from.Location = new System.Drawing.Point(9, 42);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(143, 20);
            this.from.TabIndex = 9;
            this.from.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Range_KeyUp);
            // 
            // newGame
            // 
            this.newGame.Enabled = false;
            this.newGame.Location = new System.Drawing.Point(9, 68);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(290, 23);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "Nowa Gra";
            this.newGame.UseVisualStyleBackColor = true;
            this.newGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(158, 42);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(141, 20);
            this.to.TabIndex = 10;
            this.to.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Range_KeyUp);
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
            // configGroup
            // 
            this.configGroup.Controls.Add(this.cheat);
            this.configGroup.Controls.Add(this.label2);
            this.configGroup.Controls.Add(this.to);
            this.configGroup.Controls.Add(this.newGame);
            this.configGroup.Controls.Add(this.from);
            this.configGroup.Controls.Add(this.label3);
            this.configGroup.Location = new System.Drawing.Point(12, 12);
            this.configGroup.Name = "configGroup";
            this.configGroup.Size = new System.Drawing.Size(305, 127);
            this.configGroup.TabIndex = 11;
            this.configGroup.TabStop = false;
            this.configGroup.Text = "Start";
            // 
            // cheat
            // 
            this.cheat.AutoSize = true;
            this.cheat.Location = new System.Drawing.Point(9, 97);
            this.cheat.Name = "cheat";
            this.cheat.Size = new System.Drawing.Size(159, 17);
            this.cheat.TabIndex = 11;
            this.cheat.Text = "Komputer może raz oszukać";
            this.cheat.UseVisualStyleBackColor = true;
            // 
            // gameGroup
            // 
            this.gameGroup.Controls.Add(this.response);
            this.gameGroup.Controls.Add(this.giveUp);
            this.gameGroup.Controls.Add(this.label1);
            this.gameGroup.Controls.Add(this.input);
            this.gameGroup.Controls.Add(this.table);
            this.gameGroup.Controls.Add(this.check);
            this.gameGroup.Enabled = false;
            this.gameGroup.Location = new System.Drawing.Point(12, 145);
            this.gameGroup.Name = "gameGroup";
            this.gameGroup.Size = new System.Drawing.Size(305, 276);
            this.gameGroup.TabIndex = 12;
            this.gameGroup.TabStop = false;
            this.gameGroup.Text = "Rozgrywka";
            // 
            // response
            // 
            this.response.AutoSize = true;
            this.response.Location = new System.Drawing.Point(6, 56);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(47, 13);
            this.response.TabIndex = 8;
            this.response.Text = "Za mało";
            // 
            // giveUp
            // 
            this.giveUp.Location = new System.Drawing.Point(5, 241);
            this.giveUp.Name = "giveUp";
            this.giveUp.Size = new System.Drawing.Size(294, 23);
            this.giveUp.TabIndex = 7;
            this.giveUp.Text = "Poddaję się";
            this.giveUp.UseVisualStyleBackColor = true;
            this.giveUp.Click += new System.EventHandler(this.GiveUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 428);
            this.Controls.Add(this.gameGroup);
            this.Controls.Add(this.configGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Zgadywanka";
            this.configGroup.ResumeLayout(false);
            this.configGroup.PerformLayout();
            this.gameGroup.ResumeLayout(false);
            this.gameGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.ListView table;
        private System.Windows.Forms.ColumnHeader Propozycja;
        private System.Windows.Forms.ColumnHeader Odpowiedź;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox configGroup;
        private System.Windows.Forms.GroupBox gameGroup;
        private System.Windows.Forms.Button giveUp;
        private System.Windows.Forms.ColumnHeader Czas;
        private System.Windows.Forms.CheckBox cheat;
        private System.Windows.Forms.Label response;
    }
}

