//Функции
//Функция заполнения исходного массива
void GetArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(11);
        Console.Write(arr[i, j] + "\t");

    }
    Console.WriteLine();
}
Console.WriteLine();
}
//Функция просчета массива средних арифметических
void CountAverage(int[,] ar1, double [] ar2)
{
    for(int j = 0; j < ar1.GetLength(1); j++)
    {
        double sum = 0;
         for(int i = 0; i < ar1.GetLength(0); i++)
        {
            sum += ar1[i, j];
        }
        ar2[j] = sum / ar1.GetLength(0);
    }
}
//Функция вывода массива средних арифметических чисел
void PrintArray(double[] ar)
{
    for(int l=0; l<ar.Length-1 ;l++)
{
    Console.Write($"{ar[l]}" + "; ");
}
Console.Write($"{ar[ar.Length-1]}" + ". ");
}
///////////////////////////////////////////////////////////////////////////////////////////////////
//объявление массивов и ввод исходного массива
int[,] array = new int[4, 3];
double[] average = new double[array.GetLength(1)];
GetArray(array);
//расчет и вывод среднего арифметического
CountAverage(array,average);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(average);