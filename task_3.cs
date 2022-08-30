// (Дополнительная, не обязательная задача): Назовём число «интересным» если его произведение цифр делится на их сумму. Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел. (Каждый эл-т массива должен быть сгенерирован случайно)
using System.Collections.Generic;
int number = new Random().Next(1, 100000);
int total_sum = 0;
int total_prod = 1;
int num = number;
List<int> N = new List<int>();
while (number > 0)
{
    total_sum += n % 10;
    total_prod *= n % 10;
    n /= 10;
}
if (total_prod / total_sum == 0)
{
    list.Add(num);
}
int[] terms = N.ToArray();
Console.WriteLine(terms);