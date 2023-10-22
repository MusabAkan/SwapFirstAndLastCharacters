using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen bir metin ifadesi girin:");
        string input = Console.ReadLine();

        string result = SwapFirstAndLastCharacters(input);

        Console.WriteLine("Sonuç: " + result);
    }

    static string SwapFirstAndLastCharacters(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 2)
            return input;
        // Eğer girdi boş veya tek karakterli ise değişiklik yapmak mümkün değil.


        char firstChar = input[0];
        char lastChar = input[input.Length - 1];

        char[] charArray = input.ToCharArray();
        charArray[0] = lastChar;
        charArray[input.Length - 1] = firstChar;

        return new string(charArray);
    }
}
