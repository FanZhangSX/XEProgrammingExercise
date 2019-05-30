using System;
using XEProgrammingExercise.Terminal;

namespace XEProgrammingExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PointOfSaleTerminal:");
            Console.WriteLine("-------------------------------------------------");
            IProductsOfTerminal productsOfTerminal = new ProductsOfTerminal();
            productsOfTerminal.InsertProduct("A", 1.25m, 3, 3);
            productsOfTerminal.InsertProduct("B", 4.25m);
            productsOfTerminal.InsertProduct("C", 1.00m, 5, 6);
            productsOfTerminal.InsertProduct("D", 0.75m);
            var terminal = new PointOfSaleTerminal("ABCDABA", productsOfTerminal);

            terminal.OutPutMySelf();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("total: " + terminal.CalculateTotalPrice());

            terminal.Dispose();
            Console.ReadKey();
        }
    }
}
