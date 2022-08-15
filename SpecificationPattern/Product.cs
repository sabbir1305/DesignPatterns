
public enum Color
{
    Red, Green, Blue
}

public enum Size
{
    Small, Medium, Large, Yuge
}
public class Product
{
    public string Name;
    public Color color;
    public Size size;

    public Product(string name, Color color, Size size)
    {
        Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
        this.color = color;
        this.size = size;
    }
}
