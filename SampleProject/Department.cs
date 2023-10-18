class Department{
    private string deptName;
    private double deptBudget;
    private int counter = 0;

    Employee[] employees = new Employee[5];

    public Department(string deptName){
        this.deptName = deptName;
        this.deptBudget = 50000;
    }

    public double AddEmployee(Employee emp){
        employees[counter] = emp;
        counter++;

        if (emp.empGrade >= 5){
            return this.deptBudget += 150000;
        }
        else
        {
            return this.deptBudget += 100000;
        }
    }
}