using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAutoecole
{
    public class AutoEcole
    {
        private string _nom;
        private Lecon mesLecons;
        public AutoEcole(string nom,Lecon lecons) 
        {
            this._nom = nom;
            this.mesLecons = lecons;
        }
        public Lecon GetmesLecons() 
        {
            return mesLecons;
        }
    }
}
