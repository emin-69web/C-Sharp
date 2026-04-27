using System;
using System.Collections.Generic;

// agacin her bir dugumu icin Node sinifi
class Node
{
    public int Deger;
    public Node Sol;
    public Node Sag;

    public Node(int deger)
    {
        Deger = deger;
        Sol = null;
        Sag = null;
    }
}

class Problem2
{
    static int dugumSayisi = 0; // toplam dugum sayisini say

    static void Main()
    {
        // sabit degerlerle bir ikili agac olustur
        //          40
        //         /  \
        //        20   60
        //       / \   / \
        //      30 10 50 90
        Node kok = new Node(40);
        kok.Sol = new Node(20);
        kok.Sag = new Node(60);
        kok.Sol.Sol = new Node(30);
        kok.Sol.Sag = new Node(10);
        kok.Sag.Sol = new Node(50);
        kok.Sag.Sag = new Node(90);

        // kok dugumu goster
        Console.WriteLine("Kok dugum: " + kok.Deger);

        // sol ve sag cocuk
        Console.WriteLine("Sol cocuk: " + kok.Sol.Deger);
        Console.WriteLine("Sag cocuk: " + kok.Sag.Deger);

        // toplam dugum sayisi
        DugumSay(kok);
        Console.WriteLine();
        Console.WriteLine("Toplam dugum sayisi: " + dugumSayisi);

        // belirli bir deger ara
        int aranan = 40;
        bool bulundu = Ara(kok, aranan);
        if (bulundu)
        {
            Console.WriteLine(aranan + " agacta var.");
        }
        else
        {
            Console.WriteLine(aranan + " agacta yok.");
        }

        // baska bir deger
        int aranan2 = 99;
        if (Ara(kok, aranan2))
        {
            Console.WriteLine(aranan2 + " agacta var.");
        }
        else
        {
            Console.WriteLine(aranan2 + " agacta yok.");
        }

        // inorder dolasma 
        Console.WriteLine();
        Console.WriteLine("Inorder dolasma:");
        Inorder(kok);
        Console.WriteLine();
    }

    // dugum sayma metodu 
    static void DugumSay(Node node)
    {
        if (node == null) return;
        dugumSayisi++;
        DugumSay(node.Sol);
        DugumSay(node.Sag);
    }

    // arama metodu 
    static bool Ara(Node node, int deger)
    {
        if (node == null) return false;
        if (node.Deger == deger) return true;
        // hem sol hem sag taraflara bak
        return Ara(node.Sol, deger) || Ara(node.Sag, deger);
    }

    // inorder dolasma
    static void Inorder(Node node)
    {
        if (node == null) return;
        Inorder(node.Sol);
        Console.Write(node.Deger + " ");
        Inorder(node.Sag);
    }
}
