namespace ExerciseOopHierarchy;

public abstract class MenuItem
{
    // 1. Създаване на пропъртита
    //Артикул от менюто -> име, описание, цена
    //Състояние / характеристики -> полета / property
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    // 2. Създаване на конструктор - ALT + Enter върху името на класа (MenuItem)
    //Конструктор -> създава обект от класа
    protected MenuItem(string name, string description, decimal price)
    {
        Name = name;
        Description = description;
        Price = price;
    }

    // 3. Добавяне на метод override
    //Поведение / дейности
    //ToString -> обекта под формата на текст -> "ExerciseOopHierarchy.MenuItem"
    public override string ToString()
    {
        return $"{this.Name} - {this.Description} - ${this.Price}";
    }
}


