namespace CustomerManagementAssignment
{
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public long phone { get; set; }
        public string city { get; set; }
        public int age { get;set; }
        static string Generateid()
        {
            string Id = Guid.NewGuid().ToString();
            return Id;
        }


    }
    class Management
    {
        List<Customer> list;

        public Management()
        {
            
            list = new List<Customer>()
            {
                new Customer {Id=1, FirstName = "Hema", LastName = "Jakka",age=24, email = "hemajakka@gmail.com", phone = 9515479705, city = "rjy" },
                new Customer { Id=2,FirstName = "abi", LastName = "ch",age=22, email = "abich@gmail.com", phone = 707555433, city = "kkd" },
            };


        }
        public void AddCustomer(Customer customer)
        {
            list.Add(customer);
        }

        public bool UpdateCustomer(int id)
        {
            foreach(Customer c in list)
            {
                if(c.Id == id)
                {
                    Console.WriteLine("enter new details");
                    Console.WriteLine("enter first name");
                    string FirstName=Console.ReadLine();
                    Console.WriteLine("enter last name");
                    string LasttName = Console.ReadLine();
                    Console.WriteLine("enter age");
                    int age = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("enter email");
                    string email = Console.ReadLine();
                    Console.WriteLine("enter phone number");
                    long phone = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("enter city name");
                    string city = Console.ReadLine();
                }
                return true;
            }
            return false;
        }
        public Customer GetCustomer(int id)
        {
            foreach (Customer customer in list)
            {
                if (customer.Id == id)
                {
                    return customer;
                }
            }
            return null;
        }
        public List<Customer> GetCustomers()
        {
            return list;
        }
        public bool DeleteCustomer(int id)
        {
            foreach (Customer c in list)
            {
                if (c.Id == id)
                {
                    list.Remove(c);
                    return true;
                }
            }
            return false;
        }
        public int GenerateCustomerId(string firstName, string lastName)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 20);
            return randomNumber;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Management m = new Management();
            string ans = "";
            do
            {
                Console.WriteLine("welcome to customer management app");
                Console.WriteLine("1.Add customer");
                Console.WriteLine("2.update");
                Console.WriteLine("3.get customer by id");
                Console.WriteLine("4.get all customers");
                Console.WriteLine("delete customer");
                Console.WriteLine("enter your choice");
                int ch = Convert.ToInt16(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {

                            Console.WriteLine("enter first name");
                            string FirstName = Console.ReadLine();
                            Console.WriteLine("enter second name");
                            string LastName = Console.ReadLine();
                            Console.WriteLine("enter age");
                            int age = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("enter email");
                            string email = Console.ReadLine();
                            Console.WriteLine("enter phone number");
                            long phone = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("enter city");
                            string city = Console.ReadLine();
                            int customerid=m.GenerateCustomerId(FirstName,LastName);
                            m.AddCustomer(new Customer() { Id =customerid , FirstName = FirstName, LastName = LastName,age=age, email = email, phone = phone, city = city });
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("enter customer id");
                            int id=Convert.ToInt32(Console.ReadLine());
                            if (m.UpdateCustomer(id))
                            {
                                Console.WriteLine("customer is updated successfully");
                            }
                            else
                            {
                                Console.WriteLine("customer with specified id is not found");
                            }
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("enter the customer id");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Customer? cm = m.GetCustomer(id);
                            if (cm == null)
                            {
                                Console.WriteLine("id does not exist");
                            }
                            else
                            {
                                Console.WriteLine($"{cm.Id} {cm.FirstName} {cm.LastName}{cm.age} {cm.email} {cm.phone} {cm.city}");
                            }
                            break;
                        }
                    case 4:
                        {
                            foreach (Customer p in m.GetCustomers())
                            {
                                Console.WriteLine($"{p.Id} {p.FirstName} {p.LastName}{p.age} {p.email} {p.phone} {p.city}");
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter Product Id");
                            int id = Convert.ToInt16(Console.ReadLine());
                            if (m.DeleteCustomer(id))
                            {
                                Console.WriteLine("customer Deleted Successfully");
                            }
                            else
                            {
                                Console.WriteLine("customer with this id does not exist");
                            }
                            break;
                        }
                }
                Console.WriteLine("do you wish to continue?[]y/n");
                ans = Console.ReadLine();
            } while (ans.ToLower() == "y");
        }
    }
}




