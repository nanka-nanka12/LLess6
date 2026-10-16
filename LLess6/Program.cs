namespace LLess6
{
    using System;

    class Program
    {
        static void Main()
        {
          //pirveli
            Console.WriteLine("--- პირველი დავალება ---");

            int[] numbers = { 5, 10, 15, 20 };
            int totalSum = GetArraySum(numbers);
            Console.WriteLine($"მასივის ელემენტების ჯამი: {totalSum}");
            Console.WriteLine();

            
            static int GetArraySum(int[] arr)
            {
                int sum = 0;
                foreach (int num in arr)
                {
                    sum += num;
                }
                return sum;
            }


            // meore davaleba
            
            Console.WriteLine("--- მეორე დავალება ---");

          
            PrintJoinedText("გამარჯობა, ", "როგორ ", "ხარ?");
            Console.WriteLine();

            
            static void PrintJoinedText(string text1, string text2, string text3)
            {
                string result = text1 + text2 + text3;
                Console.WriteLine(result);
            }


            // mesame davaleba

            Console.WriteLine("--- მესამე დავალება ---");

            string[] words = { "C# ", "არის ", "ძალიან ", "საინტერესო ", "ენა." };
            string combinedText = CombineStrings(words);
            Console.WriteLine(combinedText);
        }

        
        static string CombineStrings(string[] stringArray)
        {
            return string.Join("", stringArray);
        }
    }
}
