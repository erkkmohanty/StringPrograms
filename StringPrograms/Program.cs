using System;

namespace StringPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            "Kiran".PrintReverse();
            "a,b$c".ReverseWithoutReversingSpecialCharacters();
            "Ab,c,de!$".ReverseWithoutReversingSpecialCharacters();
            "KKiran".RemoveDuplicates();
            Console.ReadLine();
        }
    }
}
