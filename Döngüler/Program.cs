using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazlılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java Kursu";

            // arrays - diziler

            string[] kurslar = new string[] { "Yazlılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java Kursu", "Phython" };

            //Birbirine benzeyen işlemleri tekrar etmek için kullanılır
            for (int i = 0; i < kurslar.Length; i++) // i+=2   i=i+2      i < 4
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");
            // Dizi temelli yapıları tek tek döndürmeye yarar    Dizilere uygulanır
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}
