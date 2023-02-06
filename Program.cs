// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

Console.Clear();

int GetFromUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(message);
    Console.ResetColor();
    int data = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    return data;
}

void PrintRange(int N)
{
    if (N==0)
    {
        return;
    }
    Console.Write(N + ",");
    PrintRange(N - 1);
}

int userNumber = GetFromUserData("Введите значение границы ряда: ");
PrintRange(userNumber);
Console.Write("\b \b");