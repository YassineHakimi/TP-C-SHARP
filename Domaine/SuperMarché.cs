using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    public class Superette
    {
        public int Id { get; set; }
        public string Adresse { get; set; }
        public string Nom { get; set; }
        public string NumTel { get; set; }
        public ICollection<Produit> Produits { get; set; }
        public Logo Logo { get; set; }  
    }
}
