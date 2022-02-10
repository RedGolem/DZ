int Thnum (int num)
{
    int thm = num % 1000;
    int th = thm / 100;
    return th;
}




Console.Write("Введите первое число и нажмите клавишу Enter: ");
string numstr = Console.ReadLine();
int num = Convert.ToInt32(numstr);

int result = Thnum(num);
Console.WriteLine(result);
