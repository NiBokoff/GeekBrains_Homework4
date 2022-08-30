// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow().
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < degree; i++)
{
    number_n *= number;
}
Console.WriteLine("{0} ^ {1} = {2}", number, degree, result);
