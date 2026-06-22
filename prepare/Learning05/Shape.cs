class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    /* We were instructed to create a virtual method for
    GetArea despite the abstract keyword making more sense */

    public virtual double GetArea()
    {   
        double Area = 0;
        return Area;
    }
}