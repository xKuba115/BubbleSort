using System;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = getRandomNumber();
            bubbleSort(number);
            printSortedNumber(number);
        }

        private static void printSortedNumber(int[] randomNum)
        {
            Console.WriteLine("Bubble sorted:");
            for (int i = 0; i < randomNum.Length; i++)
            {
                Console.WriteLine(randomNum[i]);
            }
        }

        private static void bubbleSort(int[] randomNum)
        {
            int length = randomNum.Length;
            int replace = 0;

            do
            {
                for (int i = 0; i < length - 1; i++)
                {
                    if (randomNum[i] > randomNum[i + 1])
                    {
                        replace = randomNum[i];
                        randomNum[i] = randomNum[i + 1];
                        randomNum[i + 1] = replace;
                    }
                }

                length--;
            } while (length > 1);
        }

        private static int[] getRandomNumber()
        {
            int[] randomNum = new int[10];
            Random rnd = new Random();
            Console.WriteLine("Original:");

            for (int i = 0; i < randomNum.Length; i++)
            {
                randomNum[i] = rnd.Next(1, 50);
                Console.WriteLine(randomNum[i]);
            }

            return randomNum;
        }
    }
}
