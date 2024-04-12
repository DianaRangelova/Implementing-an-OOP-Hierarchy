using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class Order
    {
        //ХАРАКТЕРИСТИКИ

        //Частен списък
        //поле -> описваме / модифицираме артикулите
        private List<MenuItem> _items = new();
        //Място, където да съхраним нашите артикули

        //Метод
        //СЪЗДАВАНЕ ДОСТЪП САМО ЗА ЧЕТЕНЕ (енкапсулация)
        //поле -> за външния свят
        public IReadOnlyCollection<MenuItem> Items => this._items.AsReadOnly();

        //ПОВЕДЕНИЕ / ДЕЙНОСТИ

        //Метод
        //1. Добавяне на артикул в поръчката
        public void AddItem(MenuItem menuItem)
        {
            this._items.Add(menuItem);
        }

        //Метод
        //2. Изчисляване на общата сума на поръчката
        //_items = {12.90, 8.90, 5.60}
        public decimal GetTotal()
        {
            return this._items.Select(item => item.Price).Sum();
        }
    }
}
