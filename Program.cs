using System;

namespace Aula22Static
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine( Conversor.ConverterDolarParaReal(29.35f) );
            Console.WriteLine( Conversor.ConverterRealParaDolar(134.57f)+"\n" );

            Console.WriteLine( Conversor.ConverterEuroParaReal(49.83f) );
            Console.WriteLine( Conversor.ConverterRealParaEuro(78.25f) );

        }
    }
}
