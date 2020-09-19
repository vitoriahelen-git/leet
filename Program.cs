using System;

namespace leet
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto; 
            Console.Write("Mensagem:");
            texto = Console.ReadLine().ToUpper();
            Console.Write("Voce digitou:" + texto.Replace("A","4").Replace("E","3").Replace("I","1").Replace("L","1").Replace("O","0").Replace("T","7").Replace("S","5")); 

        }
    }
}
