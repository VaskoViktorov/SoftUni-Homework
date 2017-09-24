using System;
using System.Linq;

namespace _05._ShopHierarchy
{
    public class Program
    {
        public static void Main()
        {
            using (AppDbContext context = new AppDbContext())
            {
                ClearDatabase(context);
                FillSalesman(context);
                FillStock(context);
                ReadCommands(context);
                // PrintSalesmenWithCustomersCount(context);        //5. Shop Hierarchy solution
                // PrintCustomersWithOrdersAndReviews(context);     //6. Shop Hierarchy – Extended /have to remove part from the code/
                //PrintCustomerOrdersReviewsAndItems(context);      //7. Shop Hierarchy – Complex Query
                //PrintCustomerNameOrdersReviewsAndItems(context);  //8. Explicit Data Loading
                PrintCustomerOrdersWithMoreThanOneItem(context);    //9. Query Loaded Data
            }

        }

        public static void ClearDatabase(AppDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        public static void FillSalesman(AppDbContext context)
        {
            string[] input = Console.ReadLine().Split(';');

            foreach (var salesmanName in input)
            {
                Salesmen salesman = new Salesmen { Name = salesmanName };
                context.Salesmen.Add(salesman);
            }
            context.SaveChanges();
        }

        public static void FillStock(AppDbContext context)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(';');

                if (input[0] == "END")
                {
                    break;
                }
                Item item = new Item { Name = input[0], Price = decimal.Parse(input[1]) };

                context.Items.Add(item);
            }

            context.SaveChanges();
        }

        public static void ReadCommands(AppDbContext context)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split('-');

                if (input[0] == "END")
                {
                    break;
                }

                switch (input[0])
                {
                    case "register":
                        Register(context, input[1]);
                        break;
                    case "order":
                        Order(context, input[1]);
                        break;
                    case "review":
                        Review(context, input[1]);
                        break;
                }
            }
        }

        public static void Register(AppDbContext context, string input)
        {
            string[] tokens = input.Split(';');

            string name = tokens[0];
            int salesmenId = int.Parse(tokens[1]);

            Customer customer = new Customer() { Name = name };

            Salesmen salesmen = context.Salesmen.FirstOrDefault(s => s.Id == salesmenId);
            salesmen.Customers.Add(customer);

            context.SaveChanges();
        }

        public static void Order(AppDbContext context, string input)
        {
            string[] tokens = input.Split(';');
            int id = int.Parse(tokens[0]);
            Order order = new Order() { CustomerId = id };


            for (int i = 1; i < tokens.Length; i++)                     //for problem 6 ->remove
            {                                                           //for problem 6 ->remove    
                var itemId = int.Parse(tokens[i]);                      //for problem 6 ->remove            
                ItemOrder io = new ItemOrder() { ItemId = itemId };      //for problem 6 ->remove    
                order.Items.Add(io);                                    //for problem 6 ->remove
            }                                                           //for problem 6 ->remove

            context.Orders.Add(order);
            context.SaveChanges();
        }

        public static void Review(AppDbContext context, string input)
        {
            string[] tokens = input.Split(';');

            int id = int.Parse(tokens[0]);
            Customer customer = context.Customer.FirstOrDefault(s => s.Id == id);

            int itemId = int.Parse(tokens[1]);                                  //for problem 6 ->remove
            customer.Reviews.Add(new Review() { ItemId = itemId });              //for problem 6 ->remove

            context.SaveChanges();
        }

        public static void PrintSalesmenWithCustomersCount(AppDbContext context)
        {
            var salesmen = context
                .Salesmen
                .Select(s => new
                {
                    s.Name,
                    Customers = s.Customers.Count
                })
                .OrderByDescending(x => x.Customers)
                .ThenBy(x => x.Name);

            foreach (var salesman in salesmen)
            {
                Console.WriteLine($"{salesman.Name} - {salesman.Customers} customers");
            }
        }

        public static void PrintCustomersWithOrdersAndReviews(AppDbContext context)
        {
            var customers = context
                .Customer
                .Select(c => new
                {
                    c.Name,
                    Orders = c.Orders.Count,
                    Reviews = c.Reviews.Count

                })
                .OrderByDescending(x => x.Orders)
                .ThenByDescending(x => x.Reviews);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine($"Orders: {customer.Orders}");
                Console.WriteLine($"Reviews: {customer.Reviews}");
            }
        }

        public static void PrintCustomerOrdersReviewsAndItems(AppDbContext context)
        {
            int input = int.Parse(Console.ReadLine());

            var customer = context
                .Customer
                .Where(c => c.Id == input)
                .Select(c => new
                {
                    Orders = c.Orders.Select(o => new
                    {
                        o.Id,
                        Items = o.Items.Count
                    }).OrderBy(o => o.Items),
                    Reviews = c.Reviews.Count,
                })
                .FirstOrDefault();


            foreach (var order in customer.Orders)
            {
                Console.WriteLine($"order {order.Id}: {order.Items}");
            }
            Console.WriteLine($"reviews: {customer.Reviews}");

        }

        public static void PrintCustomerNameOrdersReviewsAndItems(AppDbContext context)
        {
            int input = int.Parse(Console.ReadLine());

            var customer = context
                .Customer
                .Where(c => c.Id == input)
                .Select(c => new
                {
                    c.Name,
                    Orders = c.Orders.Count,
                    Reviews = c.Reviews.Count,
                    Salesman = c.Salesmen.Name
                })
                .FirstOrDefault();

            Console.WriteLine($"Customer: {customer.Name}");
            Console.WriteLine($"Orders Count: {customer.Orders}");
            Console.WriteLine($"Reviews Count: {customer.Reviews}");
            Console.WriteLine($"Salesman: {customer.Salesman}");
        }

        public static void PrintCustomerOrdersWithMoreThanOneItem(AppDbContext context)
        {
            int customerId = int.Parse(Console.ReadLine());

            var order = context
                .Orders
                .Where(o => o.CustomerId == customerId)
                .Count(o => o.Items.Count > 1);
                
            Console.WriteLine($"Orders Count: {order}");
        }
    }
}
