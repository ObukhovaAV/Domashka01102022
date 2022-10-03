Console.WriteLine("Введите число от 10 до 99");
int n = int.Parse(Console.ReadLine());
int first = n/10;
int second = n%10;
if (first>second)
{
    Console.Write(first);
}
else if (first<second)
{
    Console.Write(second);
}
else 
{
    Console.Write("Цифры равны");
}
