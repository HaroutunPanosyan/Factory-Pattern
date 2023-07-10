using System.Diagnostics;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! What would you like to have today?");
            Console.WriteLine($"We have: \n" +
                              $"1) Ghost Pepper Soft Shell Tacos. \n" +
                              $"2) Ghost Pepper Burrito");
            string patronChoice = Console.ReadLine();
            IOrderable option = TheGhostPepperStandFactory.GetOrder(patronChoice);
            option.Description();

            
            string formattedPrice = option.Price.ToString("F2");
            Console.WriteLine($"The price of our {option.Name} is ${formattedPrice}.");
        }
    }
}
