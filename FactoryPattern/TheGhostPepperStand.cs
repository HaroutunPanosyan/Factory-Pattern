using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>  
    /// Creates different types of food related objects.
    /// </summary>
    static class TheGhostPepperStandFactory
    {
        /// <summary>  
        /// Takes the users input and returns a food type that conforms to the IOrderable interface.
        /// </summary>
        /// <param name="foodChoice"></param>
        /// <returns>
        /// IOrderable
        /// </returns>
        public static IOrderable GetOrder(string patronChoice)
        {
            switch (patronChoice.ToLower())
            {
                case "1":
                case "Soft Shell Taco":
                case "Ghost Pepper and Thyme Taco":
                case "Ghost Pepper and Thyme Soft Shell Taco":
                case "GPaT Taco":
                    return new SoftShellTaco_GPaT();
                case "2":
                case "Burrito":
                case "Ghost Pepper and Thyme Burrito":
                case "GPaT Burrito":
                    return new Burrito_GPaT();
                default:
                    return new SoftShellTaco_GPaT();
            }
        }
        
    }
}
