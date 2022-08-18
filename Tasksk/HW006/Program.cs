// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] array = new int[123];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 123);

    Console.Write($" {array[i]}");
}
for (int a = 0; a < array.Length; a++)
{
    if (array[a] >= 10 && array[a] <= 99)
        sum = sum + 1;


}
Console.Write($" Количество элементов отрезка [10, 99]: {sum}  ");
