// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]

// 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]

int [] array = new int[8];
void NewArray(int[] array)
{
   Console.Write("[");
int lenght=array.Length;
for (int i=0; i<lenght-1;i++)
{
   array[i]=new Random().Next(0,1000);
   Console.Write($"{array[i]}, ");
}
array[lenght-1]=new Random().Next(0,1000);
Console.Write( array[lenght-1] );
Console.Write("]");
}
NewArray(array);