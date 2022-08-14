/*Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
Вариантов несколько:
Вариант 1: Простыым выводом через цикл

using static System.Console;
WriteLine("Введите натуральное число N: ");
int N = int.Parse(ReadLine()!);
for (int i=1; i<N; i++)
{
    Write($"{Math.Pow(i, 3)}, ");
}
Write(Math.Pow(N, 3));
WriteLine();

Вариант 2: через функцию наполнения массива
*/

using static System.Console;
void FillMasiivCubesFromTheNumber(int number)
{
int[]arrayFromNumber = new int[number];
for (int i=0; i<number; i++)
{
    arrayFromNumber[i]= Convert.ToInt32(Math.Pow(i+1, 3));
    Write(arrayFromNumber[i] + ", ");
}
}
WriteLine("Введите натуральное число N: ");
int N =int.Parse(ReadLine()!);
FillMasiivCubesFromTheNumber(N);
WriteLine();


