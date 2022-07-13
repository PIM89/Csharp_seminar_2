string FindTwo(string text)
{
    string a = "";
    if (text.Length < 3 || text.Length > 3) a = "Введено НЕ трёхзначное число!";
    else a = $"Вторая цифра этого числа: {text[1]}";
    return a;    
}

Console.Write("Введите трёхзначное число: ");
string num = Console.ReadLine();
Console.WriteLine(FindTwo(num));