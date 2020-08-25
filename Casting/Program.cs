using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byteValue1 = 200;
            int integerValue1 = byteValue1;
            Console.Write("Byte Value1: {0}", byteValue1);
            Console.WriteLine(" IntegerValue: {0}", integerValue1);

            int integerValue2 = 250;
            byte byteValue2 = (byte)integerValue2;

            Console.WriteLine();
            Console.Write("Byte Value2: {0}", byteValue2);
            Console.WriteLine(" IntegerValue2: {0}", integerValue2);

            Console.ReadKey();
        }
    }
}
