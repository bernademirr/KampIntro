// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace DegerVeReferansTipleri
{
    class Program
    {
        static void Main(string[] args) 
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            //sayi1 ?? 30

            Console.WriteLine(sayi1);


            int[] sayılar1 = new int[] { 10, 20, 30, };
            int[] sayılar2 = new int[] { 100, 200, 300, };
            sayılar1 = sayılar2;
            sayılar2[0] = 999;

            //sayilar1[0] ?? 999

            Console.WriteLine(sayılar1[0]);





        }

    }
}