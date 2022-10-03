Console.WriteLine("Введите трехзначное число");
int n = int.Parse(Console.ReadLine());
int first = n/100;
int second = n%100;
int third = second/10;
Console.Write("Вторая цифра числа - " + third);
