namespace CSharp_DZ_7_Dedok
{
    //1
    public class Animal
    {
        public string Name { get; set; }
        public string Characteristics { get; set; }
        public Animal(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Характеристики: {Characteristics}");
        }
    }
    public class Tiger : Animal
    {
        public Tiger(string name, string characteristics)
            : base(name, characteristics) { }
        public override void DisplayInfo()
        {
            Console.WriteLine("Это тигр.");
            base.DisplayInfo();
        }
    }
    public class Crocodile : Animal
    {
        public Crocodile(string name, string characteristics)
            : base(name, characteristics) { }
        public override void DisplayInfo()
        {
            Console.WriteLine("Это крокодил.");
            base.DisplayInfo();
        }
    }
    public class Kangaroo : Animal
    {
        public Kangaroo(string name, string characteristics)
            : base(name, characteristics) { }
        public override void DisplayInfo()
        {
            Console.WriteLine("Это кенгуру.");
            base.DisplayInfo();
        }
    }
    //2
    namespace Workers
    {
        public abstract class Worker
        {
            public string Name { get; set; }
            public string Position { get; set; }
            public Worker(string name, string position)
            {
                Name = name;
                Position = position;
            }
            public abstract void Print();
        }
        public class President : Worker
        {
            public President(string name)
                : base(name, "President") { }
            public override void Print()
            {
                Console.WriteLine($"Name: {Name}, Position: {Position}");
                Console.WriteLine("Responsible for overall strategy and vision.");
            }
        }
        public class Security : Worker
        {
            public Security(string name)
                : base(name, "Security") { }
            public override void Print()
            {
                Console.WriteLine($"Name: {Name}, Position: {Position}");
                Console.WriteLine("Responsible for safety and security of the premises.");
            }
        }
        public class Manager : Worker
        {
            public Manager(string name)
                : base(name, "Manager") { }
            public override void Print()
            {
                Console.WriteLine($"Name: {Name}, Position: {Position}");
                Console.WriteLine("Responsible for managing teams and projects.");
            }
        }
        public class Engineer : Worker
        {
            public Engineer(string name)
                : base(name, "Engineer") { }
            public override void Print()
            {
                Console.WriteLine($"Name: {Name}, Position: {Position}");
                Console.WriteLine("Responsible for designing and implementing solutions.");
            }
        }
        //3
        namespace Vehicles
        {
            public abstract class Vehicle
            {
                public string Name { get; set; }
                public string Model { get; set; }
                public Vehicle(string name, string model)
                {
                    Name = name;
                    Model = model;
                }
                public abstract void Display();
            }
            public class Plane : Vehicle
            {
                public int MaxAltitude { get; set; }
                public Plane(string name, string model, int maxAltitude)
                    : base(name, model)
                {
                    MaxAltitude = maxAltitude;
                }
                public override void Display()
                {
                    Console.WriteLine($"Plane: {Name}, Model: {Model}, Max Altitude: {MaxAltitude} meters");
                }
            }
            public class Car : Vehicle
            {
                public int MaxSpeed { get; set; }
                public Car(string name, string model, int maxSpeed)
                    : base(name, model)
                {
                    MaxSpeed = maxSpeed;
                }
                public override void Display()
                {
                    Console.WriteLine($"Car: {Name}, Model: {Model}, Max Speed: {MaxSpeed} km/h");
                }
            }
            //4
            namespace Equations
            {
                public abstract class Equation
                {
                    public abstract void Solve();
                }
                public class LinearEquation : Equation
                {
                    private double a;
                    private double b;
                    public LinearEquation(double a, double b)
                    {
                        this.a = a;
                        this.b = b;
                    }
                    public override void Solve()
                    {
                        if (a == 0)
                        {
                            if (b == 0)
                            {
                                Console.WriteLine("Уравнение имеет бесконечно много решений.");
                            }
                            else
                            {
                                Console.WriteLine("Уравнение не имеет решений.");
                            }
                        }
                        else
                        {
                            double x = -b / a;
                            Console.WriteLine($"Решение линейного уравнения: x = {x}");
                        }
                    }
                }
                public class QuadraticEquation : Equation
                {
                    private double a;
                    private double b;
                    private double c;

                    public QuadraticEquation(double a, double b, double c)
                    {
                        this.a = a;
                        this.b = b;
                        this.c = c;
                    }

                    public override void Solve()
                    {
                        double discriminant = b * b - 4 * a * c;

                        if (discriminant > 0)
                        {
                            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                            Console.WriteLine($"Решения квадратного уравнения: x1 = {x1}, x2 = {x2}");
                        }
                        else if (discriminant == 0)
                        {
                            double x = -b / (2 * a);
                            Console.WriteLine($"Решение квадратного уравнения: x = {x}");
                        }
                        else
                        {
                            Console.WriteLine("Квадратное уравнение не имеет действительных корней.");
                        }
                    }
                }
                    internal class Program
                    {
                        static void Main(string[] args)
                        {
                            //Task_1 - Создать базовый класс «Животное» и производные классы «Тигр», «Крокодил», «Кенгуру».
                            //С помощью конструктора установить имя каждого животного и его характеристики.
                            //Создайте для каждого класса необходимые методы и поля.
                            Console.WriteLine("Task 1:");
                            Tiger tiger = new Tiger("Тигр", "Хищник, обитает в джунглях");
                            Crocodile crocodile = new Crocodile("Крокодил", "Пресмыкающееся, обитает в воде");
                            Kangaroo kangaroo = new Kangaroo("Кенгуру", "Млекопитающее, обитает в Австралии");
                            tiger.DisplayInfo();
                            Console.WriteLine();
                            crocodile.DisplayInfo();
                            Console.WriteLine();
                            kangaroo.DisplayInfo();
                            Console.WriteLine();
                            Console.WriteLine("Task 2:");
                            //Task_2 - Создать абстрактный базовый класс Worker (работник) с методом Print(). Создайте четыре производных класса:
                            //President, Security, Manager, Engineer.
                            //Переопределите метод Print() для вывода информации, соответствующей каждому типу работника.
                            Worker president = new President("Alice");
                            Worker security = new Security("Bob");
                            Worker manager = new Manager("Charlie");
                            Worker engineer = new Engineer("Dave");
                            president.Print();
                            Console.WriteLine();
                            security.Print();
                            Console.WriteLine();
                            manager.Print();
                            Console.WriteLine();
                            engineer.Print();
                            Console.WriteLine();
                            Console.WriteLine("Task 3:");
                            //Task_3 - Создать абстрактный класс Vehicle (транспортное средство).
                            //Включите в этот класс абстрактный метод вывода объекта на экран.
                            //На его основе реализовать классы Plane (самолет) и Саr (автомобиль) со своими конструкторами и методами вывода на экран.
                            //Программа должна вывести на экран объекты классов Plane и Саr.
                            //Вызовы метода вывода на экран осуществлять через единственную ссылку на базовый класс.
                            //Vehicle plane = new Plane("Boeing", "747", 35000);
                            //Vehicle car = new Car("Tesla", "Model S", 250);
                            //plane.Display();
                            //car.Display();
                            Console.WriteLine();
                            Console.WriteLine("Task 4:");
                            //Task_4 - Создать абстрактный базовый класс с абстрактной функцией — корни уравнения.
                            //Создать производные классы: класс линейных уравнений и класс квадратных уравнений.
                            //Определить функцию вычисления корней уравнений.
                            Equation linearEquation = new LinearEquation(2, -4);
                            Equation quadraticEquation = new QuadraticEquation(1, -3, 2);
                            linearEquation.Solve();
                            quadraticEquation.Solve();
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
}