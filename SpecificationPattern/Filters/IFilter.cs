
public interface ISpecification<T>
{
    bool IsSatisfied(Product product);
}
public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
}


public class ColorSpecification : ISpecification<Product>
{
    private Color color;
    public ColorSpecification(Color color)
    {
        this.color = color;
    }
    public bool IsSatisfied(Product product)
    {
        return product.color == this.color;
    }
}

public class SizeSpecification : ISpecification<Product>
{
    private Size size;
    public SizeSpecification(Size size)
    {
        this.size = size;
    }
    public bool IsSatisfied(Product product)
    {
        return product.size == this.size;
    }
}

public class AndSpecification<T> : ISpecification<T>
{
    private ISpecification<T> first, second;
    public AndSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
        this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
    }

    public bool IsSatisfied(Product product)
    {
        return first.IsSatisfied(product) && second.IsSatisfied(product);
    }
}

public class OrSpecification<T> : ISpecification<T>
{
    private ISpecification<T> first, second;
    public OrSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
        this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
    }

    public bool IsSatisfied(Product product)
    {
        return first.IsSatisfied(product) || second.IsSatisfied(product);
    }
}

public class ProductFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
        foreach (Product product in items)
            if (spec.IsSatisfied(product))
                yield return product;
    }
}


