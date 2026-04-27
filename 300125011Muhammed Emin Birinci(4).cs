using System;
using System.Collections.Generic;

class Problem4
{
    static void Main()
    {
        Stack<int> yigin = new Stack<int>();

        // 3 sayi al ve yigina at
        Console.WriteLine("3 adet tam sayi giriniz:");
        for (int i = 1; i <= 3; i++)
        {
            Console.Write(i + ". sayi: ");
            int sayi = int.Parse(Console.ReadLine());
            yigin.Push(sayi);
        }

        // ters sirada yazdir 
        // foreach Stack icin zaten en ustteki elemandan baslar
        Console.WriteLine();
        Console.WriteLine("Sayilar ters sirada:");
        foreach (int s in yigin)
        {
            Console.WriteLine(s);
        }

        // peek 
        Console.WriteLine();
        Console.WriteLine("En ustteki eleman: " + yigin.Peek());

        // pop r
        int cikarilan = yigin.Pop();
        Console.WriteLine("Cikarilan eleman: " + cikarilan);

        // pop sonrasi yigin
        Console.WriteLine();
        Console.WriteLine("Pop sonrasi yigin:");
        foreach (int s in yigin)
        {
            Console.WriteLine(s);
        }

        // bos mu?
        if (yigin.Count == 0)
        {
            Console.WriteLine("Yigin bos.");
        }
        else
        {
            Console.WriteLine("Yigin bos degil.");
        }

        // eleman sayisi
        Console.WriteLine("Yigindaki eleman sayisi: " + yigin.Count);

        // yapiyi bozmadan yazdir 
        Console.WriteLine();
        Console.WriteLine("Yigindaki elemanlar (yapi bozulmadan):");
        foreach (int s in yigin)
        {
            Console.WriteLine(s);
        }
    }
}