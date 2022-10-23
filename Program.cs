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

/* 3. задача на определение, является ли число чётным
Console.WriteLine("Введите целое число");
int N = int.Parse(Console.ReadLine());
int ostatok=N%2;
if (ostatok==0) Console.WriteLine("чисто чётное");
else Console.WriteLine("число нечётное");
*/

/* 4. все чётные числа от 1 до N
Console.WriteLine("Введите положительное число N больше 1");
int N = int.Parse(Console.ReadLine());
int k=2;
int ost=N%2;
while (k<N){
    Console.Write(k+", ");
    k=k+2;
}
if (ost==0) Console.Write(k);
*/

// 5. Определение, какая сумма элементов массива больше – с первого до элемента с номером К, или от элемента с номером К+1 до последнего
Console.WriteLine("Введите число элементов массива");
int length = int.Parse(Console.ReadLine());
int[] array = new int[length];
int index=0;
Console.WriteLine("Введите массив столбцом");
while (index<length){
    int elementmassiva = int.Parse(Console.ReadLine());
    array[index]=elementmassiva;
    index++;
}
int sum1=0;
int ind=0;
Console.WriteLine("Введите номер элемента - K");
int K = int.Parse(Console.ReadLine());
while (ind<(K-1)){
    sum1=sum1+array[ind];
    ind++;
}
int sum2=0;
int indx=K;
while (indx<length){
    sum2=sum2+array[indx];
    indx++;
}
if (sum1>sum2) Console.WriteLine("Сумма элементов первой части массива больше");
else if (sum1<sum2) Console.WriteLine("Сумма элементов второй части массива больше");
else Console.WriteLine("Обе части массива равны");



