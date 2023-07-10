using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class CustomizationItems 
    {      
        public enum FruitChoices { Tomatoes }
        public static string MeatChoices(int num)
        {
            IOrderable.SharedMeatArray = new string[]
            {
            "Seasoned Ground Beef", "Steak", "Chicken", "Pork"
            };
            return IOrderable.SharedMeatArray[num];
        }
        public enum CheeseChoices { Cottage, Cheddar, Parmesan, Cream, Brie, Mozzarella }
        public enum TortillaType { Soft, Hard, Special }
        public static string SauceChoices(int num)
        {
            IOrderable.SharedSauceArray = new string[]
            {
            "Mild", "Hot", "Volcano", "De Luca Loco", "Dynamite", "Ghost Pepper Ranch", "Ranch", "Buttermilk Ranch",
            };
            return IOrderable.SharedSauceArray[num];
        }
        public static string VeggieChoices(int num)
        {
            IOrderable.SharedVeggieArray = new string[]
            {
            "Spinach", "Kale", "Arugula", "Lettuce", "Coriander", "Potato", "Green Pepper", "Red Pepper", "Yellow Pepper",
            "Corn", "Mushroom", "Radish", "Raw Onion", "Caramelized Onion", "Cilantro"
            };
            return IOrderable.SharedVeggieArray[num];
        }
    }
}
