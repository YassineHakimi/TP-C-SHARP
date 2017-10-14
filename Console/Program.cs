using Domaine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Console.Services;


namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Superette s = new Superette
            {
                Id = 1,
                Adresse = "Ghazela",
                Nom = "Chez Souhail",
                NumTel = "007",
                Logo = new Logo
                {
                    Image = "img1",
                    Description = "description"
                }
            };

            Alimentaire a1 = new Alimentaire
            {
                Id = 1,
                Marque = "Délice",
                Nom = "Lait",
                Prix = 35,
                Logo = new Logo
                {
                    Image = "lait1",
                    Description = "lait"
                },
                DateExp = DateTime.Now
            };

            Alimentaire a2 = new Alimentaire
            {
                Id = 2,
                Marque = "Délice",
                Nom = "Délio",
                Prix = 67,
                Logo = new Logo
                {
                    Image = "lait1",
                    Description = "lait"
                },
                DateExp = DateTime.Now
            };

            Alimentaire a3 = new Alimentaire
            {
                Id = 3,
                Marque = "Délice",
                Nom = "Yaourt",
                Prix = 88,
                Logo = new Logo
                {
                    Image = "lait1",
                    Description = "lait"
                },
                DateExp = DateTime.Now
            };

            Cosmétique c1 = new Cosmétique
            {
                Id = 5,
                Marque = "c1",
                Nom = "c1",
                Prix = 300,
                Type = TypeCos.Parfum,
                Logo = new Logo
                {
                    Image = "c1",
                    Description = "c1"
                }
            };

            s.Produits.Add(a1);
            s.Produits.Add(a2);
            s.Produits.Add(a3);
            s.Produits.Add(c1);

            Service services = new Service();
            System.Console.WriteLine(services.GetParfum(s));

            var res = services.GetProduitsByPrice(s);
            foreach (var p in res)
            {
                System.Console.WriteLine(p.Nom);
            }

            System.Console.ReadKey();
        }
    }
}
