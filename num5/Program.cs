int Thnum (int num)
{
    int thm = num % 100;
    int th = thm / 10;
    return th;
}




Console.Write("Введите первое число и нажмите клавишу Enter: ");
string numstr = Console.ReadLine();
int num = Convert.ToInt32(numstr);

int result = Thnum(num);
Console.WriteLine(result);
