using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = 15;
            int number2 = 20;
            var result = Add1(ref number1, number2);
            Console.WriteLine(result);
            Console.WriteLine(number1);//number1 değiştiğini gördük

            static int Add1(ref int number1, int number2)
            {
                number1 = 50;
                return number1 * number2;
            }

            int number3 = 50;
            int number4 = 5;
            var result2 = Add2(out number3, number4);
            Console.WriteLine(result2);

            static int Add2(out int number3, int number4)
            {
                number3 = 40;
                return number3 + number4;
            }

        }
    }

}
