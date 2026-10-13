using System;

namespace PatternMatching_Records
{
    class Program
    {
        static string Classify(object shape) => shape switch
        {
            Circle { Center: { X: 0, Y: 0 } } => "окружность в начале координат",
            Circle { Radius: 0 } => "вырожденная окружность (точка)",
            Circle c => $"строка с радиусом {c.Radius}",
            Rectangle r when r.TopLeft == r.BottomRight => "вырожденный прямоугольник (точка)",
            Rectangle r => "строка с размерами",
            _ => "неизвестная фигура"
        };

        static void Main(string[] args)
        {
            // Проверка по контрольным ключам
            object s1 = new Circle(new Point(0, 0), 5);
            object s2 = new Circle(new Point(3, 4), 0);
            object s3 = new Circle(new Point(3, 4), 5);
            object s4 = new Rectangle(new Point(1, 1), new Point(1, 1));
            object s5 = new Rectangle(new Point(0, 0), new Point(4, 3));

            Console.WriteLine(Classify(s1));
            Console.WriteLine(Classify(s2));
            Console.WriteLine(Classify(s3));
            Console.WriteLine(Classify(s4));
            Console.WriteLine(Classify(s5));

            Console.WriteLine();
            Console.WriteLine("=== Интерактивный режим ввода геометрии ===");

            while (true)
            {
                try
                {
                    Console.WriteLine("\nВыберите объект:");
                    Console.WriteLine("1 - Окружность (Circle)");
                    Console.WriteLine("2 - Прямоугольник (Rectangle)");
                    Console.WriteLine("0 - Выход");
                    Console.Write("Ваш выбор: ");

                    string choice = Console.ReadLine();
                    if (choice == "0") break;

                    if (choice == "1")
                    {
                        Console.Write("Введите центр X: ");
                        double cx = double.Parse(Console.ReadLine());
                        Console.Write("Введите центр Y: ");
                        double cy = double.Parse(Console.ReadLine());
                        Console.Write("Введите радиус: ");
                        double radius = double.Parse(Console.ReadLine());

                        Circle circle = new Circle(new Point(cx, cy), radius);
                        Console.WriteLine($"Результат: {Classify(circle)}");
                    }
                    else if (choice == "2")
                    {
                        Console.Write("Левый верхний угол X1: ");
                        double x1 = double.Parse(Console.ReadLine());
                        Console.Write("Левый верхний угол Y1: ");
                        double y1 = double.Parse(Console.ReadLine());
                        Console.Write("Правый нижний угол X2: ");
                        double x2 = double.Parse(Console.ReadLine());
                        Console.Write("Правый нижний угол Y2: ");
                        double y2 = double.Parse(Console.ReadLine());

                        Rectangle rect = new Rectangle(new Point(x1, y1), new Point(x2, y2));
                        Console.WriteLine($"Результат: {Classify(rect)}");
                    }
                    else
                    {
                        Console.WriteLine("Неверный выбор.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введите числовые значения координат.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
    }
}
