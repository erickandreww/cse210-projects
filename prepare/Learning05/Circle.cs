using System;

public class Circle : Shape 
{
    private double pi = Math.PI;
    private float _radius;
    public Circle(string color, float radius) : base(color)
    {
        _color = color; 
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * pi;
    }
}