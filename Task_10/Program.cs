string FindTwo(string text)
{
    if (text.Length < 3 || text.Length > 3) Console.Write("Введено НЕ трёхзначное число!");
    else Console.Write($"Вторая цифра этого числа: {text[1]}");
    return text;
}

Console.Write("Введите трёхзначное число: ");
string num = Console.ReadLine();
FindTwo(num);