namespace Aula22Static
{
    public static class Conversor
    {
        
        public static float ValorDolar = 5.29f;

        //Converte Dólar (moeda americana) para Real (moeda brasileira).
        public static float ConverterDolarParaReal(float valor){

            return valor * ValorDolar;

        }
        //Converte Real (moeda brasileira) para Dólar (moeda americana).
        public static float ConverterRealParaDolar(float valor){

            return valor / ValorDolar;

        }

        public static float ValorEuro = 5.90f;

        //Converte Euro (moeda da União Européia) para Real (moeda brasileira).
        public static float ConverterEuroParaReal(float valor){

            return valor * ValorEuro;

        }
        //Converte Real (moeda brasileira) para Euro (moeda da União Européia).
        public static float ConverterRealParaEuro(float valor){

            return valor / ValorEuro;

        }



    }
}