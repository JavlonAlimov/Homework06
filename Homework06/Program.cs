using System.Text;

namespace Homework06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the sentense : ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(new char[] { ' ',',', '.', '!', '?', '$', '%', '@' }, StringSplitOptions.RemoveEmptyEntries);

            string longestWord = words[0];

            for(int i  = 1 ; i < words.Length; i++) 
            {
                if (words[i].Length >= longestWord.Length) { 
                    longestWord = words[i];
                }
            }
            Console.WriteLine($"The longest word in this sentence is {longestWord} and it's length is {longestWord.Length}");
        }
    }
}