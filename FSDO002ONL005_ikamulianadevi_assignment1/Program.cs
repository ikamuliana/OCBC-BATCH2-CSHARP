using System;

namespace FSDO002ONL005_ikamulianadevi_assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilihan;
            string back = "n";

            do
            {

            Console.WriteLine("\n******* Assignment 1 *******");
            Console.WriteLine("============================");
            Console.WriteLine("Kode Peserta : FSDO002ONL005");
            Console.WriteLine("Nama Peserta : Ika Muliana Devi");
            Console.WriteLine("Alamat       : Bogor\n");

            Console.WriteLine("** Pilih Soal **");
            Console.WriteLine("1. Segitiga Alfabet");
            Console.WriteLine("2. Segitiga Angka");
            Console.WriteLine("3. Faktorial");
            Console.WriteLine("4. Balik Angka");
            Console.WriteLine("5. Converter Angka");
            Console.Write("Masukkan pilihan : ");
            pilihan = int.Parse(Console.ReadLine());

            switch (pilihan)
            {
            
                case 1:
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
                        break;
                    }

                case 2:
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
                        break;
                    }

                case 3:
                    {
                        int i, factor = 1, nomor;
                        Console.Write("Enter any Number : ");
                        nomor = int.Parse(Console.ReadLine());

                        for (i = 1; i <= nomor; i++) {
                            factor = factor * i;
                        }
                        Console.Write("Factorial of " + nomor + " is: " +factor);
                        break;
                    }

                case 4:
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
                        break;
                    }

                case 5:
                    {
                        int number, i = 0, conver ;     
                        Console.Write("Enter the Number = ");    
                        number = int.Parse(Console.ReadLine());     
                        while(number > 0)      
                        {      
                                conver = number % 10;      
                                i = i * 10 + conver;      
                                number = number / 10;      
                        }      
                        number = i;      
                        while(number > 0)      
                        {      
                                conver = number % 10;      
                                switch(conver)      
                            {      
                                case 1:      
                                Console.Write("One ");  
                                break;      
                                case 2:      
                                Console.Write("Two ");      
                                break;      
                                case 3:      
                                Console.Write("Three ");    
                                break;      
                                case 4:      
                                Console.Write("Four ");    
                                break;      
                                case 5:      
                                Console.Write("Five ");    
                                break;      
                                case 6:      
                                Console.Write("Six ");     
                                break;      
                                case 7:    
                                Console.Write("Seven ");    
                                break;    
                                case 8:      
                                Console.Write("Eight ");      
                                break;      
                                case 9:      
                                Console.Write("Nine ");    
                                break;      
                                case 0:      
                                Console.Write("Zero ");    
                                break;      
                                default:      
                                Console.Write("=====");      
                                break;      
                            }     
                            number = number / 10;      
                        } 
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Pilih list yang diinginkan ");
                        break;
                    }
            }
            Console.Write("\nApakah ingin kembali ke menu awal? (Y/N) :  ");
            back = Console.ReadLine();
        }
         while (back == "y");
        }
    }
}