using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{

    public class AppetizerMenuItem : MenuItem
    {
        //Наследени характеристики от MenuItem: Name, Description, Price

        //Конструктор
        public AppetizerMenuItem(string name, string description, decimal price) 
            : base(name, description, price)
        {
        }

        //ToString -> "Appetizer: {base.ToString()}"
        public override string ToString()
        {
            return "Apetizer: " + base.ToString();
        }
    }
}
