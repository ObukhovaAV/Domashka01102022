Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine() ?? "0");
int a = 99;
int b = 999;

if (number>a)
{
   while (number>b)
   {
    number = number/10;
   }
   int third = number%10;

Console.Write(third);
}
else
{
    Console.Write("В числе нет третьей цифры");
}
   

