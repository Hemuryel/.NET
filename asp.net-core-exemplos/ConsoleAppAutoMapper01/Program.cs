using System;

namespace ConsoleAppAutoMapper01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "Fulano";
            p.LastName = "Silva";

            //Employee e = new Employee();
            //e.FirstName = p.FirstName;
            //e.LastName = p.LastName;

            var configuration = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Person, Employee>();
            });
            var mapper = configuration.CreateMapper();
            var employee = mapper.Map<Employee>(p);

            Console.WriteLine(employee.FirstName + " - " + employee.LastName);
        }
    }

    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
