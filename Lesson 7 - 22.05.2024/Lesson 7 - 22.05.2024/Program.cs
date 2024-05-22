namespace Lesson_7___22._05._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer() { Name = "Abbas", Surname = "Bayramli",Age = 21, Experience = 5 };
            //developer.Age = 21;
            //developer.Experience = 5;
            Backend backend = new Backend() { Name = "Abbas", Surname = "Bayramli", Age = 21, Experience = 5, SqlExperienceYear = 2};
            Frontend frontend = new Frontend() { Name = "Abbas", Surname = "Bayramli", Age = 21, Experience = 5, ReactExperienceYear = 1 };

            Console.WriteLine("Name: " + developer.Name);
            Console.WriteLine("Surname: " + developer.Surname);
            Console.WriteLine("Age: " + developer.Age);
            Console.WriteLine("Experience: " + developer.Experience);

            Console.WriteLine("Sql Experience Year: " + backend.SqlExperienceYear);
            Console.WriteLine("React Experience Year: " + frontend.ReactExperienceYear);
        }
    }
}