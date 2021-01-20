using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tekrar tekrar kullanabilirliği sağlar.

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Muğla karpuzu";

            Product[] products = new Product[] { product1, product2 };

            //type safe -- tip güvenliği
            foreach (var product in products) // var  da olur
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("---------------");
            }


            Console.WriteLine("-------------------Metotlar---------------------");
            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 13, 5);
            sepetManager.Ekle2("Elma", "Yeşil elma", 13, 20);
            sepetManager.Ekle2("Karpuz", "Muğla karpuzu", 13, 15);

            sepetManager.Çıkarma(product1);

        }
    }
}
