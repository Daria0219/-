/* 1. задача с нахождением max и min значение их двух чисел
Console.WriteLine("Введите два целых числа");
int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
if (N>M) Console.WriteLine($"max={N}, min={M}");
else if (N<M) Console.WriteLine($"max={M}, min={N}");
else if (N==M) Console.WriteLine("числа равны");
*/

/* 2. максимальное из трёх чисел
Console.WriteLine("Введите три целых числа");
int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
int P = int.Parse(Console.ReadLine());
int max=N;
if (P>max) max=P;
if (M>max) max=M;
Console.WriteLine(max);
*/

// 3. задача на определение, является ли число чётным
Console.WriteLine("Введите целое число");
int N = int.Parse(Console.ReadLine());
int ostatok=N%2;
if (ostatok==0) Console.WriteLine("чисто чётное");
else Console.WriteLine("число нечётное");