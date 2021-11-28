using System;

class soal2
{
    public static void Main(string[] args)
    {
        int batasan = 0;
        Console.Write("Enter the range : ");
        batasan = int.Parse(Console.ReadLine());

        int angka = 1;
        int i, j, k, l;
        for (i = 1; i <= batasan; i++)
        {
            for (j = 1; j <= batasan - i; j++)
            {
                Console.Write(" ");
            }
            for (k = 1; k <= i; k++)
            {
                Console.Write(angka++);
            }
            angka--;
            for (l = 1; l < i; l++)
            {
                Console.Write(--angka);
            }
            Console.WriteLine(" ");
        }
    }
}