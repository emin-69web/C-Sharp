using System;
using System.Collections.Generic;

class Problem3
{
    static void Main()
    {
        HashSet<int> kume = new HashSet<int>();

        // tekrar eden sayilari kontrol etmek icin girilenleri ayrica sakla
        //  kac tane tekrar oldugunu goster
        int eklenmeyen = 0;

        Console.WriteLine("5 adet sayi giriniz:");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(i + ". sayi: ");
            int sayi = int.Parse(Console.ReadLine());

            // HashSet.Add eger ayni eleman varsa false doner
            bool eklendi = kume.Add(sayi);
            if (!eklendi)
            {
                eklenmeyen++;
                Console.WriteLine("(" + sayi + " zaten kumede var, eklenmedi)");
            }
        }

        // tekrar eden eleman sayisini goster
        Console.WriteLine();
        Console.WriteLine("Girilen 5 sayidan " + eklenmeyen + " tanesi tekrar oldugu icin eklenmedi.");

        // kumedeki eleman sayisi
        Console.WriteLine("Kumedeki eleman sayisi: " + kume.Count);

        // kumedeki tum elemanlari yazdir
        Console.WriteLine();
        Console.WriteLine("Kumedeki elemanlar:");
        foreach (int s in kume)
        {
            Console.WriteLine(s);
        }

        // kullanicidan bir sayi al ve kumede var mi bak
        Console.Write("Kontrol etmek istediginiz bir sayi giriniz: ");
        int kontrol = int.Parse(Console.ReadLine());
        if (kume.Contains(kontrol))
        {
            Console.WriteLine(kontrol + " kumede var.");
        }
        else
        {
            Console.WriteLine(kontrol + " kumede yok.");
        }

        // en buyuk elemani bul
        // foreach 
        int enBuyuk = int.MinValue;
        foreach (int s in kume)
        {
            if (s > enBuyuk)
            {
                enBuyuk = s;
            }
        }
        Console.WriteLine("Kumedeki en buyuk eleman: " + enBuyuk);
    }
}
