namespace FrAutoecole
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbEleve = new GroupBox();
            btnValiderE = new Button();
            dtpInscription = new DateTimePicker();
            lblInscription = new Label();
            txtCredit = new TextBox();
            lblCredit = new Label();
            txtPrenom = new TextBox();
            lblPrenom = new Label();
            txtNom = new TextBox();
            lblNom = new Label();
            grbVehicule = new GroupBox();
            btnValiderV = new Button();
            checkBox1 = new CheckBox();
            label8 = new Label();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            grpLecon = new GroupBox();
            btnValiderL = new Button();
            dateTimePicker3 = new DateTimePicker();
            checkBox2 = new CheckBox();
            label12 = new Label();
            label13 = new Label();
            dateTimePicker2 = new DateTimePicker();
            textBox8 = new TextBox();
            label9 = new Label();
            lblEleve = new Label();
            textBox7 = new TextBox();
            lblVehicule = new Label();
            grbEleve.SuspendLayout();
            grbVehicule.SuspendLayout();
            grpLecon.SuspendLayout();
            SuspendLayout();
            // 
            // grbEleve
            // 
            grbEleve.Controls.Add(btnValiderE);
            grbEleve.Controls.Add(dtpInscription);
            grbEleve.Controls.Add(lblInscription);
            grbEleve.Controls.Add(txtCredit);
            grbEleve.Controls.Add(lblCredit);
            grbEleve.Controls.Add(txtPrenom);
            grbEleve.Controls.Add(lblPrenom);
            grbEleve.Controls.Add(txtNom);
            grbEleve.Controls.Add(lblNom);
            grbEleve.Location = new Point(0, 0);
            grbEleve.Name = "grbEleve";
            grbEleve.Size = new Size(323, 181);
            grbEleve.TabIndex = 0;
            grbEleve.TabStop = false;
            grbEleve.Text = "Eleve";
            // 
            // btnValiderE
            // 
            btnValiderE.BackColor = SystemColors.ControlLightLight;
            btnValiderE.Location = new Point(94, 152);
            btnValiderE.Name = "btnValiderE";
            btnValiderE.Size = new Size(75, 23);
            btnValiderE.TabIndex = 8;
            btnValiderE.Text = "Valider";
            btnValiderE.UseVisualStyleBackColor = false;
            btnValiderE.Click += btnValiderE_Click;
            // 
            // dtpInscription
            // 
            dtpInscription.Location = new Point(140, 77);
            dtpInscription.Name = "dtpInscription";
            dtpInscription.Size = new Size(177, 23);
            dtpInscription.TabIndex = 7;
            // 
            // lblInscription
            // 
            lblInscription.AutoSize = true;
            lblInscription.Location = new Point(6, 77);
            lblInscription.Name = "lblInscription";
            lblInscription.Size = new Size(90, 15);
            lblInscription.TabIndex = 6;
            lblInscription.Text = "Date Inscription";
            // 
            // txtCredit
            // 
            txtCredit.Location = new Point(140, 106);
            txtCredit.Name = "txtCredit";
            txtCredit.Size = new Size(100, 23);
            txtCredit.TabIndex = 5;
            // 
            // lblCredit
            // 
            lblCredit.AutoSize = true;
            lblCredit.Location = new Point(6, 106);
            lblCredit.Name = "lblCredit";
            lblCredit.Size = new Size(39, 15);
            lblCredit.TabIndex = 4;
            lblCredit.Text = "Credit";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(140, 48);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(100, 23);
            txtPrenom.TabIndex = 3;
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(6, 48);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(49, 15);
            lblPrenom.TabIndex = 2;
            lblPrenom.Text = "Prénom";
            lblPrenom.Click += label2_Click;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(140, 19);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(100, 23);
            txtNom.TabIndex = 1;
            txtNom.TextChanged += textBox1_TextChanged;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(6, 19);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(34, 15);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom";
            // 
            // grbVehicule
            // 
            grbVehicule.Controls.Add(btnValiderV);
            grbVehicule.Controls.Add(checkBox1);
            grbVehicule.Controls.Add(label8);
            grbVehicule.Controls.Add(textBox4);
            grbVehicule.Controls.Add(textBox6);
            grbVehicule.Controls.Add(label5);
            grbVehicule.Controls.Add(label7);
            grbVehicule.Controls.Add(textBox5);
            grbVehicule.Controls.Add(label6);
            grbVehicule.Location = new Point(401, 12);
            grbVehicule.Name = "grbVehicule";
            grbVehicule.Size = new Size(340, 169);
            grbVehicule.TabIndex = 0;
            grbVehicule.TabStop = false;
            grbVehicule.Text = "Vehicule";
            // 
            // btnValiderV
            // 
            btnValiderV.BackColor = SystemColors.ControlLightLight;
            btnValiderV.Location = new Point(115, 140);
            btnValiderV.Name = "btnValiderV";
            btnValiderV.Size = new Size(75, 23);
            btnValiderV.TabIndex = 9;
            btnValiderV.Text = "Valider";
            btnValiderV.UseVisualStyleBackColor = false;
            btnValiderV.Click += btnValiderV_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(148, 117);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 16;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 117);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 15;
            label8.Text = "En Etat";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(148, 82);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 14;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(148, 19);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 82);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 13;
            label5.Text = "Couleur";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 19);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 9;
            label7.Text = "Immatriculation";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(148, 48);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 48);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 11;
            label6.Text = "Modele";
            // 
            // grpLecon
            // 
            grpLecon.Controls.Add(btnValiderL);
            grpLecon.Controls.Add(dateTimePicker3);
            grpLecon.Controls.Add(checkBox2);
            grpLecon.Controls.Add(label12);
            grpLecon.Controls.Add(label13);
            grpLecon.Controls.Add(dateTimePicker2);
            grpLecon.Controls.Add(textBox8);
            grpLecon.Controls.Add(label9);
            grpLecon.Controls.Add(lblEleve);
            grpLecon.Controls.Add(textBox7);
            grpLecon.Controls.Add(lblVehicule);
            grpLecon.Location = new Point(140, 221);
            grpLecon.Name = "grpLecon";
            grpLecon.Size = new Size(424, 205);
            grpLecon.TabIndex = 0;
            grpLecon.TabStop = false;
            grpLecon.Text = "Lecon";
            // 
            // btnValiderL
            // 
            btnValiderL.BackColor = SystemColors.ControlLightLight;
            btnValiderL.Location = new Point(114, 172);
            btnValiderL.Name = "btnValiderL";
            btnValiderL.Size = new Size(75, 23);
            btnValiderL.TabIndex = 17;
            btnValiderL.Text = "Valider";
            btnValiderL.UseVisualStyleBackColor = false;
            btnValiderL.Click += btnValiderL_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CustomFormat = "hh:mm:ss";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(147, 116);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 16;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(147, 149);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 19;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 116);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 15;
            label12.Text = "Heure";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 149);
            label13.Name = "label13";
            label13.Size = new Size(56, 15);
            label13.TabIndex = 18;
            label13.Text = "Effectuee";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(147, 80);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(177, 23);
            dateTimePicker2.TabIndex = 14;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(147, 22);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 80);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 13;
            label9.Text = "Date";
            // 
            // lblEleve
            // 
            lblEleve.AutoSize = true;
            lblEleve.Location = new Point(13, 22);
            lblEleve.Name = "lblEleve";
            lblEleve.Size = new Size(34, 15);
            lblEleve.TabIndex = 9;
            lblEleve.Text = "Eleve";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(147, 51);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 12;
            // 
            // lblVehicule
            // 
            lblVehicule.AutoSize = true;
            lblVehicule.Location = new Point(13, 51);
            lblVehicule.Name = "lblVehicule";
            lblVehicule.Size = new Size(51, 15);
            lblVehicule.TabIndex = 11;
            lblVehicule.Text = "Vehicule";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 450);
            Controls.Add(grpLecon);
            Controls.Add(grbVehicule);
            Controls.Add(grbEleve);
            Name = "FrmMenu";
            Text = "Form1";
            Load += Form1_Load;
            grbEleve.ResumeLayout(false);
            grbEleve.PerformLayout();
            grbVehicule.ResumeLayout(false);
            grbVehicule.PerformLayout();
            grpLecon.ResumeLayout(false);
            grpLecon.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbEleve;
        private GroupBox grbVehicule;
        private GroupBox grpLecon;
        private TextBox txtPrenom;
        private Label lblPrenom;
        private TextBox txtNom;
        private Label lblNom;
        private TextBox txtCredit;
        private Label lblCredit;
        private Button btnValiderE;
        private DateTimePicker dtpInscription;
        private Label lblInscription;
        private TextBox textBox4;
        private TextBox textBox6;
        private Label label5;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private Button btnValiderV;
        private CheckBox checkBox1;
        private Label label8;
        private DateTimePicker dateTimePicker3;
        private Label label12;
        private DateTimePicker dateTimePicker2;
        private TextBox textBox8;
        private Label label9;
        private Label lblEleve;
        private TextBox textBox7;
        private Label lblVehicule;
        private Button btnValiderL;
        private CheckBox checkBox2;
        private Label label13;
    }
}