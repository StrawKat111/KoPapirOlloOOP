using System;

namespace KoPapirOlloOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kpo kpo2 = new Kpo();
            kpo2.SetTip1("Olló");
            kpo2.SetTip2("Kő");
            kpo2.SetEredmény();
            Console.WriteLine(kpo2.GetEredmény());
        }
    }
}