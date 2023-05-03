#pragma warning disable
class Person
{
    public string Surname { get; private set; }
    public int Height { get; private set; }
    public int Weight { get; private set; }
    public DateTime Datebirth { get; private set; }
    public Person(string surname, int height, int weight, DateTime datebirth)
    {
        Surname = surname;
        Height = height;
        Weight = weight;
        Datebirth = datebirth;
    }
    public Person()
    {
        Surname = "undefined";
        Height = 0;
        Weight = 0;
        Datebirth = new DateTime(2000, 1, 1);
    }
    public void Input()
    {
        Console.Write("Введите фамилию: ");
        Surname = Console.ReadLine();
        Console.Write("Введите рост (см): ");
        Height = int.Parse(Console.ReadLine());
        Console.Write("Введите вес (кг): ");
        Weight = int.Parse(Console.ReadLine());
        Console.Write("Введите дату рождения: ");
        Datebirth = DateTime.Parse(Console.ReadLine());
    }
}
