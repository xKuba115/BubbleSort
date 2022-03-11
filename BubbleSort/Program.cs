using System;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomNum = new int[10];             //Creating random array
            Random rnd = new Random();
            Console.WriteLine("Original:");
            for (int i = 0;i < randomNum.Length; i++)  
            {
                randomNum[i] = rnd.Next(1, 50);
                Console.WriteLine(randomNum[i]);
            }

            int length=randomNum.Length;
            int replace = 0;
            do                                         //Bubble sorting array
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
            Console.WriteLine("Bubble sorted:");
            for (int i = 0; i < randomNum.Length; i++)
            {
                Console.WriteLine(randomNum[i]);
            }
        }
    }
}
