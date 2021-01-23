using System;

namespace DictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> students = new MyDictionary<string, int>();
            students.Add("Enes", 129);
            students.Add("Mustafa", 150);
            students.Add("Mehmet", 99);
            students.Add("Ömer", 183);
            students.Add("Tahiri", 55);
            //Console.WriteLine(students.CountN);

            foreach (var i in students.student1)
            {
                Console.WriteLine(i);
            }

            foreach (var i in students.studentNumber1)
            {
                Console.WriteLine(i);
            }

        }
    }
}
