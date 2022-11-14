// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
//  длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
//   либо задать на старте выполнения алгоритма.
//    При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array1 = new string[] { "123", "23", "hello", "world", "res" };

string[] ArrayToLess3SymbolsPerElement(string[] array)
{
    int count = 0;
    string[] arrayRes = new string[array.Length];
    for (int i = 0; i < array1.Length; i++)
    {
        if (array[i].Length <= 3)
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
string[] arrayToLess3SymbolsPerElement = ArrayToLess3SymbolsPerElement(array1);
PrintArray(arrayToLess3SymbolsPerElement);