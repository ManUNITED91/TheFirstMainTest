// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] firstArr = { "Arsenal", "Hello", "you", "32", "8" };
string[] secArr = { "Russia", "Denmark", "Kazan" };
string[] thirdArr = { "Hello", "2", "world", ":-)" };

string[] ArrString(string[] arr)
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            size++;
        }
    }

    string[] arr2 = new string[size];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arr2[index] = arr[i];
            index++;
        }
    }
    return arr2;
}

void Print(string[] arr)
{
    Console.Write("---> [ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} ");

    }
    Console.Write(" ]");
    Console.WriteLine();

}
Print(ArrString(firstArr));
Print(ArrString(secArr));
Print(ArrString(thirdArr));

