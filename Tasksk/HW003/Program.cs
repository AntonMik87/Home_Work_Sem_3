// Написать программу замену элементов массива на противоположные

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i] + " ");

    if (array[i] < 0)
    {
        array[i] = array[i] * -1;
    }
    else
    {
        array[i] = -array[i];
    } 
     Console.Write("  ");
    Console.WriteLine(array[i]);
}