using System;

namespace Pro5
{
    class Program : Override
    {
        public override void PenjumlahanPerkaliandll()
        {
            Console.WriteLine("overiding 2...");
            Console.WriteLine("Hasil pembagian angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 / bilangan2);
            Console.WriteLine("Hasil pengurangan angka {0} dan angka {1} = {2}", bilangan1, bilangan2, bilangan1 - bilangan2);
        }
        static void Main(string[] args)
        {
            int bil1, bil2;
            Console.Write("Masukkan bilangan 1: ");
            bil1 = int.Parse(Console.ReadLine());
            Console.Write("Masukkan bilangan 2: ");
            bil2 = int.Parse(Console.ReadLine());
            Override over = new Override();
            over.Bilangan(bil1, bil2);
            over.PenjumlahanPerkaliandll();
            over = new Program();
            over.Bilangan(bil1, bil2);
            over.PenjumlahanPerkaliandll();
        }
    }
}
