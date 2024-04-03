Console.Write("Число x");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Число n");
double n = Convert.ToDouble(Console.ReadLine());
double result = 0;
if (x > 0 && x <= 2)
{
    for (double i = 0; i <= n; i++)
    {
        result += ((Math.Pow(-1, n)) * (Math.Pow(x - 1, (n + 1)))) / (n + 1);
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Ошибка"); 
}


