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

            Acheteur thierry = new Acheteur("Thierry");
            Acheteur romain = new Acheteur("Romain");

            cecemel.Attach(thierry.Update);
            milkaLeo.Attach(thierry.Update);
            milkaLeo.Attach(romain.Update);

            cecemel.Prix = 1.20;
            Console.WriteLine();
            milkaLeo.Prix = .70;
        }
    }
}
