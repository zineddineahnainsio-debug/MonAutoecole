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
        Vehicule[] tabVehicule = new Vehicule[10];
        Lecon[] tabLecon = new Lecon[10];
        int i = 0;
        int j = 0;
        int k = 0;
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
            tabVehicule[j] = new Vehicule(txtImmat.Text, txtModel.Text, txtCouleur.Text);
            j++;
            if (j == tabVehicule.Length)
            {
                MessageBox.Show("Le tableau est plein");
            }
            txtImmat.Clear();
            txtModel.Clear();
            txtCouleur.Clear();
            chkEtat.Checked = false;
        }

        private void btnValiderL_Click(object sender, EventArgs e)
        {
            Eleve elv = new Eleve();
            foreach (Eleve eleve in tabEleve)
            {
                if (eleve != null)
                {
                    if (eleve.getNom() == txtEleve.Text)
                    {
                        elv = eleve;
                    }
                }
            }
            Vehicule vhc = new Vehicule();
            foreach (Vehicule vehicule in tabVehicule)
            {
                if (vehicule != null)
                {
                    if (vehicule.Getimmat() == txtVehicule.Text)
                    {
                        vhc = vehicule;
                    }
                }
            }
            tabLecon[k] = new Lecon(dtpLecon.Value, dtpHeure.Value, chkEffectuer.Checked, elv, vhc);
            k++;
            if (k == tabLecon.Length)
            {
                MessageBox.Show("Le tableau est plein");
            }
            txtEleve.Clear();
            txtVehicule.Clear();
            chkEffectuer.Checked = false;
        }
    }
}