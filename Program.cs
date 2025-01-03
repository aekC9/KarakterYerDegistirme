using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan string ifade al
        Console.WriteLine("Lütfen bir cümle giriniz:");
        string input = Console.ReadLine();

        // String'i kelimelere ayır
        string[] words = input.Split(' ');

        // Kelimeleri işle
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            if (word.Length > 1) // Eğer kelimenin boyutu 1'den büyükse
            {
                string modifiedWord = word[word.Length - 1] + word.Substring(0, word.Length - 1);
                words[i] = modifiedWord;
            }
        }

        // İşlenmiş kelimeleri birleştir ve yazdır
        string result = string.Join(" ", words);
        Console.WriteLine("Sonuç: " + result);
    }
}