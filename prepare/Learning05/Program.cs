using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = [];
        Square sq = new("aquamarine", 2);
        shapeList.Add(sq);
        Rectangle rect = new("marigold", 2, 4);
        shapeList.Add(rect);
        Circle c = new("twilight", 1);
        shapeList.Add(c);

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}