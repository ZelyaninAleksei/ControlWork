// Задача: Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше или равна 3 символа. Первоначально массив можно
// ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] BasicArray(string message)
{
    Console.WriteLine(message);
    int size = Convert.ToInt32(Console.ReadLine());
    string[] basicArray = new string[size];
    return basicArray;
}

void FillingArray(string[] basicArray)
{
    for (int i = 0; i < basicArray.Length; i++)
    {
        System.Console.WriteLine($"Веедите значение элемента {i} - >");
        basicArray[i] = Console.ReadLine();
    }
}

int CheckLength(string[] basicArray)
{
    int count = 0;

    for (int i = 0; i < basicArray.Length; i++)
    {
        if (basicArray[i].Length <= 3)
        {
            count++;
        }
    }

    return count;
}

string[] CreateNewArray(string[] basicArray, int newSize)
{
    string[] newArray = new string[newSize];

    int j = 0;
    for (int i = 0; i < basicArray.Length; i++)
    {
        if (basicArray[i].Length <= 3)
        {
            newArray[j] = basicArray[i];
            j++;
        }
    }

    return newArray;
}

void PrintArray(string[] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

// 1. Создать массив
string[] basicArray = BasicArray("Введите размер массива -> ");

// 2. Заполнить массив
FillingArray(basicArray);

// 3. Определить размерность нового массива, подходящим по условию длины элементов
int newSize = CheckLength(basicArray);

// 4. Сформировать новый массив 
string[] newArray = CreateNewArray(basicArray, newSize);

// 5. Вывести стратовый массив и итоговый массив
PrintArray(basicArray, "Базовый массив ->");
PrintArray(newArray, "Итоговый массив ->");