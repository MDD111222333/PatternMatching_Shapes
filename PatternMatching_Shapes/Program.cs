using System;

namespace PatternMatching_Shapes
{
    class Program
    {
        static string Classify(object shape) => shape switch
        {
            Circle { Radius: 0 } => "точка",
            Circle { Radius: > 100 } => "огромный круг",
            Rectangle r when r.Width == r.Height => "квадрат",
            _ => "обычная фигура"
        };

        static void Main(string[] args)
        {
            // Проверка по контрольным ключам (автоматический блок)
            object s1 = new Circle(0);
            object s2 = new Circle(150);
            object s3 = new Rectangle(5, 5);
            object s4 = new Rectangle(4, 9);

            Console.WriteLine($"new Circle(0) -> \"{Classify(s1)}\"");
            Console.WriteLine($"new Circle(150) -> \"{Classify(s2)}\"");
            Console.WriteLine($"new Rectangle(5, 5) -> \"{Classify(s3)}\"");
            Console.WriteLine($"new Rectangle(4, 9) -> \"{Classify(s4)}\"");

            Console.WriteLine();
            Console.WriteLine("=== Интерактивный режим ввода фигур ===");

            while (true)
            {
                try
                {
                    Console.WriteLine("\nВыберите фигуру для проверки:");
                    Console.WriteLine("1 - Круг (Circle)");
                    Console.WriteLine("2 - Прямоугольник (Rectangle)");
                    Console.WriteLine("0 - Выход");
                    Console.Write("Ваш выбор: ");

                    string choice = Console.ReadLine();
                    if (choice == "0") break;

                    if (choice == "1")
                    {
                        Console.Write("Введите радиус круга: ");
                        double radius = double.Parse(Console.ReadLine());
                        if (radius < 0) throw new Exception("Радиус не может быть отрицательным.");

                        Circle circle = new Circle(radius);
                        Console.WriteLine($"Результат классификации: \"{Classify(circle)}\"");
                    }
                    else if (choice == "2")
                    {
                        Console.Write("Введите ширину прямоугольника: ");
                        double width = double.Parse(Console.ReadLine());
                        if (width <= 0) throw new Exception("Ширина должна быть больше 0.");

                        Console.Write("Введите высоту прямоугольника: ");
                        double height = double.Parse(Console.ReadLine());
                        if (height <= 0) throw new Exception("Высота должна быть больше 0.");

                        Rectangle rect = new Rectangle(width, height);
                        Console.WriteLine($"Результат классификации: \"{Classify(rect)}\"");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: неверный выбор пункта меню.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введено не числовое значение.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
    }
}
