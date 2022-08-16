// Задать массив из 12 элементов, заполненных числами из [-10,10]. 
// Найти сумму положительных/отрицательных элементов массива
int[] array = new int[12];
int sumPl = 0;
int sumMi = 0;

for (int i = 0; i < array.Length; i++)
{

    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i] + " ");
    if (array[i] >= 0)
    {
        sumPl = sumPl + array[i];
    }
    else
    {
        sumMi = sumMi + array[i];
    }
}
Console.WriteLine(" ");
Console.WriteLine("Положительные числа, сумма: " + sumPl);
Console.WriteLine("Отрицательные числа, сумма: " + sumMi);