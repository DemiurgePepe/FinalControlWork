
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → [] --> -->



int UserInput(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

string UserInputString(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    // int result = Convert.ToInt32(value);
    return value;
}
string [] CreateStringArray(int size)
{
    string [] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        array[i] =  UserInputString("Введите текст: ");
    }
    return array;
}

void PrintStringArray(string[] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    System.Console.WriteLine("]");
}   
string [] FindShortTextInArray(string [] array)
{
    string [] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=3) newArray[i]=array[i];
    }
    return newArray;
}
int size = UserInput("Введите размер массива: ");
string [] array  = CreateStringArray(size);
PrintStringArray(array);
System.Console.WriteLine();
array=FindShortTextInArray(array);
PrintStringArray(array);






