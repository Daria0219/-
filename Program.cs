// Задача1
Console.WriteLine("Введите любое целое число");
int N = int.Parse(Console.ReadLine());
int temp = 0;
int sum = 0;
while (N!=0)
{
    temp = N%10;
    sum = sum +temp;
    N=N/10;
}
Console.WriteLine(sum);




