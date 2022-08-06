/* **Задача**: Написать программу, которая из имеющегося массива
строк формирует массив из строк, длина которых меньше либо 
равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении 
не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

**Примеры**:
[hello,2,world,:-)] -> ["2", ":-)"]
[1234,1567,-2,computer science] -> ["-2"]
[Russia,Denmark,Kazan] -> [] */

string[] result = CreateArray();
ArrayShort(result);

void ArrayShort(string[] arr)
{
    int size = 3;
    var value = string.Empty;
    string[] newarr = new string[arr.Length]; // создать новый массив
    for (int i = 0; i < arr.Length; i++)
    {
        value = arr[i];
        if (value.Length <= size) // если элемент на позиции меньше условия для отбора
            newarr[i] = arr[i];
    }
    newarr = newarr.Where(x => x != null).ToArray(); // чтобы убрать пустые позиции массива 
    Console.WriteLine($"Отобранный массив: [{string.Join(", ", newarr)}]");
}

string[] CreateArray()
{
    Console.WriteLine("Введите элементы массива через запятую: ");
    string[] array = Console.ReadLine()!.Split(',');
    Console.WriteLine($"Изначальный массив: [{string.Join(", ", array)}]");
    return array;
}
