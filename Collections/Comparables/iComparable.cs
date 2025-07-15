using System;
using System.Collections.Generic;

namespace Collections
{
    // Rule: Implement IComparable<T> when you want objects of your class to be comparable to each other.
    // It enables sorting (like with List.Sort()).
    class Employee : IComparable<Employee> // Generic version preferred for type safety
    {
        public int empId { get; set; }
        public string empName { get; set; }
        public int salary { get; set; }

        // Rule: Implement CompareTo() method to define how two objects should be compared.
        // This method is called automatically by sorting functions.
        public int CompareTo(Employee obj)
        {
            // Rule: CompareTo must return:
            // - A negative number (usually -1) if 'this' object is less than 'obj'
            // - Zero if 'this' is equal to 'obj'
            // - A positive number (usually 1) if 'this' is greater than 'obj'

            // Here, we're sorting based on empId (ascending order)
            return this.empId.CompareTo(obj.empId);

            // Note: You could also use:
            // if (this.empId > obj.empId) return 1;
            // else if (this.empId < obj.empId) return -1;
            // else return 0;
        }
    }

    class Lists
    {
        List<Employee> emp = new List<Employee>();

        public void ListMethods()
        {
            // Creating sample employee objects
            Employee e1 = new Employee { empId = 3, empName = "Ram", salary = 1000 };
            Employee e2 = new Employee { empId = 2, empName = "Raju", salary = 500 };
            Employee e3 = new Employee { empId = 1, empName = "Raju", salary = 2000 };

            // Adding employees to the list
            emp.Add(e1);
            emp.Add(e2);
            emp.Add(e3);

            // Rule: List<T>.Sort() will use CompareTo method of Employee
            emp.Sort(); // Sorts the list in ascending order of empId

            // Output the sorted list
            foreach (Employee i in emp)
            {
                Console.WriteLine($"Id: {i.empId}, Name: {i.empName}, Salary: {i.salary}");
            }
        }
    }
}
