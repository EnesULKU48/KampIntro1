using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //void = git yap bitir demek
        public void Add(Product product) //101
        {
            Console.WriteLine(product.Productname + " eklendi.");

            //product.Productname = "Kamera";
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.Productname + " güncellendi.");
        }






        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2; 
        //}

        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}



        //public void BiseyYap(int sayi)
        //{
        //    sayi = 99;
        //}
    }
}
