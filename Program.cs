Console.WriteLine("Коэфицент a:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введит b:");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите c:");
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"D = b*2 - 4*a*c = {Math.Pow(b, 2) - 4 * a * c}");
double d = Math.Pow(b, 2) - 4 * a * c;
if (d < 0)
{
    Console.WriteLine("Корня нет");
}
else if (d == 0)
{
    Console.WriteLine($"x = {(-b) / (2 * a)}");
}
else if (d > 0)
{
    Console.WriteLine($"х-первое число = {(-b + Math.Sqrt(d)) / (2 * a)}");
    Console.WriteLine($"х-второе число = {(-b - Math.Sqrt(d)) / (2 * a)}");
}


