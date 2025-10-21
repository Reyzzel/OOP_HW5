using System;
using System.Text;

namespace structures_and_classes
{
    struct Student
    {
        int age;
        string name;

        // Цей конструктор буде викликано
        public Student()
        {
            age = 16;
            name = "Ivan";
        }

        // Додамо метод, щоб побачити результат
        public void Print()
        {
            Console.WriteLine($"Ім'я: {name}, Вік: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Student st = new Student();

            st.Print();

            Console.ReadKey();
        }
    }
}
