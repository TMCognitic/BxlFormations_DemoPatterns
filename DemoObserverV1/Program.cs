using DemoObserver.Models;
using DemoObserver.ObserverPattern;
using System;

namespace DemoObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Produit cecemel = new Produit("Cecemel");
            Produit milkaLeo = new Produit("Leo (Milka)");

            IObserver thierry = new Acheteur("Thierry");
            IObserver romain = new Acheteur("Romain");

            cecemel.Attach(thierry);
            milkaLeo.Attach(thierry);
            milkaLeo.Attach(romain);

            cecemel.Prix = 1.20;
            Console.WriteLine();
            milkaLeo.Prix = .70;
        }
    }
}
