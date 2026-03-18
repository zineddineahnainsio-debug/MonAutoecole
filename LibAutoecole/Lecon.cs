
namespace LibAutoecole
{
    public class Lecon
    {
        private DateTime _datelecon;
        private DateTime _heurelecon;
        private bool _effectuee;
        private Eleve elv;
        private Vehicule vhc;
        public Lecon(DateTime datelecon, DateTime heurelecon, bool effectuee,Eleve v,Vehicule vehicule)
        {
            this._datelecon = datelecon;
            this._heurelecon = heurelecon;
            this._effectuee = effectuee;
            this.elv = v;
            this.vhc = vehicule;
        }
        public Eleve setEleve(string nom, string prenom, DateTime dateinscription, int credit)
        {
            elv = new Eleve(nom,prenom, dateinscription, credit);
            return elv;
        }
        public Vehicule setVehicule(string immat, string modele, string couleur)
        {
            vhc = new Vehicule(immat,modele,couleur);
            return vhc;
        }
        public override string ToString()
        {
            return $"{_datelecon} {_heurelecon} {_effectuee} {elv} {vhc}";
        }
    }
}
