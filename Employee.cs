using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericEg
{
    public class Employee
    {
        public int Eid { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public Employee() { } //default Constructor

        public static List<Employee> list = new List<Employee>();
        public Employee(int eid, string name, float salary)
        {
            Eid = eid;
            Name = name;
            Salary = salary;
        }

        public static Employee CreateEmployee(int eid, string ename, float sal)
        {
            Employee emp = new Employee();
            emp.Name = ename;
            emp.Salary = sal;
            emp.Eid = eid;
            
            return emp;
        }


    }
    public class EmployeeClient
    {
        public static List<Employee> list = new List<Employee>();
        public static void Main()
        {
            
        
            Console.WriteLine("Enter the Eid, name and Salary");
            int eid = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            float salary = Convert.ToInt32(Console.ReadLine());
          //  Employee e = new Employee(eid, name, salary);

            Employee e=Employee.CreateEmployee(eid,name,salary);
            list.Add(e);


            foreach (var item in list)
            {
                Console.WriteLine(item.Eid + " " + item.Name + " " + item.Salary);
            }

        }
    }
}
