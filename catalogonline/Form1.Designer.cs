namespace catalogonline
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
            this.lblnume = new System.Windows.Forms.Label();
            this.lblprenume = new System.Windows.Forms.Label();
            this.lblmama = new System.Windows.Forms.Label();
            this.lbltata = new System.Windows.Forms.Label();
            this.lblcnp = new System.Windows.Forms.Label();
            this.lblclasa = new System.Windows.Forms.Label();
            this.textBoxnume = new System.Windows.Forms.TextBox();
            this.textBoxpren = new System.Windows.Forms.TextBox();
            this.textBoxmama = new System.Windows.Forms.TextBox();
            this.textBoxtata = new System.Windows.Forms.TextBox();
            this.textBoxcnp = new System.Windows.Forms.TextBox();
            this.comboBoxclasa = new System.Windows.Forms.ComboBox();
            this.lblgen = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblzi = new System.Windows.Forms.Label();
            this.lblluna = new System.Windows.Forms.Label();
            this.lblan = new System.Windows.Forms.Label();
            this.comboBoxlitera = new System.Windows.Forms.ComboBox();
            this.lbltelefon = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.textBoxtelefon = new System.Windows.Forms.TextBox();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.gen = new System.Windows.Forms.TextBox();
            this.zi = new System.Windows.Forms.TextBox();
            this.luna = new System.Windows.Forms.TextBox();
            this.an = new System.Windows.Forms.TextBox();
            this.Verificare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnume
            // 
            this.lblnume.AutoSize = true;
            this.lblnume.Location = new System.Drawing.Point(68, 28);
            this.lblnume.Name = "lblnume";
            this.lblnume.Size = new System.Drawing.Size(43, 16);
            this.lblnume.TabIndex = 0;
            this.lblnume.Text = "Nume";
            // 
            // lblprenume
            // 
            this.lblprenume.AutoSize = true;
            this.lblprenume.Location = new System.Drawing.Point(68, 72);
            this.lblprenume.Name = "lblprenume";
            this.lblprenume.Size = new System.Drawing.Size(61, 16);
            this.lblprenume.TabIndex = 1;
            this.lblprenume.Text = "Prenume";
            // 
            // lblmama
            // 
            this.lblmama.AutoSize = true;
            this.lblmama.Location = new System.Drawing.Point(68, 116);
            this.lblmama.Name = "lblmama";
            this.lblmama.Size = new System.Drawing.Size(45, 16);
            this.lblmama.TabIndex = 2;
            this.lblmama.Text = "Mama";
            this.lblmama.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbltata
            // 
            this.lbltata.AutoSize = true;
            this.lbltata.Location = new System.Drawing.Point(314, 116);
            this.lbltata.Name = "lbltata";
            this.lbltata.Size = new System.Drawing.Size(35, 16);
            this.lbltata.TabIndex = 3;
            this.lbltata.Text = "Tata";
            // 
            // lblcnp
            // 
            this.lblcnp.AutoSize = true;
            this.lblcnp.Location = new System.Drawing.Point(68, 162);
            this.lblcnp.Name = "lblcnp";
            this.lblcnp.Size = new System.Drawing.Size(35, 16);
            this.lblcnp.TabIndex = 4;
            this.lblcnp.Text = "CNP";
            // 
            // lblclasa
            // 
            this.lblclasa.AutoSize = true;
            this.lblclasa.Location = new System.Drawing.Point(68, 218);
            this.lblclasa.Name = "lblclasa";
            this.lblclasa.Size = new System.Drawing.Size(42, 16);
            this.lblclasa.TabIndex = 5;
            this.lblclasa.Text = "Clasa";
            // 
            // textBoxnume
            // 
            this.textBoxnume.Location = new System.Drawing.Point(159, 28);
            this.textBoxnume.Name = "textBoxnume";
            this.textBoxnume.Size = new System.Drawing.Size(97, 22);
            this.textBoxnume.TabIndex = 6;
            // 
            // textBoxpren
            // 
            this.textBoxpren.Location = new System.Drawing.Point(157, 69);
            this.textBoxpren.Name = "textBoxpren";
            this.textBoxpren.Size = new System.Drawing.Size(98, 22);
            this.textBoxpren.TabIndex = 7;
            // 
            // textBoxmama
            // 
            this.textBoxmama.Location = new System.Drawing.Point(159, 113);
            this.textBoxmama.Name = "textBoxmama";
            this.textBoxmama.Size = new System.Drawing.Size(95, 22);
            this.textBoxmama.TabIndex = 8;
            // 
            // textBoxtata
            // 
            this.textBoxtata.Location = new System.Drawing.Point(369, 113);
            this.textBoxtata.Name = "textBoxtata";
            this.textBoxtata.Size = new System.Drawing.Size(96, 22);
            this.textBoxtata.TabIndex = 9;
            // 
            // textBoxcnp
            // 
            this.textBoxcnp.Location = new System.Drawing.Point(132, 162);
            this.textBoxcnp.Name = "textBoxcnp";
            this.textBoxcnp.Size = new System.Drawing.Size(136, 22);
            this.textBoxcnp.TabIndex = 10;
            // 
            // comboBoxclasa
            // 
            this.comboBoxclasa.FormattingEnabled = true;
            this.comboBoxclasa.Items.AddRange(new object[] {
            "V",
            "VI",
            "VII",
            "VIII",
            "IX",
            "X",
            "XI",
            "XII"});
            this.comboBoxclasa.Location = new System.Drawing.Point(149, 218);
            this.comboBoxclasa.Name = "comboBoxclasa";
            this.comboBoxclasa.Size = new System.Drawing.Size(104, 24);
            this.comboBoxclasa.TabIndex = 11;
            // 
            // lblgen
            // 
            this.lblgen.AutoSize = true;
            this.lblgen.Location = new System.Drawing.Point(68, 279);
            this.lblgen.Name = "lblgen";
            this.lblgen.Size = new System.Drawing.Size(32, 16);
            this.lblgen.TabIndex = 13;
            this.lblgen.Text = "Gen";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(68, 336);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(82, 16);
            this.lbldata.TabIndex = 14;
            this.lbldata.Text = "Data nasterii";
            // 
            // lblzi
            // 
            this.lblzi.AutoSize = true;
            this.lblzi.Location = new System.Drawing.Point(189, 335);
            this.lblzi.Name = "lblzi";
            this.lblzi.Size = new System.Drawing.Size(18, 16);
            this.lblzi.TabIndex = 15;
            this.lblzi.Text = "Zi";
            // 
            // lblluna
            // 
            this.lblluna.AutoSize = true;
            this.lblluna.Location = new System.Drawing.Point(313, 335);
            this.lblluna.Name = "lblluna";
            this.lblluna.Size = new System.Drawing.Size(36, 16);
            this.lblluna.TabIndex = 16;
            this.lblluna.Text = "Luna";
            // 
            // lblan
            // 
            this.lblan.AutoSize = true;
            this.lblan.Location = new System.Drawing.Point(459, 335);
            this.lblan.Name = "lblan";
            this.lblan.Size = new System.Drawing.Size(23, 16);
            this.lblan.TabIndex = 17;
            this.lblan.Text = "An";
            // 
            // comboBoxlitera
            // 
            this.comboBoxlitera.FormattingEnabled = true;
            this.comboBoxlitera.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.comboBoxlitera.Location = new System.Drawing.Point(282, 218);
            this.comboBoxlitera.Name = "comboBoxlitera";
            this.comboBoxlitera.Size = new System.Drawing.Size(86, 24);
            this.comboBoxlitera.TabIndex = 21;
            // 
            // lbltelefon
            // 
            this.lbltelefon.AutoSize = true;
            this.lbltelefon.Location = new System.Drawing.Point(73, 380);
            this.lbltelefon.Name = "lbltelefon";
            this.lbltelefon.Size = new System.Drawing.Size(53, 16);
            this.lbltelefon.TabIndex = 22;
            this.lbltelefon.Text = "Telefon";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(74, 422);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(41, 16);
            this.lblemail.TabIndex = 23;
            this.lblemail.Text = "Email";
            // 
            // textBoxtelefon
            // 
            this.textBoxtelefon.Location = new System.Drawing.Point(152, 377);
            this.textBoxtelefon.Name = "textBoxtelefon";
            this.textBoxtelefon.Size = new System.Drawing.Size(103, 22);
            this.textBoxtelefon.TabIndex = 24;
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(152, 421);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(103, 22);
            this.textBoxemail.TabIndex = 25;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(659, 406);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(115, 36);
            this.submit.TabIndex = 26;
            this.submit.Text = "SUBMIT";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(147, 279);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(121, 22);
            this.gen.TabIndex = 27;
            this.gen.TextChanged += new System.EventHandler(this.gen_TextChanged);
            // 
            // zi
            // 
            this.zi.Location = new System.Drawing.Point(223, 335);
            this.zi.Name = "zi";
            this.zi.Size = new System.Drawing.Size(70, 22);
            this.zi.TabIndex = 28;
            this.zi.TextChanged += new System.EventHandler(this.zi_TextChanged);
            // 
            // luna
            // 
            this.luna.Location = new System.Drawing.Point(360, 334);
            this.luna.Name = "luna";
            this.luna.Size = new System.Drawing.Size(81, 22);
            this.luna.TabIndex = 29;
            this.luna.TextChanged += new System.EventHandler(this.luna_TextChanged);
            // 
            // an
            // 
            this.an.Location = new System.Drawing.Point(488, 336);
            this.an.Name = "an";
            this.an.Size = new System.Drawing.Size(82, 22);
            this.an.TabIndex = 30;
            this.an.TextChanged += new System.EventHandler(this.an_TextChanged);
            // 
            // Verificare
            // 
            this.Verificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verificare.ForeColor = System.Drawing.Color.DarkGreen;
            this.Verificare.Location = new System.Drawing.Point(282, 162);
            this.Verificare.Name = "Verificare";
            this.Verificare.Size = new System.Drawing.Size(106, 23);
            this.Verificare.TabIndex = 31;
            this.Verificare.Text = "Verifica";
            this.Verificare.UseVisualStyleBackColor = true;
            this.Verificare.Click += new System.EventHandler(this.Verificare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Verificare);
            this.Controls.Add(this.an);
            this.Controls.Add(this.luna);
            this.Controls.Add(this.zi);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.textBoxtelefon);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbltelefon);
            this.Controls.Add(this.comboBoxlitera);
            this.Controls.Add(this.lblan);
            this.Controls.Add(this.lblluna);
            this.Controls.Add(this.lblzi);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblgen);
            this.Controls.Add(this.comboBoxclasa);
            this.Controls.Add(this.textBoxcnp);
            this.Controls.Add(this.textBoxtata);
            this.Controls.Add(this.textBoxmama);
            this.Controls.Add(this.textBoxpren);
            this.Controls.Add(this.textBoxnume);
            this.Controls.Add(this.lblclasa);
            this.Controls.Add(this.lblcnp);
            this.Controls.Add(this.lbltata);
            this.Controls.Add(this.lblmama);
            this.Controls.Add(this.lblprenume);
            this.Controls.Add(this.lblnume);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnume;
        private System.Windows.Forms.Label lblprenume;
        private System.Windows.Forms.Label lblmama;
        private System.Windows.Forms.Label lbltata;
        private System.Windows.Forms.Label lblcnp;
        private System.Windows.Forms.Label lblclasa;
        private System.Windows.Forms.TextBox textBoxnume;
        private System.Windows.Forms.TextBox textBoxpren;
        private System.Windows.Forms.TextBox textBoxmama;
        private System.Windows.Forms.TextBox textBoxtata;
        private System.Windows.Forms.TextBox textBoxcnp;
        private System.Windows.Forms.ComboBox comboBoxclasa;
        private System.Windows.Forms.Label lblgen;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblzi;
        private System.Windows.Forms.Label lblluna;
        private System.Windows.Forms.Label lblan;
        private System.Windows.Forms.ComboBox comboBoxlitera;
        private System.Windows.Forms.Label lbltelefon;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox textBoxtelefon;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox gen;
        private System.Windows.Forms.TextBox zi;
        private System.Windows.Forms.TextBox luna;
        private System.Windows.Forms.TextBox an;
        private System.Windows.Forms.Button Verificare;
    }
}

