// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Product_Inventory_Filter;

class program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>()
        {
            new Product{name="Laptop",category="Electronics",price=75000,stock=10},
            new Product{name="smartphone",category="Electronics",price=35000,stock=25},
            new Product{name="refrigerator",category="Home Appliance",price=45000,stock=5},
            new Product{name="Microwave Oven",category="Home Appliance",price=12000,stock=8},
            new Product{name="Washing Machin",category="Home Appliance",price=28000,stock=3},
            new Product{name="Office Chair",category="Furniture",price=8000,stock=15 },
            new Product{name="Table Lame",category="Furniture",price=1500,stock=40},
            new Product{name="Book shelf",category="Furniture",price=5000,stock=13}
        };
        var uptenk = products.Where(i => i.price > 10000);
        Console.WriteLine("Whoe's price over 10 thousend:");
        foreach (var item in uptenk)
        {
            Console.WriteLine(item.name);
        }
        var categorygroup = products.GroupBy(s => s.category).ToList();
        Console.WriteLine("product group by category:");
        foreach (var item in categorygroup)
        {
            Console.WriteLine($"Category:{item.Key}");
            foreach (var i in item)
            {
                Console.WriteLine($"- {i.name}");
            }
        }
        var avgprice = products.Average(i => i.price);
        Console.WriteLine($"Average price of all products={avgprice}");
        var lowestproduct = products.OrderBy(p => p.stock).Take(1);
        Console.WriteLine("Lowest stock produck:");
        foreach (var i in lowestproduct) { 
            Console.WriteLine($"{i.name} - Stock={i.stock}");
    }
    }
}
