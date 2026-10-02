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
            object s1 = new Circle(0);
            object s2 = new Circle(150);
            object s3 = new Rectangle(5, 5);
            object s4 = new Rectangle(4, 9);

            Console.WriteLine($"new Circle(0) -> \"{Classify(s1)}\"");
            Console.WriteLine($"new Circle(150) -> \"{Classify(s2)}\"");
            Console.WriteLine($"new Rectangle(5, 5) -> \"{Classify(s3)}\"");
            Console.WriteLine($"new Rectangle(4, 9) -> \"{Classify(s4)}\"");
        }
    }
}