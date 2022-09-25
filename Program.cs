/*
Задача: Написать программу, которая из имеющегося массива строк формирует
 новый массив из строк, длина которых меньше, либо равна 3 символам.
 Первоначальный массив можно ввести с клавиатуры, либо задать 
 на старте выполнения алгоритма. При решении не рекомендуется 
 пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

*/
Console.Clear();
string [] array = new string[] {"Hello", "2", "world", ":-)"};
PrintArray (array);
Console.WriteLine();
GetNewArray (array);

void PrintArray (string [] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
    }

void GetNewArray (string [] arr)
    {
        int count = 4;
        for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length < count)
                    {
                        Console.Write($"{arr[i]} ");
                    }
            }
    }