using System;
using System.Collections.Generic;

class Problem4
{
    static void Main()
    {
        // ogrenci numarasi 
        Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
        ogrenciler.Add(101, "Orhan");
        ogrenciler.Add(102, "Mahmut");
        ogrenciler.Add(103, "Ayla");
        ogrenciler.Add(104, "Eren");

        // belirli bir numaraya ait ismi yaz
        int aranan = 102;
        if (ogrenciler.ContainsKey(aranan))
        {
            Console.WriteLine(aranan + " numarali ogrenci: " + ogrenciler[aranan]);
        }
        else
        {
            Console.WriteLine(aranan + " numarali ogrenci bulunamadi.");
        }

        // yeni ogrenci ekle
        ogrenciler.Add(106, "Zeynep");
        Console.WriteLine();
        Console.WriteLine("Yeni ogrenci eklendi: 106 - Zeynep");

        //  olan bir ogrenciyi sil
        if (ogrenciler.ContainsKey(102))
        {
            ogrenciler.Remove(102);
            Console.WriteLine("102 numarali ogrenci silindi.");
        }

        // tum ogrencileri yaz
        Console.WriteLine();
        Console.WriteLine("Tum ogrenciler:");
        foreach (KeyValuePair<int, string> ogr in ogrenciler)
        {
            Console.WriteLine(ogr.Key + " - " + ogr.Value);
        }

        // belirli bir anahtar var mi kontrol et
        int kontrol = 104;
        if (ogrenciler.ContainsKey(kontrol))
        {
            Console.WriteLine();
            Console.WriteLine(kontrol + " numarasi sozlukte var.");
        }
        else
        {
            Console.WriteLine(kontrol + " numarasi sozlukte yok.");
        }

        // tum anahtarlari ayri yazdir
        Console.WriteLine();
        Console.WriteLine("Tum ogrenci numaralari:");
        foreach (int numara in ogrenciler.Keys)
        {
            Console.WriteLine(numara);
        }
    }
}
