using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IOrderable 
    {
        public string Name { get; set; }
        public static string[]? SharedVeggieArray { get; set; }
        public static string[]? SharedSauceArray { get; set; }
        public static string[]? SharedMeatArray { get; set; }
        public double Price { get; set; }
        public int MenuNumber { get; set; }
        public bool ToGo { get; set; }
        public bool Customize { get; set; }
        public void Description();

    }
}
