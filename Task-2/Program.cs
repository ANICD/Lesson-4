//Задача 2: Задайте массив заполненный случайными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
int[] myArr = FillArray(1000);
int evenCount = 0;
for (int i = 0; i <= myArr.Length - 1; i++)
{
    if (myArr[i] % 2 == 0)
        evenCount++;
}
Console.WriteLine("Количество четных чисел в массиве = " + evenCount);
//=======================================================================
//МЕТОД ЗАПОЛНЕНИЯ МАССИВА
int[] FillArray(int numElements)
{
    int[] array = new int[numElements];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
