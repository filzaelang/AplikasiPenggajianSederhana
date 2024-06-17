public class SalariedEmployee : Employee
{
    private double annualSalary;

    public double AnnualSalary
    {
        get { return annualSalary; }
        set { annualSalary = value; }
    }

    public SalariedEmployee(string name, int id, double annualSalary) : base(name, id)
    {
        AnnualSalary = annualSalary;
    }

    public override double CalculateSalary()
    {
        return AnnualSalary / 12;
    }
}

/*
public class SalariedEmployee : Employee
{
    public double AnnualSalary { get; set; }

    public SalariedEmployee(string name, int id, double annualSalary)
    {
        Name = name;
        ID = id;
        AnnualSalary = annualSalary;
    }

    public override double CalculateSalary()
    {
        return AnnualSalary / 12;
    }
}
*/
