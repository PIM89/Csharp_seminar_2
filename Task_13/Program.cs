string FindThree(string text)
{
    if (text.Length < 3) Console.Write("Третьей цифры нет!");
    else Console.Write($"Третья цифра этого числа: {text[2]}");
    return text;
}

Console.Write("Введите число: ");
string num = Console.ReadLine();
FindThree(num);