// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

int[] array = new int[8];
int sumChet = 0;
// int sumNech = 0;
for (int i = 0; i < array.Length; i++)
{

    array[i] = new Random().Next(1, 8);
    Console.WriteLine(array[i]);
    if (array[i] % 2 == 0)
    {

        sumChet = array[i];
    }

}

Console.WriteLine($"количество четных: {sumChet}");