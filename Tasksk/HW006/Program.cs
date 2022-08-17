// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] array = new int[9];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);

    Console.Write($" {array[i]}");
}
for (int a = 0; a < array.Length; a++)
{
    if (array[a] >= 1 - array[a] <= 5)
        sum = sum + 1;


}
Console.Write($" Сумма элементов отрезка [10, 99]: {sum}  ");