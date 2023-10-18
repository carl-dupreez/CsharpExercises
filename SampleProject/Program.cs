Employee alex = new Employee("Alex Rod", 6);
Employee linda = new Employee("Lynda Berry", 7);
Employee John = new Employee("John Doe", 3);
Employee Sara = new Employee("Sara Time", 7);
Employee James = new Employee("James Doe", 4);

Department Sales = new Department("XYZ Sales");
Sales.AddEmployee(alex);
Sales.AddEmployee(linda);
Sales.AddEmployee(John);

Sales.describe();

Department IT = new Department("XYZ IT");
IT.AddEmployee(Sara);
IT.AddEmployee(James);

IT.describe();