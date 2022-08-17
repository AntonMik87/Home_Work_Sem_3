// Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

int[] array = new int[15];
int chet = 0;
int nechet = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 150);

    Console.Write($"{array[i]}   ");
}
Console.WriteLine(" ");
for (int a = 0; a < array.Length; a++)
{
    if (array[a] % 2 == 0) chet++;
    else nechet++;
}
Console.WriteLine($"Количество четных: {chet} ");
Console.WriteLine($"Количество нечетных: {nechet} ");




// int a = 0;
// while (a < array.Length)
// {
//     if (array[a] % 2 == 0)
//     {
//         chet = chet + 1;
//     }
//     else
//     {
//         if (array[a] % 2 != 0)
//             nechet = nechet + 1;
//     }
//     a++;
// }