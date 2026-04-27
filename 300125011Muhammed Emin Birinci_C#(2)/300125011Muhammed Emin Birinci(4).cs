using System;
using System.Collections.Generic;

class Problem4
{
    static void Main()
    {
        // cizgeyi komsuluk listesi  ile tut
        // her dugum bir key, komsulari da liste olarak value
        // ornek cizge:
        //     1 --- 2
        //     |     |
        //     3 --- 4
        //     |
        //     5
        Dictionary<int, List<int>> cizge = new Dictionary<int, List<int>>();

        cizge.Add(1, new List<int>());
        cizge.Add(2, new List<int>());
        cizge.Add(3, new List<int>());
        cizge.Add(4, new List<int>());
        cizge.Add(5, new List<int>());

        // kenarlari ekliyorum (yonsuz oldugu icin iki tarafa da)
        cizge[1].Add(2); cizge[2].Add(1);
        cizge[1].Add(3); cizge[3].Add(1);
        cizge[2].Add(4); cizge[4].Add(2);
        cizge[3].Add(4); cizge[4].Add(3);
        cizge[3].Add(5); cizge[5].Add(3);

        // her dugumun komsularini yaz
        Console.WriteLine("Dugum komsuluklari:");
        foreach (KeyValuePair<int, List<int>> dugum in cizge)
        {
            Console.Write("Dugum " + dugum.Key + " komsulari: ");
            for (int i = 0; i < dugum.Value.Count; i++)
            {
                Console.Write(dugum.Value[i]);
                if (i < dugum.Value.Count - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }

        // belirli bir dugumun komsu sayisi
        int hedef = 3;
        Console.WriteLine();
        Console.WriteLine("Dugum " + hedef + " 'un komsu sayisi: " + cizge[hedef].Count);

        // BFS 
        // kuyruk kullanarak tum dugumleri dolas
        Console.WriteLine();
        Console.WriteLine("BFS dolasma (1. dugumden baslayarak):");
        BFS(cizge, 1);

        // iki dugum arasinda baglanti var mi
        // BFS ile baslangic dugumune ulasilan dugumleri bul
        // hedef dugum bulunanlar arasindaysa baglanti var
        int baslangic = 1;
        int hedefDugum = 4;
        bool baglantiVar = BaglantiKontrol(cizge, baslangic, hedefDugum);
        Console.WriteLine();
        if (baglantiVar)
        {
            Console.WriteLine(baslangic + " ile " + hedefDugum + " arasinda baglanti var.");
        }
        else
        {
            Console.WriteLine(baslangic + " ile " + hedefDugum + " arasinda baglanti yok.");
        }
    }

    // BFS metodu - tum dugumleri kuyruk yardimiyla dolas
    static void BFS(Dictionary<int, List<int>> cizge, int baslangic)
    {
        // ziyaret edilenleri tutmak icin liste
        List<int> ziyaretEdilen = new List<int>();
        Queue<int> kuyruk = new Queue<int>();

        kuyruk.Enqueue(baslangic);
        ziyaretEdilen.Add(baslangic);

        while (kuyruk.Count > 0)
        {
            int suanki = kuyruk.Dequeue();
            Console.Write(suanki + " ");

            // suanki dugumun komsularini kontrol et
            foreach (int komsu in cizge[suanki])
            {
                // ziyaret edilmediyse kuyruga ekle
                if (!ziyaretEdilen.Contains(komsu))
                {
                    ziyaretEdilen.Add(komsu);
                    kuyruk.Enqueue(komsu);
                }
            }
        }
        Console.WriteLine();
    }

    // iki dugum arasinda baglanti var mi diye kontrol eden metod
    // BFS mantigi ile baslangic dugumden hedefe ulasilabiliyor mu bak
    static bool BaglantiKontrol(Dictionary<int, List<int>> cizge, int baslangic, int hedef)
    {
        List<int> ziyaretEdilen = new List<int>();
        Queue<int> kuyruk = new Queue<int>();

        kuyruk.Enqueue(baslangic);
        ziyaretEdilen.Add(baslangic);

        while (kuyruk.Count > 0)
        {
            int suanki = kuyruk.Dequeue();

            if (suanki == hedef)
            {
                return true; // hedefe ulasti
            }

            foreach (int komsu in cizge[suanki])
            {
                if (!ziyaretEdilen.Contains(komsu))
                {
                    ziyaretEdilen.Add(komsu);
                    kuyruk.Enqueue(komsu);
                }
            }
        }

        return false; // ulasilamadi
    }
}
