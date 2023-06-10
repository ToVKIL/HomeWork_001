// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// 1. Запрос ввода первого числа +
// 2. Запрос ввода второго числа +
// 3. Сравнение двух чисел
// 4. Вывод результата

Console.WriteLine("enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write("Max=" + num1 + " Min=" + num2);
}
else
{
    Console.Write("Max=" + num2 + " Min=" + num1);
}

