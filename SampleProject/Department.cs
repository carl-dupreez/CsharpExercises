class Department{
    private string deptName;
    private double deptBudget;
    private int counter = 0;

    Employee[] employees = new Employee[5];

    public Department(string deptName){
        this.deptName = deptName;
        this.deptBudget = 50000;
    }

    public void AddEmployee(Employee emp){
        employees[counter] = emp;
        counter++;

        if (emp.empGrade >= 5){
            this.deptBudget += 150000;
        }
        else
        {
            this.deptBudget += 100000;
        }
    }

    public void describe(){
        Console.WriteLine("Department name Name: {0}", this.deptName);
        Console.WriteLine("Department Budget: {0}", this.deptBudget);

        foreach (Employee employee in employees){
            if (employee != null)
            {
                Console.WriteLine("Employee Salary: {0}", employee.getEmpName());
            }
        }      
    }
}