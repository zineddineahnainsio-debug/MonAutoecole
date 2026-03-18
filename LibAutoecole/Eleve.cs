namespace LibAutoecole
{
    public class Eleve
    {
        private string _nom;
        private string _prenom;
        private DateTime _dateinscription;
        public int _credit;
        public Eleve(string nom,string prenom,DateTime dateinscription,int credit)
        {
            this._nom = nom;
            this._prenom = prenom;
            this._dateinscription = dateinscription;
            this._credit = credit;
        }
        public Eleve()
        {

        }
        public string getNom()
        {
            return _nom; 
        }
        public override string ToString()
        {
            return $"{_nom} {_prenom} {_dateinscription} {_credit}";

        }


    }
}
