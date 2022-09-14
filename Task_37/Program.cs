//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
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

int[] NewArray(int[] array)
{
    
    int lenghtArray=array.Length;
    int lenghtArrayNew=0;
    if (lenghtArray%2==0) {lenghtArrayNew=lenghtArray/2;}
    else {lenghtArrayNew=lenghtArray/2+1;}
    Console.WriteLine($"Новый массив размерностью {lenghtArrayNew}:");
    int[] newArray=new int[lenghtArrayNew];
    for (int i=0; i<lenghtArray/2; i++)
            {
                newArray[i]=array[i]*array[lenghtArray-i-1];
                Console.Write($"  {newArray[i]}");
            }
   
    if (lenghtArray%2!=0)       
    {
        newArray[lenghtArrayNew-1]=array[lenghtArrayNew-1];
        Console.Write($"  {newArray[lenghtArrayNew-1]}");
    }
    return newArray;
}
Console.Clear();
Console.WriteLine("Введите размерность массива");
try
{
int sizeArr=Math.Abs(Convert.ToInt32(Console.ReadLine()));

int[] arr=GetArray(sizeArr,-10,11);
Console.WriteLine();
int[] nArr=NewArray(arr);
}
catch(Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}