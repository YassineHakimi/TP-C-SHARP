using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class PrixException : Exception
    {
        public PrixException() : base("Prix invalid")
        {
            
        }

        public PrixException(string nom) : base("Le produit : " + nom + " à un Prix invalid")
        {

        }
    }
}
