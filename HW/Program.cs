
Console.Write("Решение 34 задачи");
void Zadacha34()
{
    Random random = new Random();
    int size = random.Next(4,10);
    int[] array= new int[size];
    FillArray(array, 100,1000);
    PrintArray(array); 
    Console.WriteLine($"количество четных чисел в массиве: {CountMetod(array)}");
    Console.WriteLine();
}
int CountMetod(int[] array)
{   
    int count =0;
    for(int i =0; i < array.Length; i++)
    {
        if (array[i] %2 == 0)
        count++;
    }
    return count;
}    
 void FillArray(int[] array, int startNumber = 0, int finishNumber =0)
{
    finishNumber++;
    Random random = new Random();

    for (int i=0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber,finishNumber);
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}    
Zadacha34();


Console.Write("Решение 36 задачи");
void Zadacha36()
{
    Random random = new Random();
    int size = random.Next(3,10);
    int[] array= new int[size];
    FillArray(array, 1,10);
    PrintArray(array); 
    Console.WriteLine($"Сумма элементов на нечетных позициях: {SumNumber(array)}");
    Console.WriteLine();
}
int SumNumber(int[] array)
{
    int sum=0;
   for(int i =0; i < array.Length; i++)
    {
        if (i %2 == 1)
        sum = sum + array[i];
    }
    return sum; 
}
Zadacha36();


Console.Write("Решение 38 задачи");
void Zadacha38()
{
    Random random = new Random();
    int size = random.Next(3,8);
    double[] array= new double[size];
    dFillArray(array, 1,100);
    dPrintArray(array); 
    Console.WriteLine("Максимальное число: "+ maxNumber(array));
    Console.WriteLine("Минимальное число: "+ minNumber(array));
    Console.WriteLine($"Разница между мах и мин числами равна: {maxNumber(array) - minNumber(array) }");
    Console.WriteLine();
    
}
double maxNumber(double[] array)
{
    double maxNum=array[0];
   for(int i =0; i < array.Length; i++)
    {
        if (array[i] >  maxNum)
        maxNum = array[i];
    }
    return maxNum; 
}
double minNumber(double[] array)
{
    double minNum=array[0];
   for(int i =0; i < array.Length; i++)
    {
        if (array[i] <  minNum)
        minNum = array[i];
    }
    return minNum; 
}

void dFillArray(double [] array, int startNumber = 0, int finishNumber = 0)
{
    finishNumber++;
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber)*0.1;
    }
}
void dPrintArray(double[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}
Zadacha38();