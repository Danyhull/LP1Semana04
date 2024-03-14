using System;

namespace BetterDecorator
{
    class Program
    {
        private static string Decor(string s, char dec, int num)
        {
            string frase = "";
            for (int i = 0; i<num; i++)
            {
                frase += $"{dec}";
            }
            frase += $"{s}";
            for (int i = 0; i<num; i++)
            {
                frase += $"{dec}";
            }
            return frase;
        }
        static void Main(string[]args)
        {
            Console.WriteLine(Decor("Lost Forever",'.',3));
        } 
    }
}
