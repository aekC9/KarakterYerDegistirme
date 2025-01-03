using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir cümle giriniz:");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            if (word.Length > 1)
            {
                string modifiedWord = word.Substring(1) + word[0];
                words[i] = modifiedWord;
            }
        }

        string result = string.Join(" ", words);
        Console.WriteLine("Sonuç: " + result);
    }
}
