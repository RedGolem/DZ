int Otvet (int num)
{
        if (num > 0 && num <6) Console.WriteLine("Сегодня будний день :(");  
        if (num == 6) Console.WriteLine("Ура, сегодня выходной!");
        if (num == 7) Console.WriteLine("Ура, сегодня выходной!");
        return num;
}
int Proverka (int num)
{
    if (num<0) 
    {
        Console.WriteLine("Введено некоректное значение");
    }
    if (num>7)
    {
        Console.WriteLine("Введено некоректное значение");
    }
    return num;
}
Console.Write("Введите число обозначающее день недели и нажмите клавишу Enter: ");
string numstr = Console.ReadLine();
int num = Convert.ToInt32(numstr);
int result = Otvet(Proverka(num));