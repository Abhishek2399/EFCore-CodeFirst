using System;
using CodeFirstProj.Models;
using System.Linq;

namespace CodeFirstProj
{
    class Program
    {
        // Seperate folder should be created to organise all classes "Models" named is preferred
        // 1-Class) -> DbContext , based on Proj name we should write eg ProjDbContext

        public static ProjDbContext dB = new ProjDbContext();
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                AddEmployee();
                ShowEmployees();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AddEmployee()
        {
            Employee abhi = new Employee();
            abhi.EName = "Abhishek";
            abhi.ESal = 50000;
            dB.Employees.Add(abhi);
            dB.SaveChanges();
        }

        public static void ShowEmployees()
        {
            var emps = dB.Employees.ToList();
            foreach(var emp in emps)
            {
                Console.WriteLine(emp);
            }
        }


    }
}
