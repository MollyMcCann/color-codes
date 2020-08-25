using System;

namespace color_codes
{
    enum ColorCodes : int
    {
        Red= 1,
        Blue= 2,
        Green=3, 
        Yellow = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            int intergerCode = 3;
            ColorCodes myColor = (ColorCodes)intergerCode;
        }
    }
}
