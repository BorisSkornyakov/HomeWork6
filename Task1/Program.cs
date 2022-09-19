// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int DataEntry(string message)                                               //Метод ввода данных
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] MassiveDataEntry(int size)                                            //Метод ввода элементов массива
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = DataEntry($"Введите {i + 1}-й элемент массива ");
    }
    return numbers;
}

int CountingPositiveValues(int[] numbers)                                   //Метод подсчета значений больше 0
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
            count += 1;
    }
    return count;
}
int size = DataEntry("Введите размер массива чисел ");
int[] num = MassiveDataEntry(size);
int result = CountingPositiveValues(num);
System.Console.Write("В массиве [{0}]", string.Join(", ", num));
System.Console.WriteLine($" {result} чисел больше 0");