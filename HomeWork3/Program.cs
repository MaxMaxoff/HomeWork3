using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportLibrary;

/// <summary>
/// Максим Торопов
/// Ярославль
/// Домашняя работа 3 урока
/// </summary>
namespace HomeWork3
{
    /// <summary>
    /// Всякое комплексное число z = a + bi состоит из двух компонентов:
    /// Вещественной части "a" (Re z) и мнимой части "bi" (Im z)
    /// </summary>
    struct Complex
    {
        /// <summary>
        /// Вещественная часть (Re z)
        /// </summary>
        public double re;

        /// <summary>
        /// Мнимая часть (Im z)
        /// </summary>
        public double im;

        /// <summary>
        /// Сумма комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex Plus(Complex x)
        {
            Complex y;

            //(a + bi) + (c + di) = (a + c) + (b + d)i
            //a = re
            //b = im
            //c = x.re
            //d = x.im
            y.re = re + x.re;
            y.im = im + x.im;
            return y;
        }

        /// <summary>
        /// Разность комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex Minus(Complex x)
        {            
            Complex y;

            //(a + bi) - (c + di) = (a - c) + (b - d)i
            //a = re
            //b = im
            //c = x.re
            //d = x.im
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }

        /// <summary>
        /// Умножение комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex Multi(Complex x)
        {
            Complex y;

            //Неправильный код из методички:
            //y.re = re * x.im - im * x.re;
            //y.im = im * x.im + re * x.im;

            //Правильный код:
            //(a + bi) * (c + di) = (ac - bd) + (bc + ad)i
            //a = re
            //b = im
            //c = x.re
            //d = x.im
            y.re = re * x.re - im * x.im;
            y.im = im * x.re + re * x.im;

            return y;
        }

        /// <summary>
        /// Override ToString для вывода комплексного числа
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return re + " + " + im + "i";
        }
    }

    /// <summary>
    /// Всякое комплексное число z = a + bi состоит из двух компонентов:
    /// Вещественной части "a" (Re z) и мнимой части "bi" (Im z)
    /// </summary>
    class ComplexClass
    {
        /// <summary>
        /// Вещественная часть (Re z)
        /// </summary>
        public double re;

        /// <summary>
        /// Мнимая часть (Im z)
        /// </summary>
        public double im;

        /// <summary>
        /// Сумма комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public ComplexClass Plus(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();

            //(a + bi) + (c + di) = (a + c) + (b + d)i
            //a = this.re
            //b = this.im
            //c = x.re
            //d = x.im
            y.re = this.re + x.re;
            y.im = this.im + x.im;            

            return y;
        }

        /// <summary>
        /// Разность комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public ComplexClass Minus(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();

            //(a + bi) - (c + di) = (a - c) + (b - d)i
            //a = this.re
            //b = this.im
            //c = x.re
            //d = x.im
            y.re = this.re - x.re;
            y.im = this.im - x.im;

            return y;
        }

        /// <summary>
        /// Умножение комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public ComplexClass Multi(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();

            //(a + bi) * (c + di) = (ac - bd) + (bc + ad)i
            //a = this.re
            //b = this.im
            //c = x.re
            //d = x.im

            y.re = this.re * x.re - this.im * x.im;
            y.im = this.im * x.re + this.re * x.im;
            return y;

        }

        /// <summary>
        /// Override ToString для вывода комплексного числа
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return re + " + " + im + "i";
        }
    }

    /// <summary>
    /// Дроби
    /// </summary>
    class Fraction
    {
        /// <summary>
        /// Числитель
        /// </summary>
        public int numerator;

        /// <summary>
        /// Знаменатель
        /// </summary>
        public int denominator;

        /// <summary>
        /// Сложение дробей
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Fraction Plus(Fraction x)
        {
            Fraction y = new Fraction();

            if (this.denominator == x.denominator)
            {
                y.denominator = this.denominator;
                y.numerator = this.numerator + x.numerator;
            } else
            {
                y.denominator = this.denominator * x.denominator;
                y.numerator = this.numerator * x.denominator + x.numerator * this.denominator;
            }

            y.Simplification();
            
            return y;
        }

        /// <summary>
        /// Вычитание дробей
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Fraction Minus(Fraction x)
        {
            Fraction y = new Fraction();

            if (this.denominator == x.denominator)
            {
                y.denominator = this.denominator;
                y.numerator = this.numerator - x.numerator;
            }
            else
            {
                y.denominator = this.denominator * x.denominator;
                y.numerator = this.numerator * x.denominator - x.numerator * this.denominator;
            }

            y.Simplification();

            return y;
        }

        /// <summary>
        /// Умножение дробей
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Fraction Multi(Fraction x)
        {
            Fraction y = new Fraction();

            y.denominator = this.denominator * x.denominator;
            y.numerator = this.numerator * x.numerator;

            y.Simplification();
            return y;
        }

        /// <summary>
        /// Деление дробей
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Fraction Divide(Fraction x)
        {
            Fraction y = new Fraction();

            y.denominator = x.numerator;
            y.numerator = x.denominator;

            Fraction result = this.Multi(y);

            result.Simplification();
            return result;
        }

        /// <summary>
        /// Упрощение дробей
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public void Simplification()
        {
            for (int i = this.denominator; i > 1; i--)
            {
                if (this.denominator % i == 0 && this.numerator % i == 0)
                {
                    this.denominator /= i;
                    this.numerator /= i;
                }
            }            
        }
        
        /// <summary>
        /// Override ToString для вывода дроби
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // Symbols "(" and ")" are using just to highlight Fraction
                        
            if (denominator == 1 || numerator == 0)
            {
                return $"{numerator}";
            }

            if (numerator > denominator)
            {
                return numerator / denominator + " " + numerator % denominator + "/" + denominator;
            }

            return numerator + "/" + denominator;
        }

    }

    class Program
    {
        /// <summary>
        /// а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
        /// 
        /// б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;
        /// </summary>
        static void Task1()
        {
            //Clear console and print info regarding current task
            SupportMethods.PrepareConsoleForHomeTask("a) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;\n" +
                "б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;");

            //Блок для работы со структурой
            // z = 1 + 1i
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            // z = 2 + 2i
            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;
            
            // (1 + 1i) + (2 + 2i)
            Complex resultPlus = complex1.Plus(complex2);

            // (1 + 1i) - (2 + 2i)
            Complex resultMinus = complex1.Minus(complex2);

            // (1 + 1i) * (2 + 2i)
            Complex resultMultiply = complex1.Multi(complex2);
            //Конец блока для работы со структурой
            
            //Блок для работы с классом
            ComplexClass complex11 = new ComplexClass();
            complex11.re = 1;
            complex11.im = 1;

            ComplexClass complex22 = new ComplexClass();
            complex22.re = 2;
            complex22.im = 2;

            // (1 + 1i) + (2 + 2i)
            ComplexClass resultClassPlus = complex11.Plus(complex22);

            // (1 + 1i) - (2 + 2i)
            ComplexClass resultClassMinus = complex11.Minus(complex22);

            // (1 + 1i) * (2 + 2i)
            ComplexClass resultClassMultiply = complex11.Multi(complex22);
            //Конец блока для работы с классом

            //Вывод результата структуры и комплекса:
            SupportMethods.Pause("Работа структуры:\n" +
                $"Сложение комплексных чисел структура: {resultPlus.ToString()}; класс: {resultClassPlus.ToString()}\n" +
                $"Вычитание косплексных чисел структура: {resultMinus.ToString()}; класс: {resultClassMinus.ToString()}\n" +
                $"Умножение косплексных чисел структура: {resultMultiply.ToString()}; класс: {resultClassMultiply.ToString()}");

        }

        /// <summary>
        /// а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
        /// Требуется подсчитать сумму всех нечетных положительных чисел.
        /// Сами числа и сумму вывести на экран; Используя tryParse;
        /// 
        /// б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки вывести сообщение.
        /// </summary>
        static void Task2()
        {
            int sum = 0;
            int number = 0;

            //Clear console and print info regarding current task
            SupportMethods.PrepareConsoleForHomeTask("а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).\n" +
                "Требуется подсчитать сумму всех нечетных положительных чисел.\n" +
                "Сами числа и сумму вывести на экран; Используя tryParse;\n" +
                "б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки вывести сообщение.");

            do
            {
                //using TryParse without exception message                
                //number = SupportMethods.RequestIntValue("Please input new number (0 - exit): ");

                //using Parse with exception message
                number = SupportMethods.RequestIntValueWithExceptionMsg("Please input new number (0 - exit): ");
                if (number % 2 == 1)
                {
                    Console.WriteLine($"### Found new Positive Odd number: {number}");
                    sum += number;
                }
            } while (number != 0);

            SupportMethods.Pause($"Sum of Positive Odd numbers: {sum}");

        }

        /// <summary>
        /// Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
        /// Предусмотреть методы сложения, вычитания, умножения и деления дробей.
        /// Написать программу, демонстрирующую все разработанные элементы класса.
        /// 
        /// * Добавить упрощение дробей.
        /// </summary>
        static void Task3()
        {
            //Clear console and print info regarding current task
            SupportMethods.PrepareConsoleForHomeTask("Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.\n" +
                "Предусмотреть методы сложения, вычитания, умножения и деления дробей.\n" +
                "Написать программу, демонстрирующую все разработанные элементы класса.\n" +
                "* Добавить упрощение дробей.");
            
            Fraction a = new Fraction();
            Fraction b = new Fraction();

            SupportMethods.RequestFraction(out a.numerator, out a.denominator, "Please input first Fraction (for exapmle 1 / 3): ");
            SupportMethods.RequestFraction(out b.numerator, out b.denominator, "Please input second Fraction (for exapmle 1 / 3): ");

            Fraction resultPlus = a.Plus(b);
            Fraction resultMinus = a.Minus(b);
            Fraction resultMulti = a.Multi(b);
            Fraction resultDivide = a.Divide(b);

            //SupportMethods.Pause($"First Fractal is: {a.ToString()}");
            //SupportMethods.Pause($"Second Fractal is: {b.ToString()}");

            SupportMethods.Pause($"{a.ToString()} + {b.ToString()} = {resultPlus.ToString()}\n" +
                $"{a.ToString()} - {b.ToString()} = {resultMinus.ToString()}\n" +
                $"{a.ToString()} * {b.ToString()} = {resultMulti.ToString()}\n" +
                $"{a.ToString()} / {b.ToString()} = {resultDivide.ToString()}");
        }

        static void Main(string[] args)
        {

            do
            {
                SupportMethods.PrepareConsoleForHomeTask("1 - Task 1\n" +
                  "2 - Task 2\n" +
                  "3 - Task 3\n" +
                  "0 (Esc) - Exit\n");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Task1();
                        break;
                    case ConsoleKey.D2:
                        Task2();
                        break;
                    case ConsoleKey.D3:
                        Task3();
                        break;
                    case ConsoleKey.D0:
                    case ConsoleKey.Escape:
                        return;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
