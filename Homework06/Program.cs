using System.Runtime.InteropServices;
using System.Text;

namespace Homework06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your full Name : ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string initials = "";

            for(int i = 0; i < words.Length - 1; i++)
            {
                initials += words[i][0].ToString().ToUpper() + ". ";
            }

            initials += words[words.Length - 1];

            Console.WriteLine(initials);
        }
    }
}