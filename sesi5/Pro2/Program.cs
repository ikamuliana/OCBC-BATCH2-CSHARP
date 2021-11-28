using System;

namespace Pro2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            pesawat.nama = "Garudaku";
            pesawat.ketinggian1 = "2500 kaki";

            pesawat.terbang();
            pesawat.sudahterbang();
            Console.Read();
        }
    }
}
