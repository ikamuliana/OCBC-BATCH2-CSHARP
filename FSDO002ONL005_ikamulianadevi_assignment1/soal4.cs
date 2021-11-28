using System;

class soal4
{
     public static void Main()
    {
        int  i, balik, angka = 0;
        Console.Write("Enter a number: ");      
        i= int.Parse(Console.ReadLine());

        while(i>0)      
        {      
            balik = i % 10;        
            angka = angka * 10 + balik;      
            i/=10;      
        }      
       Console.Write("Reversed Number: "+angka);       
    }
}