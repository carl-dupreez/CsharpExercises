class Employee{
    private string empName;
    public int empGrade {private set; get;}

    public Employee(string empName, int empGrade)
    {
        this.empName = empName;
        this.empGrade = empGrade;
    }

    public string getEmpName(){
        return this.empName;
    }
}