// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, 
// в том числе для отрицательных индексов.
// *Пример:*
// - для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]





int[] Fibon(int count)
{
    int[] res = new int[count];
    res[0] = 0;
    res[1] = 1;
    for (int i = 2; i < res.Length; i++)
    {
        res[i] = res[i - 2] + res[i - 1];
    }
    return res;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}

void PrintRevFib(int [] array ,int num)
{
    for (int i = num -1; i > 0; i--)
    {
        if (i % 2 == 0)
            array[i] *= (-1);
        Console.Write($"{array[i]} ");
    }
}

System.Console.WriteLine("Введите номер числа фиббоначи: ");
int num = Convert.ToInt32(Console.ReadLine());
PrintRevFib(Fibon(num), num);
PrintArray(Fibon(num));