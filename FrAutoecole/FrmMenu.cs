using LibAutoecole;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace FrAutoecole
{
    public partial class FrmMenu : Form
    {
        List<Eleve> lstEleve;
        List<Vehicule> lstVehicule;
        public FrmMenu()
        {
            InitializeComponent();
            lstEleve = new List<Eleve>();
            lstVehicule = new List<Vehicule>();
        }
        Lecon[] tabLecon = new Lecon[10];
        int k = 0;
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

        private void btnValiderE_Click(object sender, EventArgs e)
        {
            lstEleve.Add(new Eleve(txtNom.Text, txtPrenom.Text, dtpInscription.Value.Date, Convert.ToInt16(txtCredit.Text)));
            cmbEleve.Items.Clear();
            foreach (Eleve eleve in lstEleve)
            {
                cmbEleve.Items.Add(eleve.getNom());
            }
            txtNom.Clear();
            txtPrenom.Clear();
            txtCredit.Clear();
        }

        private void btnValiderV_Click(object sender, EventArgs e)
        {
            lstVehicule.Add(new Vehicule(txtImmat.Text, txtModel.Text, txtCouleur.Text));
            cmbVehicule.Items.Clear();
            foreach (Vehicule vehicule in lstVehicule)
            {
                cmbVehicule.Items.Add(vehicule.Getimmat());
            }
            txtImmat.Clear();
            txtModel.Clear();
            txtCouleur.Clear();
            chkEtat.Checked = false;
        }

        private void btnValiderL_Click(object sender, EventArgs e)
        {
            Eleve elv = new Eleve();
            string eleveNom = cmbEleve.SelectedItem.ToString();
            foreach (Eleve eleve in lstEleve)
            {
                if (eleve != null)
                {
                    if (eleve.getNom() == eleveNom)
                    {
                        elv = eleve;
                    }
                }
            }
            Vehicule vhc = new Vehicule();
            string vehiculeImmat = cmbVehicule.SelectedItem.ToString();
            foreach (Vehicule vehicule in lstVehicule)
            {
                if (vehicule != null)
                {
                    if (vehicule.Getimmat() == vehiculeImmat)
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
            chkEffectuer.Checked = false;
        }
    }
}