
Console.Clear();
int Input(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());

}
int x = Input("Введите x ");
int y = Input("Введите y ");

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка пренадлежит первой четверти ");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка пренадлежит второй четверти ");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка пренадлежит третьей четверти ");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка пренадлежит четвертой четверти ");
}
else
{
    Console.WriteLine("Точка лежит на оси");
}