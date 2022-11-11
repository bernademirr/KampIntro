// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace kampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            //int ogrenciSayisi = 3200000;
            //double faizOranı = 1.45;
            bool sistemeGirişYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)

            {
                Console.WriteLine("Azalış butonu");
            }
            
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");

            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }




            if (sistemeGirişYapmisMi == true)
            {

                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");

            }


            Console.WriteLine(kategoriEtiketi);




        }
    }
}
