// See https://aka.ms/new-console-template for more information
using System.Linq;




List<string> allVowelLetters = new List<string>();

/* 
 Klavyeden girilen cümle içerisindeki sesli 
harfleri bir dizi içerisinde saklayan,
ve dizinin elemanlarını sıralayan programı yazınız.
 
 */
//EUNOIA
string[] vowelLetters = new string[] { "e", "u", "n","o","ı","a",
    "E","U","N","O","I","A" };

Console.Write("Please input the sentences:");

string inputtedText=Console.ReadLine();

if (!string.IsNullOrEmpty(inputtedText))
{
    char[] letters = inputtedText.Trim().ToCharArray();

    string[] letterList = letters.Select(x => x.ToString()).ToArray();


    foreach (string item in letterList)
    {
        if (vowelLetters.Contains(item))
        {
            allVowelLetters.Add(item);

        }
    }

    Console.WriteLine("ALL VOWEL LETTERS");

    foreach (var item in allVowelLetters)
    {
        Console.WriteLine(item);
    }

}

// Split the string into an array of characters


