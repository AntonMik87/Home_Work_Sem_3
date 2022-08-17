// Найти сумму чисел одномерного массива стоящих на нечетной позиции

//               0   1  2    3   4  5   6    7   8
int[] array = { 11, 23, 34, 44, 56, 16, 71, 18, 19 };
for (int i = 0; i < array.Length; i++)
{
    Console.Write($" {array[i]}");
}
Console.Write(" ");
int SumNechet = 0;
for (int j = 1; j < array.Length; j++)
{
    if (j % 2 != 0) SumNechet = SumNechet + array[j];
    
}
Console.Write($" Сумма нечетных элементов массива: {SumNechet}");