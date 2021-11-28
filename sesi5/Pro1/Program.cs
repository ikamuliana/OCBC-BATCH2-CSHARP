using System;
namespace Pro1
{
    class Program
    {
        static void Main(string[] args)
        {
            // instant objek
            Laptop laptop1 = new Laptop();

            // akses atribut
            Console.Write("Nama Laptop: ");
            laptop1.merk = Console.ReadLine();
            Console.Write("RAM: ");
            laptop1.ram = int.Parse(Console.ReadLine());
            Console.Write("Memory: ");
            laptop1.memory = int.Parse(Console.ReadLine());

            // tampilan
            Console.WriteLine("Merk laptop adalah {0}", laptop1.merk);
            Console.WriteLine("Kapasitas ram ada {0}", laptop1.ram);
            Console.WriteLine("Kapasitas memory ada {0}", laptop1.memory);

            // akses method
            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();

            Console.Read();
        }
    }
}
