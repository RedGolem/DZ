int Del (int ar, int ar1)
{
    int result = ar * 10 + ar1;
    return result; 
}
int Num1 (int num)
{
    int thm = num / 100;
    return thm;
}
int Num2 (int num)
{
    int thm = num % 100;
    int th = thm / 10;
    return th;
}
int Num3 (int num)
{
    int thm = num % 10;
    return thm;
}

Console.Write("Введите трехзначное число и нажмите клавишу Enter: ");
string numstr = Console.ReadLine();
int num = Convert.ToInt32(numstr);
int result = Del(Num1(num), Num3(num));
Console.Write(result);