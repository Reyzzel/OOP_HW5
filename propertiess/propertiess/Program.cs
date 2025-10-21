using System;
using System.Text;

namespace propertiess
{
    //class Square
    //{
    //    private double side; /*довжина сторони*/
    //    public double Area /*площа*/
    //    {
    //        get { return side * side; }
    //        set { side = Math.Sqrt(value); }
    //    }
    //}
    //class Student
    //{
    //    //Автоматично реалізовані властивості (Auto-implemented properties)
    //    //на випадок примитивних get i set

    //    // ініціалізація автоматично реалізованих
    //    //властивостей можлива, починаючи з версії C# 6
    //    public string Name { get; set; } = "Іван";
    //    public int Age { get; set; } = 21;
    //}

    class Student
    {
        private static string name;
        public static string Name
        {
            set { name = value; }
            get { return name; }
        }
    }
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student.Name = "Іван";
            Console.WriteLine("Ім'я студента: " + Student.Name);
            Console.ReadKey();
        }
    }
}
