// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.Write("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n]; 

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1001);
    }
}

void PositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    Console.WriteLine("Количество положительных чисел: " + count);
}

FillArray(array);
Console.WriteLine("[ " + string.Join(", ", array) + " ]");
PositiveNumber(array);