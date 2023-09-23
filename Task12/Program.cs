// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int MultipleNumber(int fDigit, int sDigit)
{
    return fDigit % sDigit;
}

int remainderNumber = MultipleNumber(firstNumber, secondNumber);

if (remainderNumber == 0) Console.WriteLine($"{firstNumber}, {secondNumber} -> кратно");
else Console.WriteLine($"{firstNumber}, {secondNumber} -> не кратно, остаток {remainderNumber}");
