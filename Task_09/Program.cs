int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка [10, 99] = {number}");
// int first = number / 10;
// int second = number % 10;
// if (first > second) Console.WriteLine($"Наибольшая цифра числа -> {first}");
// else Console.WriteLine($"Наибольшая цифра числа -> {second}");

// int maxDigit = first > second ? first : second;
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit(int num)
{
    int first = num / 10;
    int second = num % 10;
    return first > second ? first : second;
}

