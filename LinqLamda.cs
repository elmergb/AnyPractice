using System;
using System.Diagnostics.Metrics;
using System.Linq;

namespace LinqLamda
{
    internal class LinqLamda
    {
        class Item
        {
            public string item { get; set; }
            public decimal price { get; set; }

            public int customerID { get; set;}
        }

        class Customer
        {
            public int customerID { get; set; }
            public string customerName { get; set; }
        }
        static void Main(string[] args)
        {
            #region practice Linq and lamda 1st sample
            //var countries = new[] { "Philippines", "USA", "Japan", "Singapore" };
            //var expense = new[] { 100, 200, 300, 400, 500, 600 };

            //var linqResult = from country in countries where country.Contains("P") select country;
            //foreach (string country in linqResult)
            //{
            //    Console.WriteLine(country);
            //}

            //var lingExpense = from exp in expense where exp >= 500 select exp;
            //int count = 0;
            //foreach (var exp in lingExpense)
            //{
            //    count++;
            //    Console.WriteLine(count + "." + exp);
            //}

            //var LamdaResult = expense.Where(expense => expense >= 200);
            //Console.WriteLine("-----Using Lamda-----");
            //foreach (var lamd in LamdaResult)
            //{
            //    Console.WriteLine(lamd);
            //}
            #endregion
            #region --second sample
            //var numbers = new[] {1, 2, 3, 4, 5};

            //int count = 0;
            ////for (int i = 0; i ) {
            //    var lingResult = from num in numbers
            //                     where num >= 2
            //                     orderby num descending
            //                     select $"Number: {num}";
            ////}

            //Console.WriteLine("-----Using Lamda-----");
            //var lamdaResult = numbers
            //                  .Where(num => num > 5)
            //                  .OrderByDescending(num => num)
            //                  .Select(num => $"Lamda {num}");


            //foreach (var lamda in lamdaResult)
            //{
            //    Console.WriteLine(lamda);
            //}
            ////for (int i = 0; i < numbers.Length; i++)
            ////{
            ////    Console.WriteLine($"{i}. {numbers[i]}");
            ////}

            //foreach (var result in lingResult)
            //{
            //    count++;
            //    Console.WriteLine($"{count}. {result}");
            //}
            #endregion region

            var items = new List<Item>()
            {
                new Item(){item = "Perfume", price = 150, customerID = 1 },
                new Item(){item = "Computer", price = 27500.90m, customerID = 2 },
                new Item(){item = "Fireworks", price = 1000, customerID = 1 }
            };

            var customer = new List<Customer>()
            {
                new Customer(){customerID = 1, customerName = "Elmer"},
                new Customer(){customerID = 2, customerName = "Heather"},
                new Customer(){customerID = 3, customerName = "Prinz"}
            };

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            #region practice-- readline with linq lamda
            //Boolean isRunning = true;  
            //while (isRunning == true) { 
            //    Console.Write("Enter your name: ");
            //    string name = Console.ReadLine();

            //    if (name == "exit")
            //    {
            //        isRunning = false;
            //    }
            //    Console.Write("Enter your customerID: ");
            //    int customerID = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter your order: ");
            //    var orderItem = Console.ReadLine();
            //    Console.Write("Enter your price: ");
            //    decimal price = Convert.ToDecimal(Console.ReadLine());


            //    items.Add(new Item
            //    {
            //        item = orderItem,
            //        price = price,
            //        customerID = customerID
            //    }
            //        );

            //    customer.Add(new Customer
            //    {
            //        customerName = name,
            //        customerID = customerID
            //    }
            //        );

            //    //foreach (var item in items)
            //    //{
            //    //    Console.WriteLine($"Item:{item.item} \n Price:{item.price} \n CustomerID: {item.customerID}");
            //    //}
            //    foreach (var item in items)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            #endregion



            Console.WriteLine();
            Console.WriteLine("===========End===========");
            #region -- join 
            #region linq
            var query = from item in items
                        join cust in customer on item.customerID equals cust.customerID
                        orderby cust.customerID
                        select new
                        {
                            item.item,
                            item.price,
                            CustomerName = cust.customerName
                        };
            int count = 0;
            foreach (var list in query)
            {
                count++;
                Console.WriteLine($"=======Customer:{count} ========\nItem: {list.item}\nPrice: {list.price}\nCustomer Name: {list.CustomerName}");
                
            }
            #endregion
            Console.WriteLine("Using lamda");
            var lamdaquery = items.Join
                                (customer,
                                item => item.customerID,
                                customers => customers.customerID,
                                (item, customers) => new
                                {
                                    ItemName = item.item,
                                    ItemPrice = item.price,
                                    CustomerName = customers.customerName
                                }
                                ).OrderByDescending(customer => customer.ItemPrice);
            foreach (var result in lamdaquery)
            {
                Console.WriteLine($"Customer: {result.CustomerName} \nItem: {result.ItemPrice} \nPrice: {result.ItemPrice}  ");
            }
            #endregion


             
        }
    }
}
