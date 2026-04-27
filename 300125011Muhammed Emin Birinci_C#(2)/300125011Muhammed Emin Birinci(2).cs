using System;

class Problem2
{
    static void Main()
    {
        int[] sayilar = new int[5];

        // 5 sayi al
        Console.WriteLine("5 adet sayi giriniz:");
        for (int i = 0; i < 5  ; i++)
        {
            Console.Write((i + 1) + ". sayi: ");
            sayilar[i] = int.Parse(Console.ReadLine());
        }

        // baslangic durumu
        Console.WriteLine();
        Console.Write("Baslangic dizisi: ");
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write(sayilar[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();

        // bubble sort
        // her adimda yan yana iki elemani karsilastir, gerekirse yer degistir
        // her dis dongude en buyuk eleman sona iter
        int karsilastirmaSayisi = 0;
        int adim = 1;

        for (int i = 0; i < sayilar.Length - 1; i++)
        {
            for (int j = 0; j < sayilar.Length - 1 - i; j++)
            {
                karsilastirmaSayisi++;

                // soldaki sagdakinden buyukse yer degistir
                if (sayilar[j] > sayilar[j + 1])
                {
                    int gecici = sayilar[j];
                    sayilar[j] = sayilar[j + 1];
                    sayilar[j + 1] = gecici;
                }
            }

            // dis dongu adimindan sonra dizinin son halini yaz
            Console.Write("Adim " + adim + ": ");
            for (int k = 0; k < sayilar.Length; k++)
            {
                Console.Write(sayilar[k] + " ");
            }
            Console.WriteLine();
            adim++;
        }

        // siralanmis dizi
        Console.WriteLine();
        Console.Write("Siralanmis dizi: ");
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write(sayilar[i] + " ");
        }
        Console.WriteLine();

        // toplam karsilastirma sayisi
        Console.WriteLine("Toplam karsilastirma sayisi: " + karsilastirmaSayisi);
    }
}
