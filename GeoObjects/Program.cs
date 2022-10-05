using GeographicalObjects;

abstract class GeographicalObject
{
    protected double X { get; set; }
    protected double Y { get; set; }
    public string name;
    public string description;
    public virtual void displayInfo() { }
    public GeographicalObject(string name, string description, double x, double y)
    {
        this.name = name;
        this.description = description;
        this.X = x;
        this.Y = y;

    }
    public GeographicalObject()
    {
        this.name = null;
        this.description = null;
        this.X = 0.0;
        this.Y = 0.0;
    }
}

class River : GeographicalObject
{
    private double streamSpeed;                //  sm/sec
    private double generalLength;
    public River()
    {
        this.streamSpeed = 0.0;
        this.generalLength = 0.0;     //km
    }
    public River(string name, string description, double x, double y, double streamSpeed, double generalLength)
        : base(name, description, x, y)
    {
        this.streamSpeed = streamSpeed;
        this.generalLength = generalLength;
    }
    public override void displayInfo()
    {
        Console.WriteLine($"{this.name} - {this.description}. ");
        Console.WriteLine($"Координати початку рiчки: {this.X}/{this.Y}. ");
        Console.WriteLine($"Швидкiсть течiї рiчки: {this.streamSpeed} км/сек. ");
        Console.WriteLine($"Загальна довжина рiчки: {this.generalLength} км.");
        Console.WriteLine("");
    }
}

class Mountain : GeographicalObject
{
    private double highestPoint;   //above sea level (km)
    public Mountain()
    {
        this.highestPoint = 0.0;
    }
    public Mountain(string name, string description, double x, double y, double highestPoint)
        : base(name, description, x, y)
    {
        this.highestPoint = highestPoint;
    }
    public override void displayInfo()
    {
        Console.WriteLine($"{this.name} - {this.description}. ");
        Console.WriteLine($"Координати: {this.X}/{this.Y}. ");
        Console.WriteLine($"Найвища точка над рiвнем моря: {this.highestPoint} м.");
        Console.WriteLine("");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        List<River> riverList = new List<River>();
        List<Mountain> mountainList = new List<Mountain>();
        riverList.Add(new River("Нiл", "Друга найдовша рiчка в свiтi", 31, 30, 6, 6853));
        riverList.Add(new River("Днiпро", "Найдовша рiчка в Українi", 55.52, 33.43, 10, 2201));
        mountainList.Add(new Mountain("Говерла", "Найвища гора в Українi", 48.09, 24.30, 2.061));
        mountainList.Add(new Mountain("Еверест", "Найвища гора у свiтi", 27.59, 86.55, 8.848));

        while (true)
        {
            Console.WriteLine("Оберiть дiю, яку хочете здiйснити та введiть її номер:");
            Console.WriteLine("1. Переглянути список рiчок та iнформацiю про них.");
            Console.WriteLine("2. Переглянути список гiр та iнформацiю про них.");
            Console.WriteLine("0. Завершити програму.");

            int operationNum = 3;
            try
            {
                operationNum = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("");
            }

            switch (operationNum)
            {
                case 1:
                    foreach (River river in riverList)
                    {
                        river.displayInfo();
                    }
                    break;
                case 2:
                    foreach (Mountain mountain in mountainList)
                    {
                        mountain.displayInfo();
                    }
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
