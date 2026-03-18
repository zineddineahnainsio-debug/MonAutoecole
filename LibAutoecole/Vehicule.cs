namespace LibAutoecole
{
	public class Vehicule
		{
			private string _immat;
			private string _modele;
			private string _couleur;
			private bool _enEtat;
			public Vehicule() { }
			public Vehicule(string immat,string modele,string couleur)
			{
				this._immat = immat;
				this._modele = modele;
				this._couleur = couleur;
				this._enEtat = true;
			}
			public string Getimmat()
			{
				return _immat;
			}
			public override string ToString()
			{
				return $"{_immat} {_modele} {_couleur} {_enEtat}";
			}
			}
		}



    