using System;
using System.Collections.Generic;

class Problem1
{
    static void Main()
    {
        // 4 ogrenci adini diziye ata
        string[] dizi = { "Tarık", "Mehmet", "Fatih", "Alya" };

        // ayni isimleri liste olarak tanimladim
        List<string> liste = new List<string>();
        liste.Add("Tarık");
        liste.Add("Mehmet");
        liste.Add("Fatih");
        liste.Add("Alya");

        // dizinin elemanlarini yaz
        Console.WriteLine("Dizi elemanlari:");
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.WriteLine(dizi[i]);
        }
        Console.WriteLine("Dizideki eleman sayisi: " + dizi.Length);

        Console.WriteLine();

        // listenin elemanlarini yaz
        Console.WriteLine("Liste elemanlari:");
        for (int i = 0; i < liste.Count; i++)
        {
            Console.WriteLine(liste[i]);
        }
        Console.WriteLine("Listedeki eleman sayisi: " + liste.Count);

        Console.WriteLine();

        // kullanici ismi al
        Console.Write("Bir isim giriniz: ");
        string isim = Console.ReadLine();

        // buyuk kucuk harf duyarsiz olsun diye hepsini kucuk harfe cevirip karsilastir
        string isimKucuk = isim.ToLower();

        // dizide ara
        bool diziBulundu = false;
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i].ToLower() == isimKucuk)
            {
                diziBulundu = true;
            }
        }

        // listede ara
        bool listeBulundu = false;
        for (int i = 0; i < liste.Count; i++)
        {
            if (liste[i].ToLower() == isimKucuk)
            {
                listeBulundu = true;
            }
        }

        if (diziBulundu)
            Console.WriteLine(isim + " dizide bulundu.");
        else
            Console.WriteLine(isim + " dizide bulunamadi.");

        if (listeBulundu)
            Console.WriteLine(isim + " listede bulundu.");
        else
            Console.WriteLine(isim + " listede bulunamadi.");
    }
}
