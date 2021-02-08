using System;

namespace WriteNumbersOneToTrillion
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = 1002333004560;

            long trillions = 0;
            long billions = 0;
            long millions = 0;
            long thousands = 0;
            long hundreds = 0;
            long tens = 0;

            long oneTrillion = 1000000000000;
            long oneBillion = 1000000000;
            long oneMillion = 1000000;
            long oneThousand = 1000;
            long oneHundred = 100;

            PerformCount(ref input, ref trillions, oneTrillion, "trillion");
            PerformCount(ref input, ref billions, oneBillion, "billion");
            PerformCount(ref input, ref millions, oneMillion, "million");
            PerformCount(ref input, ref thousands, oneThousand, "thousand");
            PerformCount(ref input, ref hundreds, oneHundred, "hundred");


            

            

            if (input > 0)
            {
                tens = input % 100;
                Console.Write($"and {hundreds}");
            }


            Console.WriteLine();
            //{tens}
        }

        public static void PerformCount(ref long input, ref long trillions, long oneTrillion, string trillionString)
        {
            if (input >= oneTrillion)
            {
                trillions = input / oneTrillion;
                input -= (trillions * oneTrillion);
                Console.Write($"{trillions} {trillionString}, ");
            }
        }
    }
}
