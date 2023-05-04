namespace LINQ_demo
{
    class product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string brand { get; set; }
        public int Quantity { get; set; }
        public int price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<product> products = new List<product>()
            {
                new product { Id = 1,Name="laptop",brand="dell",Quantity=2,price=20000},
                new product { Id = 2,Name="camera",brand="canon",Quantity=1,price=10000},
                new product { Id = 3,Name="tv",brand="lg",Quantity=2,price=50000},

            };
            var query=from p in products where p.Id == 1 select p;
            foreach(var p in query)
            {
                Console.WriteLine($"{p.Id} {p.Name} {p.brand} {p.Quantity} {p.price}");
            }
            var result=products.Where(x=>x.Id == 2).ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.brand} {item.Quantity} {item.price}");
            }
            var ans=products.Find(x=>x.Name == "tv");
            Console.WriteLine($"{ans.Id} {ans.Name} {ans.brand} {ans.Quantity} {ans.price}");
        }
    }
}