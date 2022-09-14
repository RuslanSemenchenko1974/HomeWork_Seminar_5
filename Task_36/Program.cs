// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//Console.WriteLine("Hello, World!");
int[] GetArray(int size, int startVaue,int endValue)
{
    var random=new Random();
    int[] array=new int[size];
    int count=0;
    Console.WriteLine($"Массив случайных чисел от {startVaue} до {endValue-1} размерностью {size} :");
    for (int i=0; i<array.Length; i++)
        {
            array[i] =random.Next(startVaue,endValue+1);
            Console.Write($" {array[i]}");
        }
   
    return array;
}
// Метод вычисляет сумму элементов на нечетных позициях
int SummOddPosition(int[] array)
{
    int lenghtArray=array.Length;
    int summ=0;
    Console.WriteLine("Нечетные элементы :");
    for (int i=0; i<lenghtArray; i=i+2)
    {
        summ=summ+array[i];
        Console.Write($" {array[i]}");
    }
    return summ;
}
Console.Clear();
Console.WriteLine("Введите размерность массива");
try
{
int sizeArr=Math.Abs(Convert.ToInt32(Console.ReadLine()));

int[] arr=GetArray(sizeArr,-10,11);
Console.WriteLine();
int summOdd=SummOddPosition(arr);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях  : {summOdd}");

}
catch(Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}