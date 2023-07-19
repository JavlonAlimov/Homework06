namespace Homework06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Satr kiriting : ");
            string input = Console.ReadLine(); 

            int NumberOfRepetition = 0, maxNumberOfRepetition = 1;
            char mostRepeted = input[0], letter = input[0];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == letter)
                {
                    NumberOfRepetition++;
                }
                else
                {
                    if (NumberOfRepetition > maxNumberOfRepetition)
                    {
                        maxNumberOfRepetition = NumberOfRepetition;
                        mostRepeted = letter;
                    }
                    NumberOfRepetition = 1;
                    letter = input[i];
                }
            }
            Console.WriteLine($" The {mostRepeted} is repeted {maxNumberOfRepetition} times");
        }
    }
}