//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
void Cicle()
{
    while (true)
    {
        Console.WriteLine("Введите целое число (для выхода из программы введите q): ");
        string inputLine = Console.ReadLine();
        if (inputLine == "q")
        {
            Console.WriteLine("Программа завершена.");
            break;
        }
        else
        {
            int sumDigits = SumDigits(Convert.ToInt32(inputLine));
            if (sumDigits % 2 == 0)
            {
                Console.WriteLine("Сумма числа равна: " + sumDigits + " - четное число! Программа завершена!");
                break;
            }
        }
    }
}
Cicle();
//============================================================================
//МЕТОД ПОЛУЧЕНИЯ СУММЫ ЦИФР ЧИСЛА
int SumDigits(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
