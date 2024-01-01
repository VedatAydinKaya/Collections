// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
/*
 Koleksiyonlar-Soru-1

Soru - 1: Klavyeden girilen
20 adet pozitif sayının asal ve asal olmayan olarak 
2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)

Negatif ve numeric olmayan girişleri engelleyin. +++

Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın. +++ 
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

    decimal allprimeNumbersSum = 0;
    decimal allNonprimeNumbersSum = 0;

    Console.WriteLine("********** PrimeNumbers ******");
    foreach (int primeNUmber in primeNumberList)
    {
        Console.WriteLine(primeNUmber);
        allprimeNumbersSum += primeNUmber;
    }

    Console.WriteLine($"PrimeNumbers Count:{primeNumberList.Count}");
   
    if (primeNumberList.Count>0)
    {
        Console.WriteLine($"PrimeNumbers Average:{((decimal)(allprimeNumbersSum / primeNumberList.Count)).ToString("0.000")}");
    }
    else
    {
        Console.WriteLine($"Avarege cannot be calculated for PrimeNumbers since PrimeNumbers count 0 ");
    }
  

    Console.WriteLine("********** NonPrimeNumbers ******");
    foreach (int nonPrimeNumber in NonPrimeNumberList)
    {
        Console.WriteLine(nonPrimeNumber);
        allNonprimeNumbersSum += nonPrimeNumber;
    }

    Console.WriteLine($"NonPrimeNumbers Count:{NonPrimeNumberList.Count}");

    if (NonPrimeNumberList.Count>0)
    {
        Console.WriteLine($"NonPrimeNumbers Average:{(decimal)(allNonprimeNumbersSum / NonPrimeNumberList.Count)}");
    }
    else
    {
        Console.WriteLine($"Avarege cannot be calculated for NonPrimeNumbers since  NonPrimeNumbers count 0");
    }

 
    Console.ReadLine(); 
}
catch (Exception ex)
{
    Console.WriteLine($"Error occured Exception Message:{ex.Message}");
}