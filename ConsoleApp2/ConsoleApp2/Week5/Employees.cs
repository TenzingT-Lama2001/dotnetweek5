using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp2.Week5
{
    class Employees
    {
        public static void createEmployee()
        {
            //list of 10 EmplooyeeModels objects
            List<EmployeesModel> list = new List<EmployeesModel>
            {

                new EmployeesModel{name="Ram Baral", email="ram@gmail.com", phone=1234567890, age=20, gender="male", position="Cloud Engineer", salary=90000, education="bachelors", department="Cloud"},

                new EmployeesModel{name="Dazn Lama", email="dazn@gmail.com", phone=1234467890, age=22, gender="female", position="Cloud Engineer", salary=100000, education="bachelors", department="Cloud"},

                new EmployeesModel{name="Callux Dong", email="Callux@gmail.com", phone=3234567890, age=24, gender="male", position="Project Manager", salary=200000, education="masters", department="Development"},

                new EmployeesModel{name="Harry Styles", email="Harry@gmail.com", phone=4234567890, age=21, gender="male", position="QA", salary=70000, education="masters", department="Development"},

                new EmployeesModel{name="Money Man", email="Money@gmail.com", phone=5235567890, age=20, gender="female", position="Backend", salary=60000, education="masters", department="Development"},

                new EmployeesModel{name="Hello World", email="Hello@gmail.com", phone=8234567890, age=25, gender="male", position="Frontend", salary=82000, education="bachelors", department="Development"},

                new EmployeesModel{name="Sandesh Man", email="Sandesh@gmail.com", phone=9334567890, age=30, gender="female", position="Backend", salary=10000, education="bachelors", department="Development"},

                new EmployeesModel{name="Bat Man", email="Bat@gmail.com", phone=7234567890, age=35, gender="male", position="Frontend", salary=500000, education="bachelors", department="Development"},

                new EmployeesModel{name="Super Man", email="Super@gmail.com", phone=6434667890, age=31, gender="female", position="UI/UX", salary=700000, education="masters", department="Design"},

                new EmployeesModel{name="Spider Woman", email="Spider@gmail.com", phone=8134567890, age=21, gender="female", position="Product Designer", salary=155000,education="masters", department="Design"},
            };

            Console.WriteLine("Here are the list of Cloud Engineer: ");
            List<EmployeesModel> searchedResult = list.Where(emp => (emp.position == "Cloud Engineer")).ToList();
            searchedResult.ForEach(emp => Console.WriteLine("Name: " + emp.name + "\n Email: " + emp.email + "\n Position: " + emp.position + "\n Salary: " + emp.salary + "\n"));

            List<EmployeesModel> sortAsc = list.OrderBy(emp => emp.salary).ToList();
            Console.WriteLine("\n\nSorted list in ascending order by salary:");
            sortAsc.ForEach(emp => Console.WriteLine("Name: " + emp.name + "\nPosition: " + emp.position + "\nSalary: " + emp.salary + "\n"));

            List<EmployeesModel> sortDes = list.OrderByDescending(emp => emp.salary).ToList();
            Console.WriteLine("\n\nSorted list in descending order by salary:");
            sortDes.ForEach(emp => Console.WriteLine("Name: " + emp.name + "\nSalary: " + emp.salary + "\nPosition: " + emp.position + "\n"));


            Console.WriteLine("\n\nSerializing the file and putting it on a file name empdata.json");

            string filename = "empdata.json";
            string jsonString = JsonSerializer.Serialize(searchedResult);
            File.WriteAllText(filename, jsonString);

            Console.WriteLine("File written: " + jsonString);
        }
    }
}
