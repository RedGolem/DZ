int Counter(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count ++;
    }
    return count;
}
int therd (int num, int arg)
{
    int count = 0;

    while (count < (num - 3))
        {
            arg = arg / 10;
            count ++;
        }
    arg = arg % 10;
    return arg;
}


Console.Write("Введите число и нажмите клавишу Enter: ");
string numstr = Console.ReadLine();
int num = Convert.ToInt32(numstr);
int result = therd (Counter(num), num);
Console.Write(result);