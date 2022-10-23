// 1.задача с нахождением max и min значение их двух чисел

Console.WriteLine("Введите два целых числа");
int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
if (N>M) Console.WriteLine($"max={N}, min={M}");
else if (N<M) Console.WriteLine($"max={M}, min={N}");
else if (N==M) Console.WriteLine("числа равны");