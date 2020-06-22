using System;

namespace Aula22Static
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Converte Dólar (moeda americana) para Real (moeda brasileira).
            Console.WriteLine("Conversão do dólar para real:");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine( Conversor.ConverterDolarParaReal(29.35f)+"\n" );
            Console.ResetColor();

            //Converte Real (moeda brasileira) para Dólar (moeda americana).
            Console.WriteLine("Conversão do real para dólar:");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine( Conversor.ConverterRealParaDolar(134.57f)+"\n" );
            Console.ResetColor();

            //Converte Euro (moeda da União Européia) para Real (moeda brasileira).
            Console.WriteLine("Conversão do euro para real:");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine( Conversor.ConverterEuroParaReal(49.83f)+"\n" );
            Console.ResetColor();

            //Converte Real (moeda brasileira) para Euro (moeda da União Européia).
            Console.WriteLine("Conversão do real para euro:");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine( Conversor.ConverterRealParaEuro(78.25f) );

        }
    }
}
