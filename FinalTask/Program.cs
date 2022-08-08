Console.WriteLine("Сколько элементов вы хотите ввести?");
int Т = Convert.ToInt32(Console.ReadLine());
string[] array = new string[Т];
string[] newArray = new string[array.Length];
for (int i = 0; i < Т; i++)
{
    Console.Write($"Введите {i + 1} элемент: "); // to culculate the order in user's way 1, 2, 3...
    array[i] = Console.ReadLine();
}
void SelectString(string[] array, string[] newArray)
{
    int number = 0;
    int length = 4; // 3+1 to build the strict border
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < length)
        {
            newArray[number] = array[i];
            number++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Исходный массив: ");
PrintArray(array);
SelectString(array, newArray);
Console.WriteLine("Полученный массив: ");
PrintArray(newArray);

