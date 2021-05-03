using System;

namespace DemoSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            Console.WriteLine(ReferenceEquals(singleton, singleton2));
        }
    }

    class Singleton
    {
        private static Singleton _instance;

        internal static Singleton Instance
        {
            get
            {
                return _instance ?? (_instance = new Singleton());
            }
        }

        private Singleton()
        {

        }
    }
}
