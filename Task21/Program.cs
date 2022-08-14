/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

using static System.Console;
WriteLine("Введите координату Х точки А: ");
int xa = int.Parse(ReadLine()!);
WriteLine("Введите координату Y точки А: ");
int ya =  int.Parse(ReadLine()!);
WriteLine("Введите координату Z точки А: ");
int za = int.Parse(ReadLine()!);
WriteLine("Введите координату Х точки В: ");
int xb = int.Parse(ReadLine()!);
WriteLine("Введите координату Y точки В: ");
int yb = int.Parse(ReadLine()!);
WriteLine("Введите кординату Z точки В: ");
int zb = int.Parse(ReadLine()!);
double dstanceBetween2PointsIn3d = Math.Round(Math.Pow((xa-xb)*(xa-xb) + (ya-yb)*(ya-yb)+(za-zb)*(za-zb), 0.5), 2);
WriteLine(dstanceBetween2PointsIn3d);

