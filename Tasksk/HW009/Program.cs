// // В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] array = new double[10];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    
    {
        array[i] = random.NextDouble() * 100;
        Console.Write("{0,6:F2}", array[i]);
    }
}   
double max = 0;
double min = 0;
if(array [i]> max) max = array[i];

Console.WriteLine("MAX" + max);