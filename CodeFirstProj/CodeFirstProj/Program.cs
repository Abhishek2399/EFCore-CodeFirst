using System;
using CodeFirstProj.Models;
using System.Linq;
using System.Data.SqlClient;

namespace CodeFirstProj
{
    class Program
    {
        // Seperate folder should be created to organise all classes "Models" named is preferred
        // 1-Class) -> DbContext , based on Proj name we should write eg:ProjDbContext

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
            try
            {
                Employee abhi = new Employee();
                abhi.EName = "Abhishek";
                abhi.ESal = 50000;
                dB.Employees.Add(abhi);
                dB.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ShowEmployees()
        {
            try
            {
                var emps = dB.Employees.ToList();
                if (emps != null)
                {
                    foreach (var emp in emps)
                    {
                        Console.WriteLine(emp);
                    }
                }
                else
                {
                    Console.WriteLine("Table Empty");
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateEmployee()
        {

            try
            {
                Console.WriteLine("Enter the ID to Update");
                int idToUpdate = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the new salary to Update");
                string newSal = Console.ReadLine();

                Console.WriteLine("Enter the new name to Update");
                string newName = Console.ReadLine();

                Employee toUpdate = dB.Employees.Find(idToUpdate);
                toUpdate.EName = newName == "" | newName == " " ? toUpdate.EName : newName;
                toUpdate.ESal = newSal == "" | newSal == " " ? toUpdate.ESal : Convert.ToInt32(newSal);
                dB.SaveChanges();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
