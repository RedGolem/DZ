Console.WriteLine("Введите число и нажмите Enter");
string numstr = Console.ReadLine();
int num = Convert.ToInt32(numstr);
double ost = num % 2; 
Console.Write(ost);
if (ost > 0)
{
    Console.WriteLine("Число нечетное");
} 
else 
{   
    Console.WriteLine("Число четное");
}
