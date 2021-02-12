using System;

namespace WriteNumbersOneToTrillion
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = 101222333444555;

            long trillions = 0;
            long billions = 0;
            long millions = 0;
            long thousands = 0;

            long oneTrillion = 1000000000000;
            long oneBillion = 1000000000;
            long oneMillion = 1000000;
            long oneThousand = 1000;

            PerformCount(ref input, ref trillions, oneTrillion, "trillion");
            PerformCount(ref input, ref billions, oneBillion, "billion");
            PerformCount(ref input, ref millions, oneMillion, "million");
            PerformCount(ref input, ref thousands, oneThousand, "thousand");
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

            if (quantityOfMulitpier > 0)
            {
                PrintNumberInEnglish(quantityOfMulitpier);
                PrintMultiplier(quantityOfMulitpier, multiplierInEnglish);
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
                    int tens = (int)number / 10;
                    Console.Write($"and {tensArray[tens]} ");
                    number -= (tens * 10);
                    useAnd = false;
                }

                if (number > 9)
                {
                    Console.Write($"and {singleDigits[number]} ");
                    number = 0;
                }

                if (number > 0)
                {
                    if (useAnd)
                    {
                        Console.Write($"and ");
                    }
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

        
    }
}