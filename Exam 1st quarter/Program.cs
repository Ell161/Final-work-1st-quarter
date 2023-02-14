// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


void FillArray()
// A method that, from an existing array of strings, forms an array of strings whose length is less than or equal to 3 characters.

{
    string tempString = "";
    int lenghtArray;
    Console.Write("Введите количество элементов массива: ");
    try {lenghtArray = Convert.ToInt32(Console.ReadLine());}
    catch 
    {
        Console.Write("Ошибка ввода. Введите количество элементов массива: ");
        lenghtArray = Convert.ToInt32(Console.ReadLine());
    }

    string[] currentArray = new string[lenghtArray];
    for (int i = 0; i < lenghtArray; i++)
    {
        Console.Write($"Задайте {i + 1}й элемент массийва: ");
        currentArray[i] = Convert.ToString(Console.ReadLine());
        if (currentArray[i].Length <= 3) tempString = tempString + currentArray[i] + " ";
    }

    string[] finalArray = tempString.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);

    Console.WriteLine($"\nНачальный массив {string.Join(", ", currentArray)}");
    Console.WriteLine($"Итоговый массив {string.Join(", ", finalArray)}");
}

FillArray();