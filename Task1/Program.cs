// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Write("Enter a: ");
int a=int.Parse(Console.ReadLine());
Console.Write("Enter b: ");
int b=int.Parse(Console.ReadLine());
int exponentation=GetExponentation(a,b);
Console.WriteLine($"-> {exponentation}");

int GetExponentation(int number1,int number2)
{
  int res=1;
  for (int i=1;i<=number2; i++ )
  {
  res=res*number1;
  }
return res;
}