using System;

class soal1 
{
    public static void Main(string[] args)
    {
        int batasan = 0;
        Console.Write("Masukkan batasan angka : ");
        batasan = int.Parse(Console.ReadLine());

        char huruf = 'A';
        int i, j, k, l;
        for (i = 1; i <= batasan; i++)
        {
            for (j = 1; j <= batasan - i; j++)
            {
                Console.Write(" ");
            }
            for (k = 1; k <= i; k++)
            {
                Console.Write(huruf++);
            }
            huruf--;
            for (l = 1; l < i; l++)
            {
                Console.Write(--huruf);
            }
            Console.WriteLine(" ");
        }
    }
}