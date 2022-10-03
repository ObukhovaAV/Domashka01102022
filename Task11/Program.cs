Console.WriteLine("Введите  число х");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число y");
int y = int.Parse(Console.ReadLine());
int z = x%y;

if (x%y==0)
{
    Console.Write(x + " кратно " + y);
}
else 
{
    Console.WriteLine(x + " не кратно " + y);
    Console.Write("Остаток от деления " + z);
}