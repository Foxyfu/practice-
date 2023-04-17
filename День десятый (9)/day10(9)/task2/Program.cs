namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();

            Product product1 = new Product("Книга", "Книжный магазин", 500);
            Product product2 = new Product("Мыло", "Супермаркет", 50);
            Product product3 = new Product("Футболка", "Магазин Одежды", 1000);
            Product product4 = new Product("Кросовки", "Обувной магазин", 200);


            warehouse.Add(product1);
            warehouse.Add(product2);
            warehouse.Add(product3);
            warehouse.Add(product4);

            Console.WriteLine("Выберите сортировку: \n 1 - по названию Товара \n 2 - по названию магазина \n 3 - по цене ");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    warehouse.SortByName(); // сортировка товаров по названию Товара
                    break;
                case 2:
                    warehouse.SortByStore(); // сортировка товаров по названию магазина
                    break;
                case 3:
                    warehouse.SortByPrice(); // сортировка товаров по цене
                    break;
            }

           

            foreach (Product product in warehouse.GetAll())
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Введите индекс элемента который хотите вывести: ");
            int index = int.Parse(Console.ReadLine());

            warehouse.Display(index - 1); // вывод информации о товаре по номеру с помощью индекса
        }
    }
}