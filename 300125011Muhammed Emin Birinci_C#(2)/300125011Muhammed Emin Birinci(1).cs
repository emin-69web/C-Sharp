using System;
using System.Collections.Generic;

class Problem1
{
    static void Main()
    {
        // 3 ogrenci numarasini saklayacak dizi
        int[] numaralar = new int[3];

        // hash tablosu icin 3 elemanli bir liste dizisi
        // her index'te birden fazla numara olabilecegi icin List kullan
        List<int>[] hashTablosu = new List<int>[3];
        for (int i = 0; i < 3; i++)
        {
            hashTablosu[i] = new List<int>();
        }

        // 3 ogrenci numarasi al
        Console.WriteLine("3 adet ogrenci numarasi giriniz:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write((i + 1) + ". numara: ");
            numaralar[i] = int.Parse(Console.ReadLine());

            // hash hesapla: key % 5
            int index = numaralar[i] % 5  ;

            // tabloya ekle
            hashTablosu[index].Add(numaralar[i]);

            Console.WriteLine(numaralar[i] + " numarasi " + index + ". index'e yerlestirildi.");
        }

        // hash tablosunun son halini yaz
        Console.WriteLine();
        Console.WriteLine("Hash tablosu:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Index " + i + ": ");
            if (hashTablosu[i].Count == 0)
            {
                Console.WriteLine("(bos)");
            }
            else
            {
                for (int j = 0; j < hashTablosu[i].Count; j++)
                {
                    Console.Write(hashTablosu[i][j]);
                    if (j < hashTablosu[i].Count - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }
        }

        // cakisma kontrolu
        // bir index'te 1'den fazla eleman varsa cakisma var
        // toplam cakisma = (o index'teki eleman sayisi - 1)
        int toplamCakisma = 0;
        int enFazlaCakismaIndex = -1;
        int enFazlaCakismaSayisi = 0;

        Console.WriteLine();
        Console.WriteLine("Cakisma durumu:");
        for (int i = 0; i < 5; i++)
        {
            if (hashTablosu[i].Count > 1)
            {
                int cakismaSayisi = hashTablosu[i].Count - 1;
                toplamCakisma = toplamCakisma + cakismaSayisi;
                Console.WriteLine("Index " + i + " 'de " + hashTablosu[i].Count + " eleman var (" + cakismaSayisi + " cakisma)");

                // en fazla cakisma olan index'i bul
                if (cakismaSayisi > enFazlaCakismaSayisi)
                {
                    enFazlaCakismaSayisi = cakismaSayisi;
                    enFazlaCakismaIndex = i;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Toplam cakisma sayisi: " + toplamCakisma);

        if (enFazlaCakismaIndex == -1)
        {
            Console.WriteLine("Hic cakisma olmadi.");
        }
        else
        {
            Console.WriteLine("En fazla cakisma olan index: " + enFazlaCakismaIndex + " (" + enFazlaCakismaSayisi + " cakisma)");
        }
    }
}
