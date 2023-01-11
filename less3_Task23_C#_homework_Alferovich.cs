// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Пожалуйста, введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = new int[num];
Console.WriteLine("Таблица кубов от 1 до введённого числа:");
for (int index = 0; index < num; index++)
{
    array[index] = (index + 1) * (index + 1) * (index + 1);
        Console.WriteLine($"{(index + 1)}*{(index + 1)}*{(index + 1)}={array[index]}");
}