using Domaine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Produit p = new Produit
            {
                Id = 1,
                Nom = "Lait",
                Marque = "Délice",
                Prix = 1.10f
            };

            Alimentaire a = new Alimentaire
            {
                Id = 2,
                Nom = "Souhail",
                Marque = "Human ?!",
                Prix = 0.0f,
                DateExp = DateTime.Now
            };

            Cosmétique x = new Cosmétique
            {
                Id = 3,
                Nom = "sqdsdsq",
                Marque = "qsdqsdqsdqsd",
                Prix = 3f,
                Type = Domaine.TypeCos.Type1
            };

            List<Produit> products = new List<Produit> { p, a };

            Superette sup = new Superette
            {
                Id = 1,
                Nom = "Chez Souhail",
                Adresse = "Bizerte",
                NumTel = "007",
                Produits = products
            };

            Superette sup2 = new Superette
            {
                Id = 2,
                Nom = "Chez sousou",
                Adresse = "ok",
                NumTel = "007",
                Produits = sup.Produits
            };

            


            System.Console.WriteLine(a.Id + " " + a.Nom + " ");

            System.Console.WriteLine(sup2.Produits.Count);

            System.Console.ReadKey();

            //Logo logo = new Logo { Image = "Kalb", Description = "qsjdqsdjqd" };
        }
    }
}
