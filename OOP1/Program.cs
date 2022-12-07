namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;    
            product1.ProductName = "Ayakkabı";
            product1.UnitPrice = 1200;
            product1.CategoriId = 1;
            product1.UnitsInstok = 20;

            Product product2 = new Product
            {
                Id = 2,
                ProductName = "Çanta",
                UnitPrice = 200,
                CategoriId = 2,
                UnitsInstok = 15,
            };

            ProductManager productManager = new ProductManager();
            int toplamasonucu = productManager.carp(6, 7);
            int toplamasonucununikikati = toplamasonucu * 2;
            Console.WriteLine("toplama sonucu:"+toplamasonucu);
            Console.WriteLine("toplama sonucunun iki katı:"+toplamasonucununikikati);

            productManager.topla(2,3);

        }
    }
}