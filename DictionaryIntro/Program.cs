using System;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> students = new MyDictionary<string, int>();
            string a;
            int b;
            Console.WriteLine("Eklenecek kişinin ismini giriniz");
            a = Console.ReadLine();
            Console.WriteLine("Eklenecek kişinin numarasını giriniz");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            students.Add("Enes", 129);
            students.Add("Mustafa", 150);
            students.Add("Mehmet", 99);
            students.Add("Ömer", 183);
            students.Add("Tahiri", 55);
            students.Add(a, b);
           
            for (int i = 0; i < students.CountS; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("{0} = {1}", students.student1[i], students.studentNumber1[i]);               
            }

        }
    }
}
