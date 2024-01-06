// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");


/*
             Soru - 2: Klavyeden girilen 20 adet sayının
            en büyük 3 tanesi ve en küçük 3 tanesi bulan,
            her iki grubun kendi içerisinde ortalamalarını alan 
            ve bu ortalamaları ve ortalama toplamlarını console'a 
            yazdıran programı yazınız. 
            (Array sınıfını kullanarak yazınız.) 
 */

ArrayList thelargestThreeNumbers = new ArrayList();
ArrayList theSmallestThreeNumbers = new ArrayList();

ArrayList allNumbers = new ArrayList();



try
{

    for (int i = 1; i <= 20; i++)
    {
        Console.Write($"PLease enter your {i}.number:");

        if (int.TryParse(Console.ReadLine(), out int result))
        {

            allNumbers.Add(result);
        }
        else
        {
            Console.WriteLine("Please enter the numeric number");

            i = i - 1;

        }
    }

    // let's order all have inputted number from the largest to the smallest

    allNumbers.Sort();

    theSmallestThreeNumbers.AddRange(allNumbers.Cast<int>().ToList().Take(3).ToList());

    allNumbers.Reverse();

    thelargestThreeNumbers.AddRange(allNumbers.Cast<int>().ToList().Take(3).ToList());


    List<int> theSmallestThreeNumbersLists = theSmallestThreeNumbers.Cast<int>().ToList();
    List<int> thelargestThreeNumbersLists = thelargestThreeNumbers.Cast<int>().ToList();


    Console.WriteLine($"Threee smallest Sum : {(theSmallestThreeNumbersLists.Sum())}");
    Console.WriteLine($"Threee smallest number average: {((decimal)(theSmallestThreeNumbersLists.Sum() / 3.0)).ToString("0.000")}");


    Console.WriteLine($"Threee largest Sum : {(thelargestThreeNumbersLists.Sum())}");
    Console.WriteLine($"Threee largest number average: {((decimal)(thelargestThreeNumbersLists.Sum() / 3.0)).ToString("0.000")}");




    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine($"Error occured Exception Message:{ex.Message}");
}