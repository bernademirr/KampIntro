// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace döngüler
{

    class program
    {
        static void Main(string[] args)
        {
            //array-dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs ", "Java",
            "pyton"};
          

            //dongu
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }

            //allians-kurs
            //for yerine foreach yapar

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - foother");


        }
    }
}
   





