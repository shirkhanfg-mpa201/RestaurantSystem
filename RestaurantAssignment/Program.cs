namespace RestaurantAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catagory cat1 = new Catagory(1, "Qəlyanaltı");
            Catagory cat2 = new Catagory(2, "Əsas yeməklər");
            Catagory cat3 = new Catagory(3, "Şorbalar");
            Dish d1 = new Dish(1, "Salat", 5);
            d1.Catagory = cat1;

            Dish d2 = new Dish(2, "Soup", 4);
            d2.Catagory = cat3;

            Dish d3 = new Dish(3, "Pizza", 10);
            d3.Catagory = cat2;

            Dish d4 = new Dish(4, "Kabab", 12);
            d4.Catagory = cat2;

            Dish d5 = new Dish(5, "Kartof free", 6);
            d5.Catagory = cat1;

            Dish[] allDishes = { d1, d2, d3, d4, d5 };

            // Kateqoriyaya görə axtarış 
            Console.WriteLine("Yeməklər:");

            Dish[] snacks = d1.FindDishesCategory(cat1, allDishes);
            Console.WriteLine("\nQəlyanaltılar:");
            foreach (var dish in snacks)
            {
                if (dish != null)
                    Console.WriteLine($"- {dish.Name} ({dish.Price} AZN)");
            }

            Dish[] mainDishes = d3.FindDishesCategory(cat2, allDishes);
            Console.WriteLine("\nEsas yeməklər:");
            foreach (var dish in mainDishes)
            {
                if (dish != null)
                    Console.WriteLine($"- {dish.Name} ({dish.Price} AZN)");
            }

         
            Restaurant r = new Restaurant("---Lezzet Restoranı---");
            

            Console.WriteLine($"\n {r.Name}");
            

            // AddDishToMenu()
            Console.WriteLine("\nYemek elave olundu");
            r.AddDishToMenu(d1);
            r.AddDishToMenu(d2);
            r.AddDishToMenu(d3);
            r.AddDishToMenu(d4);
            r.AddDishToMenu(d5);

            Console.WriteLine("\nRestoran menyusu:");
            foreach (var dish in r.Menu)
            {
                Console.WriteLine($"- {dish.Name}: {dish.Price} AZN ");
            }

            // Sifarişlər
            Console.WriteLine("\nSifariş");
            Order order1 = new Order(1);
            order1.dishes = new Dish[] { d3, d4 };
            

            // PlaceOrder()
            r.PlaceOrder(order1);

            Console.WriteLine($"Sifariş ID: {order1.Id}");
            Console.WriteLine("Sifariş edilən yeməklər:");
            foreach (var dish in order1.dishes)
            {
                Console.WriteLine($" {dish.Name} {dish.Price} AZN");
            }
            
            

            //GetOrderById()
            Console.WriteLine("\nSifariş axtarışı");
            Order foundOrder = r.GetOrderById(1);

            if (foundOrder != null)
            {
                Console.WriteLine($"Tapıldı ID: {foundOrder.Id}");
                Console.WriteLine("Yeməklər:");
                foreach (var dish in foundOrder.dishes)
                {
                    Console.WriteLine($"- {dish.Name}");
                }
            }
            else
            {
                Console.WriteLine("Sifariş tapılmadı!");
            }

            
        }
    }
}
