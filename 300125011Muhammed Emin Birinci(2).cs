using System;
using System.Collections.Generic;

class Problem2
{
    static void Main()
    {
        int[] sayilar = new int[5];

        // 5 sayi al
        Console.WriteLine("5 adet tam sayi giriniz:");
        for (int i = 0; i < 5 ; i++)
        {
            Console.Write((i + 1) + ". sayi: ");
            sayilar[i] = int.Parse(Console.ReadLine());
        }

        // tekrar edenleri almamak icin yeni bir liste
        // listeye sadece daha once gormedigin sayilari ekle
        List<int> benzersiz = new List<int>();

        // baslangic degerleri
        int enBuyuk = int.MinValue;
        int ikinciBuyuk = int.MinValue;
        int enKucuk = int.MaxValue;
        int tekSayi = 0;
        int ciftSayi = 0;
        int toplam = 0;

        // dongu icinde her seyi yap
        for (int i = 0; i < sayilar.Length; i++)
        {
            int s = sayilar[i];

            // bu sayi daha once eklendi mi kontrol et
            if (benzersiz.Contains(s))
            {
                continue; // tekrar varsa atla
            }
            benzersiz.Add(s);

            // toplama ekle
            toplam = toplam + s;

            // tek mi cift mi
            if (s % 2 == 0)
            {
                ciftSayi++;
            }
            else
            {
                tekSayi++;
            }

            // en buyuk ve ikinci en buyuk
            if (s > enBuyuk)
            {
                ikinciBuyuk = enBuyuk;
                enBuyuk = s;
            }
            else if (s > ikinciBuyuk)
            {
                ikinciBuyuk = s;
            }

            // en kucuk
            if (s < enKucuk)
            {
                enKucuk = s;
            }
        }

        // sonuclari yaz
        Console.WriteLine();
        Console.WriteLine("Sonuclar:");
        Console.WriteLine("En buyuk sayi: " + enBuyuk);
        Console.WriteLine("En kucuk sayi: " + enKucuk);
        Console.WriteLine("Ikinci en buyuk sayi: " + ikinciBuyuk);
        Console.WriteLine("Tek sayi adedi: " + tekSayi);
        Console.WriteLine("Cift sayi adedi: " + ciftSayi);
        Console.WriteLine("Toplam: " + toplam);
    }
}
