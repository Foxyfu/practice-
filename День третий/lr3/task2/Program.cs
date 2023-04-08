namespace task2
{
    internal class Program
    {
        public void Print(string rezult, int res)
        {
            Console.WriteLine(rezult);
            Console.WriteLine(res);
        } 
        static void Main(string[] args)
        {
            Toy toy = new (50);
            Product product = new(134, 34);
            Commodity commodity = new(54, 54);
            DairyProduct dairyProduct = new(32, "lida product");
            Console.WriteLine($" {toy} \n {product} \n {commodity} \n {dairyProduct}"); ;
        }
    }
}