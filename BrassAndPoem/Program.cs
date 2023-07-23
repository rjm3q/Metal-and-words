
using System.Xml.Serialization;
using System.Linq;
using System.Linq.Expressions;
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>
{
    new Product
    {
        Name = "Alumininum",
        Price = 5.00M,
        ProductTypeId = 1,
    },

    new Product
    {
        Name = "Wordicles",
        Price = 11.00M,
        ProductTypeId = 2,
    },

    new Product
    {
        Name = "Cobalt Cadaver",
        Price = 21.00M,
        ProductTypeId = 1,
    },

    new Product
    {
        Name = "Bard Words",
        Price = 17.00M,
        ProductTypeId = 1,
    },

    new Product
    {
        Name = "Hot Tungsten Worm",
        Price = 57.00M,
        ProductTypeId = 2,
    },
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List.
List<ProductType> productTypes = new List<ProductType>
{
    new ProductType
    {
        Title = "Words",
        Id = 1,
    },
    new ProductType
    {
        Title = "Metal",
        Id = 2,
    }
};
//put your greeting here
Console.Clear();
Console.WriteLine("Welcome to Words & Metal");
//implement your loop here
string chosem = null;
while (chosem != "E")
{
    Console.WriteLine(@"Please select an decision:
1. Show em up
2. Cancel em
3. Give em a chance
4. Change em
E. End it all");
    chosem = Console.ReadLine();
    if (chosem == "1")
    {
        DisplayAllProducts(products, productTypes);
    }
    else if (chosem == "2")
    {
        DeleteProduct(products, productTypes);
    }
    else if (chosem == "3")
    {
        AddProduct(products, productTypes);
    }
    else if (chosem == "4")
    {
        UpdateProduct(products, productTypes);
    }
    else if (chosem == "E")
    {
        Console.WriteLine("Bye Yall, good luck");
    }
    else
    {
        Console.WriteLine("Please Choose a thing that works");
    }
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
    Console.Clear();

}



void DisplayMenu()
{
    throw new NotImplementedException();
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    Console.Clear();
    Console.WriteLine("Things for Available:");
    for (int i = 0; i < products.Count; i++)
    {
        Product product = products[i];
        ProductType productTypeQuery = productTypes.First(productType => product.ProductTypeId == productType.Id);
        Console.WriteLine($"{i + 1}. {productTypeQuery.Title}: {product.Name} is ${product.Price}");
    };
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.Clear();
    bool prodDEL = false;
    while (prodDEL == false)
    {
        Console.WriteLine("Please choose an item to delete:");
        for (int i = 0; i < products.Count; i++)
        {
            Product product = products[i];
            ProductType productTypeQuery = productTypes.First(productType => product.ProductTypeId == productType.Id);
            Console.WriteLine($"{i + 1}. {productTypeQuery.Title}: {product.Name}");
        };
        string choice = Console.ReadLine();
        try
        {
            int productChoice = int.Parse(choice);
            int choiceIndex = productChoice - 1;
            Console.WriteLine($"You have removed {products[choiceIndex].Name}");
            products.RemoveAt(choiceIndex);
            prodDEL = true;
        }
        catch (Exception)
        {
            Console.WriteLine("Please enter a valid number");
        }
    }
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.Clear();
    Console.WriteLine("Add new Em's");

    Console.WriteLine("Name Em");
    string productName = Console.ReadLine();

    Console.WriteLine("Price Em");
    decimal productPrice = decimal.Parse(Console.ReadLine());


    Console.WriteLine("Metal or Words?");
    for (int i = 0; i < productTypes.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {productTypes[i].Title}");
    }
    int productTypeId = int.Parse(Console.ReadLine());

    Product newProduct = new Product
    {
        Name = productName,
        Price = productPrice,
        ProductTypeId = productTypeId
    };

    products.Add(newProduct);
    Console.WriteLine("Thang addendumed!");
}


// don't move or change this!
public partial class Program { }