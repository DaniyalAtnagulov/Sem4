// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Enter the number");
int number=int.Parse(Console.ReadLine());
Console.WriteLine(GetSum(number));

int GetSum (int sum)
{  
 int res=0;
    
    while (sum>0)
    {
        res=res+ sum%10;
        sum=sum/10;

        }
    
    return res;
    }

