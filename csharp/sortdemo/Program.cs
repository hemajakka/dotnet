﻿namespace sortdemo
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity  { get; set; }
        public int Price { get; set; }
    }
    class SortByQuantity : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            if (x.Quantity > y.Quantity)
            {
                return 1;
            }
            else if (x.Quantity < y.Quantity) { return -1; }
            else { return 0; }
        }
    }
    class SortByPrice : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            if(x.Price>y.Price)
            {
                return 1;
            }
            else if(x.Price < y.Price)
            {
                return -1;
            }
            else { return 0; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name="Laptop", Brand="Dell", Quantity=5, Price=46500},
                new Product { Id = 2, Name="Camera", Brand="Canon", Quantity=7, Price=32300},
                new Product { Id = 3, Name="Tablet", Brand="Lenovo", Quantity=2, Price=18500},
                new Product { Id = 4, Name="Desktop", Brand="HP", Quantity=9, Price=78200},
                new Product { Id = 5, Name="Earphones", Brand="Boat", Quantity=3, Price=3000},
                new Product { Id = 6, Name="Mobile", Brand="Apple", Quantity=4, Price=84000},
            };
            products.Sort(new SortByPrice());
                foreach(Product p in products)
                {
                    Console.WriteLine($"{p.Id} {p.Name} {p.Brand} {p.Quantity} {p.Price}");
                }
            Console.WriteLine("sorting through quantity");
            products.Sort(new SortByQuantity());
            foreach(Product p in products)
            {
                Console.WriteLine($"{p.Id} {p.Name} {p.Brand} {p.Quantity} {p.Price}");
            }
            

        }
    }
}