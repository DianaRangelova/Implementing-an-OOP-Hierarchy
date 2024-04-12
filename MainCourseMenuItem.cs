using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    //АРТИКУЛ ОТ МЕНЮТО -> ОСНОВНО ЯСТИЕ
    public class MainCourseMenuItem : MenuItem
    {
        //Наследени характеристики от MenuItem: Name, Description, Price

        //Конструктор
        public MainCourseMenuItem(string name, string description, decimal price) 
            : base(name, description, price)
        {
        }

        //ToString -> "Main Course: {base.ToString()}"
        public override string ToString()
        {
            return "Main Course: " + base.ToString();
        }
    }
}
