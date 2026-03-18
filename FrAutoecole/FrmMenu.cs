using LibAutoecole;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace FrAutoecole
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
        }
        Eleve[] tabEleve = new Eleve[10];
        int i = 0;
        private void btnValiderE_Click(object sender, EventArgs e)
        {
            tabEleve[i] = new Eleve(txtNom.Text, txtPrenom.Text, dtpInscription.Value.Date, Convert.ToInt32(txtCredit.Text));
            i++;
            if (i == tabEleve.Length)
            {
                MessageBox.Show("Le tableau est plein");
            }
            txtNom.Clear();
            txtPrenom.Clear();
            txtCredit.Clear();
        }

        private void btnValiderV_Click(object sender, EventArgs e)
        {

        }

        private void btnValiderL_Click(object sender, EventArgs e)
        {
            Eleve elv = new Eleve(txtNom.Text, txtPrenom.Text, dtpInscription.Value.Date, Convert.ToInt32(txtCredit.Text));
            /*foreach (Eleve eleve in tabEleve)
            {
                if (eleve != null)
                {
                    if (eleve.getNom() == txtCreditEleve.Text)
                    {
                        elv = eleve;
                    }
                }
            }
            tabLecon[i] = new Lecon(dtpLecon.Value,dtpHeure.Value,chkEffectuer.Checked);*/
        }
    }
}