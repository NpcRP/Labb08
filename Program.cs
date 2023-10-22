using System;
using System.Collections.Generic;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, string gender, double salary)
    {
        Id = id;
        Name = name;
        Gender = gender;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"ID = {Id}, Name = {Name}, Gender = {Gender}, Salary = {Salary:C}";
    }
}

class Program
{
    static void Main()
    {
        Stack<Employee> employeeStack = new Stack<Employee>();

        Employee helena = new Employee(1, "Helena", "Female", 5000);
        Employee miriam = new Employee(2, "Miriam", "Female", 6000);
        Employee sanna = new Employee(3, "Sanna", "Female", 7000);
        Employee ake = new Employee(4, "Åke", "Male", 8000);
        Employee markus = new Employee(5, "Markus", "Male", 9000);

        employeeStack.Push(markus);
        employeeStack.Push(ake);
        employeeStack.Push(sanna);
        employeeStack.Push(miriam);
        employeeStack.Push(helena);

        Console.WriteLine("Employees in the Stack:");
        foreach (var employee in employeeStack)
        {
            Console.WriteLine(employee);
            Console.WriteLine($"{employeeStack.Count} objects left in the Stack");
        }

        Console.WriteLine("\nRetrieving all objects using the Pop method:");
        while (employeeStack.Count > 0)
        {
            Console.WriteLine(employeeStack.Pop());
            Console.WriteLine($"{employeeStack.Count} objects left in the Stack");
        }

        employeeStack.Push(markus);
        employeeStack.Push(ake);
        employeeStack.Push(sanna);
        employeeStack.Push(miriam);
        employeeStack.Push(helena);

        Console.WriteLine("\nRetrieving objects using the Peek method:");
        Console.WriteLine(employeeStack.Peek());
        Console.WriteLine(employeeStack.Peek());
        Console.WriteLine($"{employeeStack.Count} objects left in the Stack");

        var targetEmployee = new Employee(2, "Miriam", "Female", 6000);
        Console.WriteLine($"\nChecking if {targetEmployee.Name} object exists in the stack or not:");
        if (employeeStack.Contains(targetEmployee))
        {
            Console.WriteLine($"{targetEmployee.Name} object exists in the stack");
        }
        else
        {
            Console.WriteLine($"{targetEmployee.Name} object does not exist in the stack");
        }

        List<Employee> employeeList = new List<Employee>
        {
            helena, miriam, sanna, ake, markus
        };

        Console.WriteLine($"\n{targetEmployee.Name} object exists in the list");

        Console.WriteLine("\nFinding all male employees in the list:");
        var maleEmployees = employeeList.FindAll(e => e.Gender == "Male");
        foreach (var employee in maleEmployees)
        {
            Console.WriteLine(employee);
        }

        Console.WriteLine("\nFinding all female employees in the list:");
        var femaleEmployees = employeeList.FindAll(e => e.Gender == "Female");
        foreach (var employee in femaleEmployees)
        {
            Console.WriteLine(employee);
        }
    }
}
