using System;

public class Employee
{
    // field private
    private string name;
    private int id;

    //properti untuk mengakses field name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    //properti untuk mengakses filed id
    public int ID
    {
        get { return id; }
        set { id = value; }
    }

    // konstruktor
    public Employee(string name, int id)
    {
        Name = name;
        ID = id;
    } 

    // Metode untuk menghitung gaji
    public virtual double CalculateSalary()
    {
        return 0.0;
    }

    // Metode untuk menampilkan informasi karyawan
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"ID: {ID}, Name: {Name}");
    }
}

/*
using System;

public class Employee
{
    public string Name { get; set; }
    public int ID { get; set; }

    public virtual double CalculateSalary()
    {
        return 0.0;
    }

    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"ID: {ID}, Name: {Name}");
    }
}
*/
