using System;

class Problem3
{
    static void Main()
    {
        // 5 sayi tanimliyorum
        int[] dizi = { 12, 21, 33, 44, 9 };

        // once diziyi siralama lazim cunku binary search siralanmis dizide calisir
        //  bir bubble sort ile sirala
        for (int i = 0; i < dizi.Length - 1; i++)
        {
            for (int j = 0; j < dizi.Length - 1 - i; j++)
            {
                if (dizi[j] > dizi[j + 1])
                {
                    int gecici = dizi[j];
                    dizi[j] = dizi[j + 1];
                    dizi[j + 1] = gecici;
                }
            }
        }

        // siralanmis diziyi yaz
        Console.Write("Siralanmis dizi: ");
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write(dizi[i] + " ");
        }
        Console.WriteLine();

        // kullanicidan aranacak sayiyi al
        Console.Write("Aranacak sayiyi giriniz: ");
        int aranan = int.Parse(Console.ReadLine());

        // binary search
        // her adimda dizinin ortasina bak, aradigimiz sayi ortadan kucukse sol tarafa, buyukse sag tarafa git
        int sol = 0;
        int sag = dizi.Length - 1;
        int adimSayisi = 0;
        int bulunanIndex = -1; // -1 ise bulunamadi demek

        while (sol <= sag)
        {
            adimSayisi++;
            int orta = (sol + sag) / 2;

            Console.WriteLine("Adim " + adimSayisi + ": sol=" + sol + ", sag=" + sag + ", orta=" + orta + " (deger: " + dizi[orta] + ")");

            if (dizi[orta] == aranan)
            {
                // bulundu
                bulunanIndex = orta;
                break;
            }
            else if (dizi[orta] < aranan)
            {
                // aradigimiz sayi daha buyuk, sag tarafa bak
                sol = orta + 1;
            }
            else
            {
                // aradigimiz sayi daha kucuk, sol tarafa bak
                sag = orta - 1;
            }
        }

        // sonucu yaz
        Console.WriteLine();
        if (bulunanIndex != -1)
        {
            Console.WriteLine(aranan + " sayisi " + bulunanIndex + ". index'te bulundu.");
        }
        else
        {
            Console.WriteLine(aranan + " sayisi dizide bulunamadi.");
        }
        Console.WriteLine("Toplam adim sayisi: " + adimSayisi);
    }
}
