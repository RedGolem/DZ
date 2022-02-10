int Last (int num)
{
    int last = num % 10;
    return last;
}
int Proverka (int num)
{
    if (num == 0) Console.WriteLine("Последней цифры нет");
    else Console.Write(num);
    return num;
}




Console.Write("Введите трехзначное число и нажмите клавишу Enter: ");
string numstr = Console.ReadLine();
int num = Convert.ToInt32(numstr);
int result = Proverka(Last(num));