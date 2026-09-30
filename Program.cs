using System;

namespace lab1
{
    // Главный класс с точкой входа.
    public class Program
    {
        public static void Main(string[] args)
        {
            Tasks lab = new Tasks();

            Console.WriteLine("=== Лабораторная работа №1 ===");

            // ---------- Задание 1. Методы ----------
            Console.WriteLine("\n=== Задание 1. Методы ===");

            Console.WriteLine("\n-- Задача 2. Сумма знаков --");
            int x1 = lab.ReadIntAtLeastTwoDigits("Введите число (не менее двух знаков): ");
            Console.WriteLine("Результат: " + lab.SumLastNums(x1));

            Console.WriteLine("\n-- Задача 4. Положительное ли число --");
            int x2 = lab.ReadInt("Введите число: ");
            Console.WriteLine("Результат: " + lab.IsPositive(x2));

            Console.WriteLine("\n-- Задача 6. Большая буква --");
            char c1 = lab.ReadChar("Введите символ: ");
            Console.WriteLine("Результат: " + lab.IsUpperCase(c1));

            Console.WriteLine("\n-- Задача 8. Делитель --");
            int a1 = lab.ReadInt("Введите a: ");
            int b1 = lab.ReadInt("Введите b: ");
            Console.WriteLine("Результат: " + lab.IsDivisor(a1, b1));

            Console.WriteLine("\n-- Задача 10. Многократный вызов (5 чисел) --");
            int a2 = lab.ReadInt("Введите 1-е число: ");
            int b2 = lab.ReadInt("Введите 2-е число: ");
            int c2 = lab.ReadInt("Введите 3-е число: ");
            int d2 = lab.ReadInt("Введите 4-е число: ");
            int e2 = lab.ReadInt("Введите 5-е число: ");
            Console.WriteLine("Результат: " + lab.LastNumSum(a2, b2, c2, d2, e2));

            // ---------- Задание 2. Условия ----------
            Console.WriteLine("\n=== Задание 2. Условия ===");

            Console.WriteLine("\n-- Задача 2. Безопасное деление --");
            int x3 = lab.ReadInt("Введите x: ");
            int y3 = lab.ReadInt("Введите y: ");
            Console.WriteLine("Результат: " + lab.SafeDiv(x3, y3));

            Console.WriteLine("\n-- Задача 4. Строка сравнения --");
            int x4 = lab.ReadInt("Введите x: ");
            int y4 = lab.ReadInt("Введите y: ");
            Console.WriteLine("Результат: " + lab.MakeDecision(x4, y4));

            Console.WriteLine("\n-- Задача 6. Тройная сумма --");
            int x5 = lab.ReadInt("Введите x: ");
            int y5 = lab.ReadInt("Введите y: ");
            int z5 = lab.ReadInt("Введите z: ");
            Console.WriteLine("Результат: " + lab.Sum3(x5, y5, z5));

            Console.WriteLine("\n-- Задача 8. Возраст --");
            int age = lab.ReadNonNegativeInt("Введите возраст: ");
            Console.WriteLine("Результат: " + lab.Age(age));

            Console.WriteLine("\n-- Задача 10. Дни недели --");
            Console.Write("Введите день недели: ");
            lab.PrintDays(Console.ReadLine());

            // ---------- Задание 3. Циклы ----------
            Console.WriteLine("\n=== Задание 3. Циклы ===");

            Console.WriteLine("\n-- Задача 2. Числа наоборот --");
            int x6 = lab.ReadNonNegativeInt("Введите число: ");
            Console.WriteLine("Результат: " + lab.ReverseListNums(x6));

            Console.WriteLine("\n-- Задача 4. Возведение в степень --");
            int x7 = lab.ReadInt("Введите основание: ");
            int y7 = lab.ReadNonNegativeInt("Введите степень: ");
            Console.WriteLine("Результат: " + lab.Pow(x7, y7));

            Console.WriteLine("\n-- Задача 6. Одинаковость --");
            int x8 = lab.ReadInt("Введите число: ");
            Console.WriteLine("Результат: " + lab.EqualNum(x8));

            Console.WriteLine("\n-- Задача 8. Левый треугольник --");
            int x9 = lab.ReadNonNegativeInt("Введите высоту: ");
            lab.LeftTriangle(x9);

            Console.WriteLine("\n-- Задача 10. Угадайка --");
            lab.GuessGame();

            // ---------- Задание 4. Массивы ----------
            Console.WriteLine("\n=== Задание 4. Массивы ===");

            Console.WriteLine("\n-- Задача 2. Поиск последнего значения --");
            int[] arr1 = lab.ReadArray("Введите массив через пробел: ");
            int find = lab.ReadInt("Введите искомое число: ");
            Console.WriteLine("Результат: " + lab.FindLast(arr1, find));

            Console.WriteLine("\n-- Задача 4. Добавление в массив --");
            int[] arr2 = lab.ReadArray("Введите массив через пробел: ");
            int val = lab.ReadInt("Введите значение: ");
            int pos = lab.ReadInt("Введите позицию: ");
            Console.WriteLine("Результат: " + string.Join(" ", lab.Add(arr2, val, pos)));

            Console.WriteLine("\n-- Задача 6. Реверс --");
            int[] arr3 = lab.ReadArray("Введите массив через пробел: ");
            lab.Reverse(arr3);
            Console.WriteLine("Результат: " + string.Join(" ", arr3));

            Console.WriteLine("\n-- Задача 8. Объединение --");
            int[] arr4 = lab.ReadArray("Введите первый массив: ");
            int[] arr5 = lab.ReadArray("Введите второй массив: ");
            Console.WriteLine("Результат: " + string.Join(" ", lab.Concat(arr4, arr5)));

            Console.WriteLine("\n-- Задача 10. Удалить негатив --");
            int[] arr6 = lab.ReadArray("Введите массив через пробел: ");
            Console.WriteLine("Результат: " + string.Join(" ", lab.DeleteNegative(arr6)));

            Console.WriteLine("\nНажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}