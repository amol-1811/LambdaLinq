namespace LambdaLinq
{
    internal class ProductOutOfStock
    {
        //Retrieve the names of products that are out of stock from a product list.
        public string Name { get; set; }
        public int Stock { get; set; }

        public ProductOutOfStock(string name, int stock)
        {
            Name = name;
            Stock = stock;
        }

        public static void ProductOutOfStocks()
        {
            List<ProductOutOfStock> products = new List<ProductOutOfStock>
        {
            new ProductOutOfStock("Laptop", 10),
            new ProductOutOfStock("Mobile", 0),
            new ProductOutOfStock("Tablet", 5),
            new ProductOutOfStock("Desktop", 0),
            new ProductOutOfStock("Smartwatch", 3),
            new ProductOutOfStock("Earbuds", 0)
        };
            //using lambda expression
            var outOfStock = products.Where(p => p.Stock == 0).Select(p => p.Name).ToList();
            foreach (var product in outOfStock)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine();

            //using LINQ
            var outOfStockL = (from p in products where p.Stock == 0 select p.Name).ToList();
            foreach (var product in outOfStockL)
            {
                Console.WriteLine(product);
            }
        }
    }  
}
