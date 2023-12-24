//Задача 3: Напишите программу, которая перевернёт одномерный массив
Console.WriteLine("Введите количество элементов массива: ");
int inputData = Convert.ToInt32(Console.ReadLine());
int[] myArr = FillArray(inputData);//Заполнили массив
Console.WriteLine("Массив, который заполнили: ");
PrintArray(myArr);
Console.WriteLine("Массив, который перевернули: ");
InvertArray(myArr);
PrintArray(myArr);
//==================================================
//МЕТОД ПЕРЕВОРОТА МАССИВА
void InvertArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length / 2; i++)
    {
        int curElement = array[i];
        array[i] = array[length - 1 - i];
        array[length - 1 - i] = curElement;
    }
}
//===================================================
//МЕТОД ЗАПОЛНЕНИЯ МАССИВА
int[] FillArray(int numElements)
{
    int[] array = new int[numElements];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        array[i] = new Random().Next(10, 100);
    }
    return array;
}
//===================================================
//МЕТОД ВЫВОДА МАССИВА НА ЭКРАН
void PrintArray(int[] array)
{
    int element;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        element = array[i];
        Console.Write(element + " ");
    }
    Console.WriteLine();
}