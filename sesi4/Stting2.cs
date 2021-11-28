using System;
using System.Globalization;

class Stting2 {

    static void Main() {
        string str1 = "Untuk pemrograman .NET, C#, adalah #1.";
        string str2 = "Untuk pemrograman .NET, C#, adalah #1.";
        string str3 = "String C# sangat tangguh";
        string strAtas, strBawah;
        int hasil, idx;

        Console.WriteLine("srt1 : " + str1);
        Console.WriteLine("Panjang str1 : " + str1.Length);

        // Menciptakan versi huruf besar/kecil dari str1
        strBawah = str1.ToLower(CultureInfo.CurrentCulture);
        strAtas = str1.ToUpper(CultureInfo.CurrentCulture);
        Console.WriteLine("Versi huruf kecil dari srt1:\n " + strBawah);
        Console.WriteLine("Versi huruf besar dari srt1:\n " + strAtas);
        Console.WriteLine();

        // Menampilkan str1, karakter demi karakter.
        Console.WriteLine("Menampilkan str1, char demi char.");
        for (int i = 0; i < str1.Length; i++)
        Console.Write(str1[i]);
        Console.WriteLine("\n");

        // Membandingkan string menggunakan == dan !=. Perbandingan ordinal.
        if (str1 == str2)
        Console.WriteLine("str1 == str2");
        else
        Console.WriteLine("str1 != str2");

        if (str1 == str3)
        Console.WriteLine("str1 == str3");
        else
        Console.WriteLine("str1 != str3");

        // Perbandingan ini sensitif-kultur
        hasil = string.Compare(str1, str3, StringComparison.CurrentCulture);
        if (hasil == 0)
        Console.WriteLine("str1 dan str3 sama");
        else if (hasil < 0)
        Console.WriteLine("str1 kurang dari str3");
        else
        Console.WriteLine("str1 lebih besar dari str3");

        Console.WriteLine();

        // Menugaskan string baru ke srt2 
        str2 = "Satu Dua Tiga Satu";

        // Pencarian string
        idx = str2.IndexOf("Satu", StringComparison.Ordinal);
        Console.WriteLine("Indeks kemunculan pertama dari satu : " + idx);
        
        idx = str2.LastIndexOf("Satu", StringComparison.Ordinal);
        Console.WriteLine("Indeks kemunculan terakhir dari satu : " + idx);
    }
}