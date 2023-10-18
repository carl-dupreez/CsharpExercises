using System.Diagnostics.Contracts;

class ClassA{
    public double salary { get; set; }
    public double tax { get; set; }

    public ClassA(double salary)
    {
        this.salary = salary;
    }

    public double Calculatetax()
    {
        if(salary <= 8350)
        {
            return tax = salary * 0.10;
        }
        else if(salary> 8350 && salary <= 33950)
        {
            return tax = salary * 0.15;
        }
        else{
            return tax = salary * 0.25;
        }
    }
}