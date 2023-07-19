//Напишите программу, которая по заданному номеру четверти , показывает диапозон возможных координат точек в этой четверти.

Console.Clear();
int Input(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());

}
int num = Input("Введите номер четверти");

if(num == 1)
{
    Console.WriteLine("x > 0 && y > 0");
} 
else if(num == 2)
{
    Console.WriteLine("x < 0 && y > 0");
}
else if(num == 3)
{
    Console.WriteLine("x < 0 && y < 0");
}
else if(num == 4)
{
    Console.WriteLine("x > 0 && y < 0");
}
else
Console.WriteLine("Номер четверти введен не правильно.");
