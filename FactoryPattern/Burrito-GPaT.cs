using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Burrito_GPaT : IOrderable
    {
        public string Name { get; set; } = "Ghost Pepper and Thyme Fully Loaded Burrito";
        public double Price { get; set; } = 14.50d;
        public int MenuNumber { get; set; } = 2;
        public bool ToGo { get; set; }
        public bool Customize { get; set; } = true;

        public void Description()
        {
            Console.WriteLine("Our house-made tortilla with ghost pepper and thyme intrecately woven into each of the fibers. Watch out, it's spicy!\n" +
                $"It comes fully loaded with {CustomizationItems.MeatChoices(1)}, a wonderful blend of {CustomizationItems.CheeseChoices.Cheddar}, " +
                $"{CustomizationItems.CheeseChoices.Brie} and {CustomizationItems.CheeseChoices.Mozzarella} cheeses, {CustomizationItems.VeggieChoices(3)}, " +
                $"{CustomizationItems.VeggieChoices(5)}, {CustomizationItems.VeggieChoices(13)} and a side of " +
                $"our house-made {CustomizationItems.SauceChoices(3)} Sauce, for that extra bit of heat.");
        }
    }
}
