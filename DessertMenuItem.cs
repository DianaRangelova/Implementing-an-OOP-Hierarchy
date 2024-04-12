using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    //АРТИКУЛ ОТ МЕНЮТО -> ДЕСЕРТ
    public class DessertMenuItem : MenuItem
    {
        //Наследени характеристики от MenuItem: Name, Description, Price

        //Конструктор
        public DessertMenuItem(string name, string description, decimal price) 
            : base(name, description, price)
        {
        }

        //ToString -> "Dessert: {base.ToString()}"
        public override string ToString()
        {
            return "Dessert: " + base.ToString();
        }
    }
}
