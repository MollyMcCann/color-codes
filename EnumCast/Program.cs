using System;

namespace EnumCast
{ 
    enum ShirtSize
    {
        Small = 1,
        Medium = 2,
        Large = 3,
        ExtraLarge = 4,
        ExtraExtraLarge= 5,
    }
    struct Person
    {
        public String Name;
        public string Address;
        public byte Age;
    }

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

            ShirtSize size = ShirtSize.Medium;
            int integerSize = (int)size;

            Console.WriteLine();
            Console.Write("Interger Size: {0}" ,integerSize);
            Console.WriteLine(" Enum Size: {0}", size);

            object objInteger = 100;
            int integerValue = (int)objInteger;

            Console.WriteLine();
            Console.WriteLine("casted Integer: {0}", integerValue);

            Console.ReadKey();


        }
    }
}
