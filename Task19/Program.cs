/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

Я пока вижу 2 варианта:
Ваирант 1: математический, оформленный для практики 
тернарником

using static System.Console;
WriteLine("Введите пятизначное число: ");
int number = int.Parse(ReadLine()!);
WriteLine(number>9999 && number<100000 ? 
number/10000==number%10 && number%10000/1000==number/10%10 ?
"да":"нет":"вы ввели не пятизначное число");

Вариант 2: для натурального числа любой разрядности
с использованием функций

using static System.Console;
WriteLine("Введите натуральное число N: ");
int number = int.Parse(ReadLine()!);
int FindBitDepthOfNumbe(int digit)
{
    int i = 0;
    while (digit > 0)
    {
        digit /= 10;
        i++;
    }
    return i;
}
int index = FindBitDepthOfNumbe(number);
string answer = "нет";
while (index>=1)
{
    if (number % 10 == Math.Floor(number / Math.Pow(10, (index - 1))))
    {
        number = Convert.ToInt32(number % (Math.Pow(10, index - 1))/10);
        answer = "да";
        index -= 2;
    }     
    else 
    {
        answer = "нет";
        break;
    }
}
WriteLine(answer);

Варианте 3: используя массивы, возможно самый удачный
Сперва определяем количество разрядов числа, затем создаем массив, далее сравниваем первый 
и последний элемент массива, причем просматриваем массив до середины. При определении половины 
делим 2 целых числа -> полцчаем целое. Так снимается вопрос четности и нечетности количества 
разрядов исходного числа.

*/

using static System.Console;
WriteLine("Введите натуральное число N: ");
int N = int.Parse(ReadLine()!);
int count = 0;
int K = N;
while (K > 0)
{
    K = K / 10;
    count++;
}
int[] array = new int[count];

for (int index =0; index<count; index++)
{
    array[index]=N%10;
    N=N/10;
}

int temp = (array.Length / 2);
string answer = "нет";
for (int index = 0; index < (array.Length / 2); index++)
{
    if (array[index] == array[array.Length - 1 - index])
    {
        answer = "да";
    }
    else
    {
        answer = "нет";
        break;
    }
}
WriteLine(answer);




