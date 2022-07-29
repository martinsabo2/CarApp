using CarApp.Data;
using CarApp.Domain;

namespace CarApp
{
    internal class Program
    {
        //private static CarContext _context = new();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            using var context = new CarContext();            
            var model = context.Models.Find(5);
            model.Editions.Add(
                    new Edition { Name = "Protonic Red Edition"}
            );

            using var newContext = new CarContext();
            // will also update Model which is overhead!
            newContext.Models.Update(model);
            newContext.SaveChanges();
        }
    }
}