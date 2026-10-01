using System;

namespace lab1
{
    // Класс с решениями всех задач лабораторной работы №1.
    // Вариант: чётный (задачи 2, 4, 6, 8, 10).
    public class Tasks
    {
        // =========================================================
        // ЗАДАНИЕ 1. МЕТОДЫ
        // =========================================================

        // Задача 2. Сумма двух последних цифр числа.
        public int SumLastNums(int x)
        {
            int lastDigit = x % 10;
            int secondDigit = (x / 10) % 10;
            return lastDigit + secondDigit;
        }

        // Задача 4. Положительное ли число.
        public bool IsPositive(int x)
        {
            return x > 0;
        }

        // Задача 6. Заглавная латинская буква.
        public bool IsUpperCase(char x)
        {
            return x >= 'A' && x <= 'Z';
        }

        // Задача 8. Делит ли одно число другое нацело.
        public bool IsDivisor(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return false;
            }
            return (a % b == 0) || (b % a == 0);
        }

        // Задача 10. Сумма единиц пяти чисел.
        // Принимает 5 чисел и последовательно складывает их последние цифры.
        public int LastNumSum(int a, int b, int c, int d, int e)
        {
            int result = (a % 10) + (b % 10);
            result = (result % 10) + (c % 10);
            result = (result % 10) + (d % 10);
            result = (result % 10) + (e % 10);
            return result % 10;
        }

        // =========================================================
        // ЗАДАНИЕ 2. УСЛОВИЯ
        // =========================================================

        // Задача 2. Безопасное деление.
        public double SafeDiv(int x, int y)
        {
            if (y == 0)
            {
                return 0;
            }
            return (double)x / y;
        }

        // Задача 4. Строка сравнения.
        public string MakeDecision(int x, int y)
        {
            if (x > y)
            {
                return x + " > " + y;
            }
            else if (x < y)
            {
                return x + " < " + y;
            }
            else
            {
                return x + " == " + y;
            }
        }

        // Задача 6. Сумма двух чисел равна третьему.
        public bool Sum3(int x, int y, int z)
        {
            return (x + y == z) || (x + z == y) || (y + z == x);
        }

        // Задача 8. Возраст со словом год/года/лет.
        public string Age(int x)
        {
            int lastTwo = x % 100;
            int lastOne = x % 10;
            string word;

            if (lastTwo >= 11 && lastTwo <= 14)
            {
                word = "лет";
            }
            else if (lastOne == 1)
            {
                word = "год";
            }
            else if (lastOne >= 2 && lastOne <= 4)
            {
                word = "года";
            }
            else
            {
                word = "лет";
            }

            return x + " " + word;
        }

        // Задача 10. Вывод дней недели до конца недели.
                public void PrintDays(string x)
        {
            switch (x)
            {
                case "понедельник":
                    Console.WriteLine("понедельник");
                    goto case "вторник";
                case "вторник":
                    Console.WriteLine("вторник");
                    goto case "среда";
                case "среда":
                    Console.WriteLine("среда");
                    goto case "четверг";
                case "четверг":
                    Console.WriteLine("четверг");
                    goto case "пятница";
                case "пятница":
                    Console.WriteLine("пятница");
                    goto case "суббота";
                case "суббота":
                    Console.WriteLine("суббота");
                    goto case "воскресенье";
                case "воскресенье":
                    Console.WriteLine("воскресенье");
                    break;
                default:
                    Console.WriteLine("это не день недели");
                    break;
            }
        }

            for (int i = startIndex; i < days.Length; i++)
            {
            Console.WriteLine(days[i]);
            }
        }

        // =========================================================
        // ЗАДАНИЕ 3. ЦИКЛЫ
        // =========================================================

        // Задача 2. Числа от x до 0.
        // x не может быть отрицательным.
        public string ReverseListNums(int x)
        {
            if (x < 0)
            {
                return "Ошибка: число не может быть отрицательным.";
            }

            string result = "";
            for (int i = x; i >= 0; i--)
            {
                result += i;
                if (i > 0)
                {
                    result += " ";
                }
            }
            return result;
        }

        // Задача 4. Возведение x в степень y.
        // Степень не может быть отрицательной.
        public int Pow(int x, int y)
        {
            if (y < 0)
            {
                Console.WriteLine("Ошибка: степень не может быть отрицательной.");
                return 0;
            }

            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }

        // Задача 6. Все цифры числа одинаковые.
        public bool EqualNum(int x)
        {
            int firstDigit = x % 10;
            x /= 10;

            while (x > 0)
            {
                if (x % 10 != firstDigit)
                {
                    return false;
                }
                x /= 10;
            }
            return true;
        }

        // Задача 8. Левый треугольник из звёздочек.
        // Высота не может быть отрицательной.
        public void LeftTriangle(int x)
        {
            if (x < 0)
            {
                Console.WriteLine("Ошибка: высота не может быть отрицательной.");
                return;
            }

            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // Задача 10. Игра «Угадайка».
        public void GuessGame()
        {
            Random random = new Random();
            int target = random.Next(0, 10);
            int attempts = 0;
            int userNumber = -1;

            while (userNumber != target)
            {
                userNumber = ReadInt("Введите число от 0 до 9: ");
                attempts++;

                if (userNumber != target)
                {
                    Console.WriteLine("Вы не угадали, попробуйте снова.");
                }
            }

            Console.WriteLine("Вы угадали! Вы отгадали число за " + attempts + " попытки");
        }

        // =========================================================
        // ЗАДАНИЕ 4. МАССИВЫ
        // =========================================================

        // Задача 2. Индекс последнего вхождения числа или -1.
        public int FindLast(int[] arr, int x)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    index = i;
                }
            }
            return index;
        }

        // Задача 4. Вставка элемента в позицию pos.
        public int[] Add(int[] arr, int x, int pos)
        {
            int[] result = new int[arr.Length + 1];
            for (int i = 0; i < pos; i++)
            {
                result[i] = arr[i];
            }
            result[pos] = x;
            for (int i = pos; i < arr.Length; i++)
            {
                result[i + 1] = arr[i];
            }
            return result;
        }

        // Задача 6. Реверс массива на месте.
        public void Reverse(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }

        // Задача 8. Объединение двух массивов.
        public int[] Concat(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                result[arr1.Length + i] = arr2[i];
            }
            return result;
        }

        // Задача 10. Удаление отрицательных элементов.
        public int[] DeleteNegative(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    result[index] = arr[i];
                    index++;
                }
            }
            return result;
        }

        // =========================================================
        // ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ ВВОДА
        // =========================================================

        // Чтение целого числа с проверкой.
        public int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                string s = Console.ReadLine();
                int result;
                if (int.TryParse(s, out result))
                {
                    return result;
                }
                Console.WriteLine("Ошибка: нужно целое число.");
            }
        }

        // Чтение неотрицательного целого числа.
        public int ReadNonNegativeInt(string message)
        {
            while (true)
            {
                int result = ReadInt(message);
                if (result >= 0)
                {
                    return result;
                }
                Console.WriteLine("Ошибка: число не может быть отрицательным.");
            }
        }

        // Чтение числа минимум из двух цифр.
        public int ReadIntAtLeastTwoDigits(string message)
        {
            while (true)
            {
                Console.Write(message);
                string s = Console.ReadLine();
                int result;
                if (int.TryParse(s, out result) && Math.Abs(result) >= 10)
                {
                    return result;
                }
                Console.WriteLine("Ошибка: число должно содержать минимум две цифры.");
            }
        }

        // Чтение одного символа.
        public char ReadChar(string message)
        {
            while (true)
            {
                Console.Write(message);
                string s = Console.ReadLine();
                if (s != null && s.Length == 1)
                {
                    return s[0];
                }
                Console.WriteLine("Ошибка: введите ровно один символ.");
            }
        }

        // Чтение массива чисел из строки.
        public int[] ReadArray(string message)
        {
            while (true)
            {
                Console.Write(message);
                string s = Console.ReadLine();
                string[] parts = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 0)
                {
                    Console.WriteLine("Ошибка: массив пустой.");
                    continue;
                }

                int[] result = new int[parts.Length];
                bool ok = true;

                for (int i = 0; i < parts.Length; i++)
                {
                    if (!int.TryParse(parts[i], out result[i]))
                    {
                        ok = false;
                        break;
                    }
                }

                if (ok)
                {
                    return result;
                }

                Console.WriteLine("Ошибка: введите целые числа через пробел.");
            }
        }
    }
}
