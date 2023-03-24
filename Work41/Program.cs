// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}

int Zero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            count++;
    return count;
}


Console.WriteLine("Введите целое число:");
int arrayLenth = (Convert.ToInt32(Console.ReadLine()));
int [] array = new int [arrayLenth];
FillArray(array);
PrintArray(array);
;
Console.WriteLine($"Чисел меньше нуля в массиве: {Zero (array)}");