using System;

class soal3
{
    static void Main (string[] args)
    {
        int i, factor = 1, nomor;
        Console.Write("Enter any Number : ");
        nomor = int.Parse(Console.ReadLine());

        for (i = 1; i <= nomor; i++) {
            factor = factor * i;
        }
        Console.Write("Factorial of " + nomor + " is: " +factor);
    }
}