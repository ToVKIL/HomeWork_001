// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// 1. Запрос ввода первого числа
// 2. Запрос ввода второго числа
// 3. Запрос ввода третьего числа
// 4. Сравнить первое и второе число, запомнить наибольшее
// 5. число из п.4 сравнить с третьим числом
// 6. Вывести результат

Console.WriteLine("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > num1) 
{
    max = num2;
}
else
{
    max = num1;
}

if (num3 > num2) 
{
    max = num3;
}
else
{
    max = num2;
}

Console.Write("Max = " + max);




