// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

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

// Резудьтат PS F:\Lessons\Hoom_Work_Sem_3\Tasksk\HW001> dotnet run
// 1,0,1,1,0,1,1,0,