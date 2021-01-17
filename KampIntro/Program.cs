using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat your self

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarBugun = 7.45;
            double dolarDun = 7.50;

            if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Azalış oku");
            }

            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış oku");
            }

            else
            {
                Console.WriteLine("Değişmedi oku");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu")
            }

            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
