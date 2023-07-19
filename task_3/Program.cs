﻿/* Напишите программу, которая 
принимает на вход координаты двух точек и 
находит расстояние между ними в 2D 
пространстве.
*/


Console.Clear();
int Input(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = Input("Введите X первой точки");
int y1 = Input("Введите Y первой точки");
int x2 = Input("Введите X второй точки");
int y2 = Input("Введите Y второй точки");

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
result = Math.Round(result, 2);

Console.WriteLine($"Расстояние между точками: {result}");
