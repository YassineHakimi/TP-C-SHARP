using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Cosmétique : Produit
    {
        public TypeCos Type { get; set; }

        // Override nécessaire pour redéfinir les méthodes
        // Virtual => La redéfinition est optionelle
        // Abstract => obligatoire
        public override string Afficher()
        {
            return "Le produit cosmétique " + Nom +
                " peut être de type : " + Type;
        }
    }

    public enum TypeCos
    {
        Parfum, Shampoo, Gel
    }
}
