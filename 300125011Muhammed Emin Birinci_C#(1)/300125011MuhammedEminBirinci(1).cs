using System;
using System.Collections.Generic;

class Problem1
{
    static void Main()
    {
        // FIFO mantigi 
        Queue<string> kuyruk = new Queue<string>();

        // 3 musteri adini kullanicidan al
        Console.WriteLine("3 adet musteri adi giriniz:");
        for (int i = 1; i <= 3; i++)
        {
            Console.Write(i + ". musteri: ");
            string isim = Console.ReadLine();
            kuyruk.Enqueue(isim); // kuyruga ekle
        }

        // ilk musteri 
        Console.WriteLine();
        Console.WriteLine("Kuyruktaki ilk musteri: " + kuyruk.Peek());

        // bir musteriyi kuyruktan cikar 
        string cikan = kuyruk.Dequeue();
        Console.WriteLine("Kuyruktan cikarilan musteri: " + cikan);

        // yeni musteri ekle
        Console.Write("Yeni musteri adi giriniz: ");
        string yeniMusteri = Console.ReadLine();
        kuyruk.Enqueue(yeniMusteri);

        // guncel kuyrugu yaz
        Console.WriteLine();
        Console.WriteLine("Guncel kuyruk:");
        int sira = 1;
        foreach (string m in kuyruk)
        {
            Console.WriteLine(sira + ". " + m);
            sira++;
        }

        // bos mu kontrol et
        if (kuyruk.Count == 0)
        {
            Console.WriteLine("Kuyruk bos.");
        }
        else
        {
            Console.WriteLine("Kuyruk bos degil.");
        }

        // eleman sayisi
        Console.WriteLine("Kuyruktaki eleman sayisi: " + kuyruk.Count);
    }
}
