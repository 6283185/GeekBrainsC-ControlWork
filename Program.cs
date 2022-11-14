// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
//  длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
//   либо задать на старте выполнения алгоритма.
//    При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array1 = new string[] { "123", "23", "hello", "world", "res"};

int limit = 3; // переменная limit определяет разрешенную длину элементов, которые будут перенесены в результирующий массив.

string[] ArrayToLess3SymbolsPerElement(string[] array, int limitForElementLenght) // принимаемые аргументы: 1) массив из строк и 2) ограничение на длину элемента помещаемового в новый массив
{
    int count = 0;
    string[] arrayRes = new string[array.Length];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= limitForElementLenght)
        {
            arrayRes[count] = array[i];
            count++;
        }
    }
    return arrayRes;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
string[] arrayToLess3SymbolsPerElement = ArrayToLess3SymbolsPerElement(array1, limit);
PrintArray(arrayToLess3SymbolsPerElement);