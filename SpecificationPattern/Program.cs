var apple = new Product("Apple", Color.Green, Size.Small);
var tree = new Product("Tree", Color.Green, Size.Large);
var house = new Product("House", Color.Blue, Size.Large);

Product[] products = { apple, tree, house };

ProductFilter pf = new ProductFilter();

Console.WriteLine("Green products:");
foreach (var p in pf.Filter(products, new ColorSpecification(Color.Green)))
    Console.WriteLine($" - {p.Name} is green");

Console.WriteLine("Large products");
foreach (var p in pf.Filter(products, new SizeSpecification(Size.Large)))
    Console.WriteLine($" - {p.Name} is large");

Console.WriteLine("Large blue items");
foreach (var p in pf.Filter(products,
  new AndSpecification<Product>(new ColorSpecification(Color.Blue), 
  new SizeSpecification(Size.Large)))
)
{
    Console.WriteLine($" - {p.Name} is big and blue");
}

Console.WriteLine("Large or blue items");

foreach (var p in pf.Filter(products,
    new OrSpecification<Product>(new ColorSpecification(Color.Blue),new SizeSpecification(Size.Large))))
{
    Console.WriteLine($" - {p.Name} is {p.color} and {p.size}");
}