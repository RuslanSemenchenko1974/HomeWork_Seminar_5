// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
//
int[] GetArray(int size)
{
    var random=new Random();
    int[] array=new int[size];
    int count=0;
    Console.WriteLine($"Массив случайных чисел от {100} до {999} размерностью {size} :");
    for (int i=0; i<array.Length; i++)
        {
            array[i] =random.Next(100,1000);
            Console.Write($" {array[i]}");
        }
   
    return array;
}

int ShowEvenNumber(int[] array)
{
    int lenghtArray=array.Length;
    int count=0;
    Console.WriteLine("Четные числа :");

    for (int i=0; i<lenghtArray; i++)
            {
                if (array[i]%2==0)
                {
                    Console.Write($"  {array[i]}");
                    count++;
                }
            }
    Console.WriteLine();
    return count;
}

Console.Clear();
Console.WriteLine("Введите размерность массива");
try
{
int sizeArr=Math.Abs(Convert.ToInt32(Console.ReadLine()));

int[] arr=GetArray(sizeArr);
Console.WriteLine();
int number=ShowEvenNumber(arr);
Console.WriteLine($"Количество четных чисел массива  :{number}");

}
catch(Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}