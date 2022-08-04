using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            manager.CAdd(new Customer { Id = 1, FirstName = "Zeynep", LastName = "Ceyhan", Address = "İzmir" });

            // or
            Student student = new Student();
            student.Id = 1;
            student.FirstName = "Zeynep";
            student.LastName = "Ceyhan";
            student.Departmant = "Computer Engineering";
            manager.SAdd(student);

            // or
            Customer customer = new Customer
            {
                Id = 2,
                FirstName = "Emir",
                LastName = "Ceyhan",
                Address = "İzmir"
            };
            manager.CAdd(customer);

            Student student1 = new Student
            {
                Id = 3,
                FirstName = "Büşra",
                LastName = "Yardım",
                Departmant = "Computer Programming"
            };
            manager.Add(student);
            manager.Add(customer);

            Console.ReadLine();
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void CAdd(Customer customer)
        {
            Console.Write("Customer: ");
            Console.WriteLine(customer.FirstName);
        }
        public void SAdd(Student student)
        {
            Console.Write("Student: ");
            Console.WriteLine(student.FirstName);
        }

        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}