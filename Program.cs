using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Membuat daftar karyawan
        List<Employee> employees = new List<Employee>
        {
            new SalariedEmployee("Alice", 1, 60000),
            new HourlyEmployee("Bob", 2, 20, 160),
            new HourlyEmployee("Charlie", 3, 25, 150),
            new SalariedEmployee("Diana", 4, 72000)
        };

        // Memproses penggajian
        ProcessPayroll(employees);
    }

    static void ProcessPayroll(List<Employee> employees)
    {
        foreach (var employee in employees)
        {
            employee.DisplayEmployeeInfo();
            Console.WriteLine($"Salary: {employee.CalculateSalary():C2}");
            Console.WriteLine();
        }
    }
}

/*
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new SalariedEmployee("Alice", 1, 60000),
            new HourlyEmployee("Bob", 2, 20, 160),
            new HourlyEmployee("Charlie", 3, 25, 150),
            new SalariedEmployee("Diana", 4, 72000)
        };

        ProcessPayroll(employees);
    }

    static void ProcessPayroll(List<Employee> employees)
    {
        foreach (var employee in employees)
        {
            employee.DisplayEmployeeInfo();
            Console.WriteLine($"Salary: {employee.CalculateSalary():C2}");
            Console.WriteLine();
        }
    }
}
*/
