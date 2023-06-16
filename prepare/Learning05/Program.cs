using System;

class Program
{
    static void Main(string[] args)
    {
        Square sqr = new Square("Yellow", 5);

        Circle crl = new Circle("Blue", 20);

        Rectangle rtg = new Rectangle("Green", 5, 5);

        display(sqr);
        display(crl);
        display(rtg);


        static void display(Shape format) 
        {
            string color = format.GetColor();
            double area = format.GetArea();
            Console.WriteLine(color);
            Console.WriteLine(area);
            Console.WriteLine();
        }
    }
}