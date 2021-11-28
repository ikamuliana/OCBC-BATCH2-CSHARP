using System;

class soal5
{
     public static void Main()
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
    }
}