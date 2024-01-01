// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
/*
 Koleksiyonlar-Soru-1

Soru - 1: Klavyeden girilen
20 adet pozitif sayının asal ve asal olmayan olarak 
2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.

Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
 
 */



ArrayList primeNumberList= new ArrayList();
ArrayList NonPrimeNumberList= new ArrayList();


try
{

    //Console.Write("pleae :");
    //int.TryParse(Console.ReadLine(), out int results);

    //Console.WriteLine(results);

    for (int i = 1; i <= 4; i++)
    {
        Console.Write($"PLease enter your {i}.number:");

        if (int.TryParse(Console.ReadLine(), out int result))
        {
            int sayac = 0;

            if (result <= 0)
            {
                Console.WriteLine("Please enter the positive numeric number");
                i=i-1;
            }
            else
            {
                for (int dividedNumeric = 1; dividedNumeric <= result; dividedNumeric++) 
                {
                    if (result % dividedNumeric==0)
                    {
                        sayac++;
                    }             
                }
                if (sayac==2)
                {
                    primeNumberList.Add(result);
                }
                else
                {
                    NonPrimeNumberList.Add(result);
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter the numeric number");

            i = i - 1;
             
        }        
    }

    //Console.ReadLine();

    primeNumberList.Sort();
    NonPrimeNumberList.Sort();


    Console.WriteLine("********** PrimeNumbers ******");
    foreach (var primeNUmber in primeNumberList)
    {
        Console.WriteLine(primeNUmber);
    }

    Console.WriteLine("********** NonPrimeNumbers ******");
    foreach (var nonPrimeNumber in NonPrimeNumberList)
    {
        Console.WriteLine(nonPrimeNumber);
    }

    Console.ReadLine(); 
}
catch (Exception ex)
{
    Console.WriteLine($"Error occured Exception Message:{ex.Message}");
}