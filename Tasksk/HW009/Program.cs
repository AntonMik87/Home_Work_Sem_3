// // В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] array = new double[10];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{


    array[i] = random.NextDouble() * 100;
    Console.Write(" {0,6:F2} ", array[i]);

}
double max = array[0];
double min = array[0];
for (int g = 0; g < array.Length; g++)
{
    if (array[g] > max) max = array[g];
    if (array[g] < min) min = array[g];
}
Console.Write(" MAX:" + "{0,6:F2}", max);
Console.Write(" ");
Console.Write(" MIN:" + "{0,6:F2}", min);
Console.Write(" ");
Console.Write(" MAX - MIN:" + "{0,6:F2}", max - min);