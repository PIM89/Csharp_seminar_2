int day(int number)
{
    if (number > 0 && number < 6) Console.WriteLine($"{number} день недели НЕ является выходным!");
    else if (number > 5 && number < 8) Console.WriteLine($"{number} день недели является выходным!");
    else Console.WriteLine("Введены не верные данные!");
    return number;
}

Console.Write("Введите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
day(num);