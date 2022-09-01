// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа. (для получения цифр числа операцию приведения числа к строке не использовать).
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = number;
int total = 0;
while (number > 0 && number % 10 != 0)
{
    if (num % (number % 10))
        total += number % 10;
    number /= 10;
}
Console.Write(total);