Console.WriteLine("Введите число и нажмите Enter");
string numstr = Console.ReadLine();
int num = Convert.ToInt32(numstr);
int count = 1;
int ost = 0;
while (count < (num + 1))
{
    ost = count % 2;
    if (ost == 0 ) 
    {
        Console.Write(count.ToString() + " ");
    }
    count += 1; 
}