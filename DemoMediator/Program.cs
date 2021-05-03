using DemoMediator.Models;
using System;

namespace DemoMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne karim = new Personne("Karim");
            Personne aurelie = new Personne("Aurélie");
            Personne loic = new Personne("Loïc");

            loic.Parler("Bonjour");
            aurelie.Parler("Salut!");
            karim.Parler("Hey vous deux!!!");
        }
    }
}
