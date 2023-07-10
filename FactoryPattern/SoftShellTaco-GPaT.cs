using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class SoftShellTaco_GPaT : IOrderable
    {
        public string Name { get; set; } = "Ghost Pepper and Thyme Soft Shell Taco";
        public double Price { get; set; } = 6.50d;
         
        public int MenuNumber { get; set; } = 1;
        public bool ToGo { get; set; }
        public bool Customize { get; set; } = false;

        public void Description()
        {
            Console.WriteLine("Our house-made tortilla with ghost pepper and thyme intrecately woven into each of the fibers. Watch out, it's spicy!\n" +
                $"It comes fully loaded with {CustomizationItems.MeatChoices(0)}, {CustomizationItems.CheeseChoices.Cheddar} cheese, " +
                $"{CustomizationItems.FruitChoices.Tomatoes}, long strips of {CustomizationItems.VeggieChoices(13)} and a side of " +
                $"our house-made {CustomizationItems.SauceChoices(3)} Sauce, for that extra bit of heat.");
        }
        
    }
}
