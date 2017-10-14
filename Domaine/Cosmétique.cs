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
    }

    public enum TypeCos
    {
        Parfum, Shampoo, Gel
    }
}
