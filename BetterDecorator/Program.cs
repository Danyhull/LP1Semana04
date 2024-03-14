using System;

namespace BetterDecorator
{
    /// <summary>
    /// Programa que recebe 3 parâmetros e imprime-os de acordo com a função 
    /// Decor, imprime um char no ínicio e no fim um número de int vezes com uma
    /// string no meio.
    /// Porém caso não receba 3 parâmetros, imprime outra coisa
    /// </summary>
    class Program
    {
        /// <summary>
        /// Função Decor e recebe uma string, um char e um int e envia o char
        /// repetido um número int de vezes no fim e no início e no meio mete a
        /// string
        /// </summary>
        /// <param name="s">String recebida para imprimir no meio da
        /// frase</param>
        /// <param name="c">Char recebido para imprimir um número de vezes no
        /// início e fim da string</param>
        /// <param name="i">Int recebido para repetir o char</param>
        /// <returns>Uma string</returns>
        private static string Decor(string s, char dec, int count)
        {
            string frase = "";
            for (int i = 0; i<count; i++)
            {
                frase += $"{dec}";
            }
            frase += $"{s}";
            for (int i = 0; i<count; i++)
            {
                frase += $"{dec}";
            }
            return frase;
        }
        private static string Decor()
        {
            return (Decor("User did not specify args!",'=',2));
        } 
        /// <summary>
        /// recebe uma string e imprime
        /// </summary>
        static void Main(string[]args)

        {
            if (args.Length == 3)
                Console.WriteLine(Decor(args[0],char.Parse(args[1])
            , int.Parse(args[2])));
            else
                Console.WriteLine(Decor());
        } 
    }
}
