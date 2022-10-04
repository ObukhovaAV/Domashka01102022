Console.WriteLine("Введите число");
long number = long.Parse(Console.ReadLine() ?? "0");
int a = 99;
int b = 999;

if (number>a)
{
   while (number>b)
   {
    number = number/10;
   }
   long third = number%10;

Console.Write(third);
}
else
{
    Console.Write("no");
}
   

