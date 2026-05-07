using Lab3_App;

class Program
{
    // Для друку масиву
    static void PrintPlanes(PlaneClass [] planes)
    {
        foreach (var plane in planes)
        {
            Console.WriteLine($"{plane}\n");
        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int variant = 2;

        Console.WriteLine($"Варіант: {variant}");
        Console.WriteLine($"C11 =  {variant % 11}\n");

        PlaneClass[] planes = { 
            new PlaneClass("A123", "ВирЛіт", 150, 840),
            new PlaneClass("111", "Літакоництво", 180, 850),
            new PlaneClass("A321", "ВирЛіт", 300, 900)};

        Console.WriteLine("=============Початковий список літаків=============");
        PrintPlanes(planes);

        Console.WriteLine("=============Відсортовано за моделлю за зростанням=============");
        Array.Sort(planes, (a, b) => string.Compare(a.Model, b.Model, StringComparison.OrdinalIgnoreCase));
        PrintPlanes(planes);

        Console.WriteLine("=============Відсортовано за швидкістю за спаданням=============");
        Array.Sort(planes, (a, b) => b.MaxSpeed.CompareTo(a.MaxSpeed));
        PrintPlanes(planes);

        PlaneClass searchObj = new PlaneClass("A123", "ВирЛіт", 150, 840);
        Console.WriteLine($"\n=============Пошук ідентичного літака {searchObj.Model} виробника" +
            $" {searchObj.Manufacturer} в масиві=============");

        bool exists = planes.Any(p => p.Equals(searchObj));
        if (exists)
            Console.WriteLine("Знайдено");
        else Console.WriteLine("Не знайдено");
    }
}