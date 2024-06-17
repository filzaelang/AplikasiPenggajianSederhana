using System;
public class HourlyEmployee : Employee
{
    private double hourlyRate;
    private double hoursWorked;

    public double HourlyRate
    {
        get { return hourlyRate; }
        set { hourlyRate = value; }
    }

    public double HoursWorked
    {
        get { return hoursWorked; }
        set { hoursWorked = value; }
    }

    public HourlyEmployee(string name, int id, double hourlyRate, double hoursWorked) : base(name, id)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override double CalculateSalary()
    {
        return HourlyRate * HoursWorked; 
    }
}

/*
public class HourlyEmployee : Employee
{
    public double HourlyRate { get; set; }
    public double HoursWorked { get; set; }

    public HourlyEmployee(string name, int id, double hourlyRate, double hoursWorked)
    {
        Name = name;
        ID = id;
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override double CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }
}
*/
