// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
//   index      0    1   2   3   4   5   6   7
// FillAraay - заполнить массив.
void FillAraay(int[] numbers)  // Метод void не возвращает значения!!! (не нужен return)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(0, 2);

        index++;
    }
}
// PrintArray - распечатывает массив
void PrintArray(int[] num)
{
    int count = num.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(num[pos] + ",");
        pos++;
    }
}
int[] array = new int[8];
FillAraay(array);
PrintArray(array);