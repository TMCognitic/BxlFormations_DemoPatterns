using DemoMediator.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMediator.Models
{
    public class Personne
    {
        public string Nom { get; private set; }

        public Personne(string nom)
        {
            Nom = nom;
            Messager<Personne, string>.Instance.Register(Ecouter);
        }

        public void Partir()
        {
            Messager<Personne, string>.Instance.Unregister(Ecouter);
        }

        public void Parler(string message)
        {
            Messager<Personne, string>.Instance.Send(this, $"{Nom} : {message}");
        }

        public void Ecouter(Personne personne, string message)
        {
            if (personne != this)
            {
                Console.WriteLine($"{Nom} recoit le message de {message}");
            }
        }
    }
}
