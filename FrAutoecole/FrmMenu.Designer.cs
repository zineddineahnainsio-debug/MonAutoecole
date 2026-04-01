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
            chkEtat = new CheckBox();
            label8 = new Label();
            txtCouleur = new TextBox();
            txtImmat = new TextBox();
            label5 = new Label();
            label7 = new Label();
            txtModel = new TextBox();
            label6 = new Label();
            grpLecon = new GroupBox();
            cmbVehicule = new ComboBox();
            cmbEleve = new ComboBox();
            dtpHeure = new DateTimePicker();
            btnValiderL = new Button();
            chkEffectuer = new CheckBox();
            label12 = new Label();
            label13 = new Label();
            dtpLecon = new DateTimePicker();
            label9 = new Label();
            lblEleve = new Label();
            lblVehicule = new Label();
            grpAutoEcole = new GroupBox();
            btnValiderA = new Button();
            cmbEleveA = new ComboBox();
            txtNomA = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lstLecons = new ListBox();
            grbEleve.SuspendLayout();
            grbVehicule.SuspendLayout();
            grpLecon.SuspendLayout();
            grpAutoEcole.SuspendLayout();
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
            grbVehicule.Controls.Add(chkEtat);
            grbVehicule.Controls.Add(label8);
            grbVehicule.Controls.Add(txtCouleur);
            grbVehicule.Controls.Add(txtImmat);
            grbVehicule.Controls.Add(label5);
            grbVehicule.Controls.Add(label7);
            grbVehicule.Controls.Add(txtModel);
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
            // chkEtat
            // 
            chkEtat.AutoSize = true;
            chkEtat.Location = new Point(148, 117);
            chkEtat.Name = "chkEtat";
            chkEtat.Size = new Size(15, 14);
            chkEtat.TabIndex = 16;
            chkEtat.UseVisualStyleBackColor = true;
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
            // txtCouleur
            // 
            txtCouleur.Location = new Point(148, 82);
            txtCouleur.Name = "txtCouleur";
            txtCouleur.Size = new Size(100, 23);
            txtCouleur.TabIndex = 14;
            txtCouleur.TextChanged += textBox4_TextChanged;
            // 
            // txtImmat
            // 
            txtImmat.Location = new Point(148, 19);
            txtImmat.Name = "txtImmat";
            txtImmat.Size = new Size(100, 23);
            txtImmat.TabIndex = 10;
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
            // txtModel
            // 
            txtModel.Location = new Point(148, 48);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 12;
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
            grpLecon.Controls.Add(cmbVehicule);
            grpLecon.Controls.Add(cmbEleve);
            grpLecon.Controls.Add(dtpHeure);
            grpLecon.Controls.Add(btnValiderL);
            grpLecon.Controls.Add(chkEffectuer);
            grpLecon.Controls.Add(label12);
            grpLecon.Controls.Add(label13);
            grpLecon.Controls.Add(dtpLecon);
            grpLecon.Controls.Add(label9);
            grpLecon.Controls.Add(lblEleve);
            grpLecon.Controls.Add(lblVehicule);
            grpLecon.Location = new Point(140, 221);
            grpLecon.Name = "grpLecon";
            grpLecon.Size = new Size(424, 205);
            grpLecon.TabIndex = 0;
            grpLecon.TabStop = false;
            grpLecon.Text = "Lecon";
            // 
            // cmbVehicule
            // 
            cmbVehicule.FormattingEnabled = true;
            cmbVehicule.Location = new Point(147, 51);
            cmbVehicule.Name = "cmbVehicule";
            cmbVehicule.Size = new Size(100, 23);
            cmbVehicule.TabIndex = 21;
            // 
            // cmbEleve
            // 
            cmbEleve.FormattingEnabled = true;
            cmbEleve.Location = new Point(147, 19);
            cmbEleve.Name = "cmbEleve";
            cmbEleve.Size = new Size(100, 23);
            cmbEleve.TabIndex = 9;
            // 
            // dtpHeure
            // 
            dtpHeure.CustomFormat = "hh:mm:ss";
            dtpHeure.Format = DateTimePickerFormat.Time;
            dtpHeure.Location = new Point(147, 116);
            dtpHeure.Name = "dtpHeure";
            dtpHeure.ShowUpDown = true;
            dtpHeure.Size = new Size(177, 23);
            dtpHeure.TabIndex = 20;
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
            // chkEffectuer
            // 
            chkEffectuer.AutoSize = true;
            chkEffectuer.Location = new Point(147, 149);
            chkEffectuer.Name = "chkEffectuer";
            chkEffectuer.Size = new Size(15, 14);
            chkEffectuer.TabIndex = 19;
            chkEffectuer.UseVisualStyleBackColor = true;
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
            // dtpLecon
            // 
            dtpLecon.Location = new Point(147, 80);
            dtpLecon.Name = "dtpLecon";
            dtpLecon.Size = new Size(177, 23);
            dtpLecon.TabIndex = 14;
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
            // lblVehicule
            // 
            lblVehicule.AutoSize = true;
            lblVehicule.Location = new Point(13, 51);
            lblVehicule.Name = "lblVehicule";
            lblVehicule.Size = new Size(51, 15);
            lblVehicule.TabIndex = 11;
            lblVehicule.Text = "Vehicule";
            // 
            // grpAutoEcole
            // 
            grpAutoEcole.Controls.Add(btnValiderA);
            grpAutoEcole.Controls.Add(cmbEleveA);
            grpAutoEcole.Controls.Add(txtNomA);
            grpAutoEcole.Controls.Add(label2);
            grpAutoEcole.Controls.Add(label1);
            grpAutoEcole.Location = new Point(129, 450);
            grpAutoEcole.Name = "grpAutoEcole";
            grpAutoEcole.Size = new Size(228, 221);
            grpAutoEcole.TabIndex = 9;
            grpAutoEcole.TabStop = false;
            grpAutoEcole.Text = "AutoEcole";
            grpAutoEcole.Enter += grpAutoEcole_Enter;
            // 
            // btnValiderA
            // 
            btnValiderA.BackColor = SystemColors.ControlLightLight;
            btnValiderA.Location = new Point(63, 101);
            btnValiderA.Name = "btnValiderA";
            btnValiderA.Size = new Size(75, 23);
            btnValiderA.TabIndex = 10;
            btnValiderA.Text = "Valider";
            btnValiderA.UseVisualStyleBackColor = false;
            btnValiderA.Click += btnValiderA_Click;
            // 
            // cmbEleveA
            // 
            cmbEleveA.FormattingEnabled = true;
            cmbEleveA.Items.AddRange(new object[] { "2", "5" });
            cmbEleveA.Location = new Point(63, 61);
            cmbEleveA.Name = "cmbEleveA";
            cmbEleveA.Size = new Size(100, 23);
            cmbEleveA.TabIndex = 22;
            cmbEleveA.SelectedIndexChanged += cmbEleveA_SelectedIndexChanged;
            // 
            // txtNomA
            // 
            txtNomA.Location = new Point(63, 28);
            txtNomA.Name = "txtNomA";
            txtNomA.Size = new Size(100, 23);
            txtNomA.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 22;
            label2.Text = "Eleve";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // lstLecons
            // 
            lstLecons.FormattingEnabled = true;
            lstLecons.ItemHeight = 15;
            lstLecons.Location = new Point(166, 580);
            lstLecons.Name = "lstLecons";
            lstLecons.Size = new Size(136, 79);
            lstLecons.TabIndex = 10;
            lstLecons.SelectedIndexChanged += lstLecons_SelectedIndexChanged;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 718);
            Controls.Add(lstLecons);
            Controls.Add(grpAutoEcole);
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
            grpAutoEcole.ResumeLayout(false);
            grpAutoEcole.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbEleve;
        private GroupBox grbVehicule;
        private GroupBox grpLecon;
        private TextBox txtPrenom;
        private Label lblPrenom;
        private Label lblNom;
        private TextBox txtCredit;
        private Label lblCredit;
        private Button btnValiderE;
        private DateTimePicker dtpInscription;
        private Label lblInscription;
        private TextBox txtCouleur;
        private TextBox txtImmat;
        private Label label5;
        private Label label7;
        private TextBox txtModel;
        private Label label6;
        private Button btnValiderV;
        private CheckBox chkEtat;
        private Label label8;
        private Label label12;
        private DateTimePicker dtpLecon;
        private Label label9;
        private Label lblEleve;
        private Label lblVehicule;
        private Button btnValiderL;
        private CheckBox chkEffectuer;
        private Label label13;
        private DateTimePicker dtpHeure;
        private TextBox txtNom;
        private ComboBox cmbEleve;
        private ComboBox cmbVehicule;
        private GroupBox grpAutoEcole;
        private Label label1;
        private ComboBox cmbEleveA;
        private TextBox txtNomA;
        private Label label2;
        private Button btnValiderA;
        private ListBox lstLecons;
    }
}