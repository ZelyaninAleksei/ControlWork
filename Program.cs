// Задача: Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше или равна 3 символа. Первоначально массив можно
// ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] BasicArray (string message)
{
    Console.WriteLine(message);
    int size = Convert.ToInt32(Console.ReadLine());
    string[] basicArray = new string[size];
    return basicArray;
}

void FillingArray (string[] basicArray)
{
    for (int i = 0; i < basicArray.Length; i++)
    {
        System.Console.WriteLine($"Веедите значение элемента {i} - >");
        basicArray[i] = Console.ReadLine();
    }
}


// 1. Создать массив
string[] basicArray = BasicArray("Введите размер массива -> ");
// 2. Заполнить массив
FillingArray(basicArray);

// 3. Создать цикл проверки элементов на трёхзначность

// 4. Сформировать новый массив 

// 5. Вывести стратовый массив и итоговый массив
