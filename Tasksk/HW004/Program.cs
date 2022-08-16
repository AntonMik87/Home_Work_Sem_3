// Определить, присутствует ли в заданном массиве, некоторое число
Console.WriteLine("Введите число: " );
int n = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[10];
Console.WriteLine(" ");
for (int i = 0; i < array.Length; i++)
{

    array[i] = new Random().Next(1, 10);
    Console.WriteLine(array[i]);
    if (array[i] == n)
    {

        Console.Write("Индекс совпавшего числа: " + i);
        break;
    }
}

