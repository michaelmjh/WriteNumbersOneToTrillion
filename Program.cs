using System;

namespace WriteNumbersOneToTrillion
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = 111222333444555;

            long trillions = 0;
            long billions = 0;
            long millions = 0;
            long thousands = 0;

            long oneTrillion = 1000000000000;
            long oneBillion = 1000000000;
            long oneMillion = 1000000;
            long oneThousand = 1000;

            PerformCount(ref input, ref trillions, oneTrillion, "trillion");
            PrintNumberInEnglish(trillions);
            PrintMultiplier(trillions, "trillion");

            PerformCount(ref input, ref billions, oneBillion, "billion");
            PrintNumberInEnglish(billions);
            PrintMultiplier(billions, "billion");

            PerformCount(ref input, ref millions, oneMillion, "million");
            PrintNumberInEnglish(millions);
            PrintMultiplier(millions, "million");

            PerformCount(ref input, ref thousands, oneThousand, "thousand");
            PrintNumberInEnglish(thousands);
            PrintMultiplier(thousands, "thousand");

            PrintNumberInEnglish(input);

            Console.WriteLine();
        }

        public static void PerformCount(ref long input, ref long quantityOfMulitpier, long mulitpier, string multiplierInEnglish)
        {
            if (input >= mulitpier)
            {
                quantityOfMulitpier = input / mulitpier;
                input -= (quantityOfMulitpier * mulitpier);
            }
        }

        public static void PrintNumberInEnglish(long number)
        {
            string[] singleDigits = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tensArray = new string[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            bool useAnd = false;

            if (number > 0)
            {
                if (number > 99)
                {
                    int hundreds = (int)number / 100;
                    Console.Write($"{singleDigits[hundreds]} hundred ");
                    number -= (hundreds * 100);
                    useAnd = true;
                }

                if (number > 19)
                {
                    UseAndCheck(useAnd);
                    useAnd = false;
                    int tens = (int)number / 10;
                    Console.Write($"{tensArray[tens]} ");
                    number -= (tens * 10);
                }

                if (number > 0)
                {
                    UseAndCheck(useAnd);
                    Console.Write($"{singleDigits[number]} ");
                }
                //Console.Write($"{number} ");
            }

        }

        public static void PrintMultiplier(long multiplier, string multiplierInEnglish)
        {
            if (multiplier > 0)
            {
                Console.Write($"{multiplierInEnglish} ");
            }

        }

        public static void UseAndCheck(bool useAnd)
        {
            if (useAnd)
            {
                Console.Write("and ");
            }
        }
    }
}