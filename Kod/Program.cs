// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.


Console.Write("Введите элементы массива через пробел в одну строку: ");  // Запрашиваем у пользователя ввести элементы массива строк
string text = Convert.ToString(Console.ReadLine());
string[] StringArray = text.Split(' ');       // Метод Split() возвращает массив строк, сгенерированный путем разделения исходной строки, разделенных пробелом 

int size = StringArray.Length;
Console.Write("[ ");                           // Печать элеметов заданного массива строк
for (int i = 0; i < StringArray.Length; i++)
{
    if (i < StringArray.Length - 1)
    {
        Console.Write($"'{StringArray[i]}', ");
    }
    else { Console.Write($"'{StringArray[i]}' ]"); }
}

string[] SortiArray = new string[size];   // Формирование массива строк, в котором длина элемента не более или равно 3 символам
int j = 0;
for (int i = 0; i < size; i++)
{
    int dlina = StringArray[i].Length;
    if (dlina <= 3 && dlina != 0)
    {
        SortiArray[j] = StringArray[i];
        j = j + 1;
    }
}

Console.Write($" -> [ ");                   // Печать нового массива
for (int i = 0; i < j; i++)
{
    if (i < j - 1)
    {
        Console.Write($"'{SortiArray[i]}', ");
    }
    else Console.Write($" '{SortiArray[i]}'");
}
Console.Write($" ]");
Console.WriteLine();


