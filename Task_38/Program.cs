// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Метод задает случайный массив double
double[] GetArray(int size, int startVaue, int endValue)
{
    Random random = new Random();
        double[] array=new double[size];
        double a1=0;
        double a2=1;
        Console.WriteLine($"Массив случайных чисел  размерностью {size} :");
    for (int i=0; i<array.Length; i++)
        {
            a1=random.Next(startVaue,endValue+1);
            a2=random.Next(1,endValue+1);
            array[i] =a1/a2;
           // Console.Write($" [{array[i]}] "); 
            Console.Write($" [{String.Format("{0:0.000}", array[i])}] ");
        }
   
    return array;
}
//Метод находит разницу между максимальным и минимальным элементом массива
double DifferenceMaxMin(double[] array)
{
    int lenghtArray=array.Length;
    double max=array[0];
    double min=array[0];
    for (int i=0; i<lenghtArray; i++)
    {
        if (array[i]>max) max=array[i];
        if (array[i]<min) min=array[i];
    }
    Console.WriteLine($"Максимальное число массива: {max}");
    Console.WriteLine($"Минимальное число массива: {min}");
    return max-min;
}
Console.Clear();
Console.WriteLine("Введите размерность массива");
try
{
int sizeArr=Math.Abs(Convert.ToInt32(Console.ReadLine()));

double[] arr=GetArray(sizeArr,-1000,1001);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом: {DifferenceMaxMin(arr)}");

}
catch(Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}