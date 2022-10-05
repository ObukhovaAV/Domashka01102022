Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine() ?? "0");


if (number/100>0)
{
   while (number/1000>0)
   {
    number = number/10;
   }
   int third = number%10;

Console.Write(third);
}
else
{
    Console.Write("В этом числе нет третьей цифры");
}
   