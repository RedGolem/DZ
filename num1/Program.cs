Console.Write("Введите первое число и нажмите клавишу Enter: ");
string a = Console.ReadLine();
int a1 = Convert.ToInt32(a);
Console.Write("Введите второе число и нажмите клавишу Enter: ");
string b = Console.ReadLine();
int b1 = Convert.ToInt32(b);
if (a1 == b1)
    {
        Console.WriteLine("Числа равны");
    }
else
{
    if (a1>b1)
    { 
      Console.WriteLine("Первое число больше второго");  
    }
    else
    {
        Console.WriteLine("Второе число больше первого");
    }
}
