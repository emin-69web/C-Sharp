using System;
using System.Collections.Generic;

class Problem3
{
    static void Main()
    {
        // 3 sehir ile baslayalim
        LinkedList<string> sehirler = new LinkedList<string>();
        sehirler.AddLast("Istanbul");
        sehirler.AddLast("Ankara");
        sehirler.AddLast("Izmir");

        Console.WriteLine("Baslangic listesi:");
        foreach (string sehir in sehirler)
        {
            Console.WriteLine(sehir);
        }

        // basa ekle
        sehirler.AddFirst("Trabzon");

        // sona ekle
        sehirler.AddLast("Konya");

        // Istanbul varsa sil
        if (sehirler.Contains("Istanbul"))
        {
            sehirler.Remove("Istanbul");
            Console.WriteLine();
            Console.WriteLine("Istanbul silindi.");
        }

        // Istanbul'dan sonra yeni sehir ekle
        // once Istanbul nodeunu bulmam lazim
        LinkedListNode<string> node = sehirler.First;
        while (node != null)
        {
            if (node.Value == "Istanbul")
            {
                sehirler.AddAfter(node, "Eskisehir");
                break;
            }
            node = node.Next;
        }

        // belirli bir elemani ara (ornek: Ankara)
        string aranan = "Ankara";
        if (sehirler.Contains(aranan))
        {
            Console.WriteLine(aranan + " listede var.");
        }
        else
        {
            Console.WriteLine(aranan + " listede yok.");
        }

        // eleman sayisi
        Console.WriteLine("Eleman sayisi: " + sehirler.Count);

        // son durum
        Console.WriteLine();
        Console.WriteLine("Son liste:");
        foreach (string s in sehirler)
        {
            Console.WriteLine(s);
        }

        // ilk ve son eleman
        Console.WriteLine();
        Console.WriteLine("Ilk eleman: " + sehirler.First.Value);
        Console.WriteLine("Son eleman: " + sehirler.Last.Value);
    }
}
