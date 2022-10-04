Console.WriteLine("Введите число");
long number = long.Parse(Console.ReadLine() ?? "0");


if (number/100>0)
{
   while (number/1000>0)
   {
    number = number/10;
   }
   long third = number%10;

Console.Write(third);
}
else
{
    Console.Write("В этом числе нет третьей цифры");
}
   