using Projektl1d6;
using System.Reflection.Metadata;

Employee employee1 = new Employee("Jan", "Kowalski", 20);
Employee employee2 = new Employee("Janusz", "Bizensu", 30);
Employee employee3 = new Employee("Marek", "Kondrat", 70);



employee1.AddScore(1);
employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);
employee1.AddScore(5);

employee2.AddScore(2);
employee2.AddScore(3);
employee2.AddScore(3);
employee2.AddScore(3);
employee2.AddScore(2);

employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(2);
employee3.AddScore(2);
employee3.AddScore(25);

List<Employee> Employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in Employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employeeWithMaxResult.Result;
    }
}

Console.WriteLine("Wygrał zdobywając " + employeeWithMaxResult.Result + " punktów " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + employeeWithMaxResult.Age + " lat");

//var result1 = employee1.Result; Sprawdzenie danych:
Console.WriteLine(employee1.Result + " punktów " + employee1.Name + " " + employee1.Surname + " " + employee1.Age + " lat");
//var result2 = employee2.Result;
Console.WriteLine(employee2.Result + " punktów " + employee2.Name + " " + employee2.Surname + " " + employee2.Age + " lat");
//var result3 = employee3.Result;
Console.WriteLine(employee3.Result + " punktów " + employee3.Name + " " + employee3.Surname + " " + employee3.Age + " lat");