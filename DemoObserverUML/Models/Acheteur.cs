using DemoObserver.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.Models
{
    public class Acheteur : Observer
    {
        public string Nom { get; private set; }

        public Acheteur(string nom)
        {
            Nom = nom;
        }

        public override void Update(Subject subject)
        {
            Produit p = subject as Produit;

            if (p != null)
            {
                Console.WriteLine($"{Nom} est notifié du changement de prix du produit '{p.Nom}' : {p.Prix}");
            }
        }
    }
}
