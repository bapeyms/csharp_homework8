namespace csharp_homework8;

public class Employee
{
    public string Name { get; set; } = string.Empty;
    public decimal Salary { get; set; } = 0m;

    public Employee()
    {
        Name = "Default";
        Salary = 17;
    }
    public Employee(string name, decimal salary)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("[EXCEPTION] Employee name cannot be empty ", nameof(name));
        if (salary < 0)
            throw new ArgumentException("[EXCEPTION] Salary cannot be negative ", nameof(salary));
        Name = name;
        Salary = salary;
    }

    public void Print()
    {
        Console.WriteLine($"--- EMPLOYEE INFO ---");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: {Salary}");
        Console.WriteLine("");
    }

    public void InputData()
    {
        Console.WriteLine("--- INPUT DATA ---");
        do
        {
            Console.Write("Enter your name: ");
            Name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(Name))
                Console.WriteLine("[ERROR] Enter a valid name");
        } while (string.IsNullOrWhiteSpace(Name));

        do
        {
            Console.Write("Enter your salary: ");
            string inputSalary = Console.ReadLine() ?? string.Empty;
            if (!decimal.TryParse(inputSalary, out decimal salary) || salary < 0)
            {
                Console.WriteLine("[ERROR] Enter a valid non-negative salary");
                continue;
            }
            Salary = salary;
            break;
        } while (true);
    }

    public static Employee operator +(Employee e, decimal value)
    {
        if (e == null)
            throw new ArgumentNullException(nameof(e));
        if (value < 0)
            throw new ArgumentException("[EXCEPTION] Value cannot be negative", nameof(value));
        
        return new Employee(e.Name, e.Salary + value);
    }
    public static Employee operator +(decimal value, Employee e)
    {
        if (e == null)
            throw new ArgumentNullException(nameof(e));
        if (value < 0)
            throw new ArgumentException("[EXCEPTION] Value cannot be negative", nameof(value));
        
        return e + value;
    }
    public static Employee operator ++(Employee e)
    {
        if (e == null)
            throw new ArgumentNullException(nameof(e));
        return new Employee(e.Name, e.Salary + 500m);
    }

    public static Employee operator -(Employee e, decimal value)
    {
        if (e == null)
            throw new ArgumentNullException(nameof(e));
        if (value < 0)
            throw new ArgumentException("[EXCEPTION] Value cannot be negative", nameof(value));
        if (e.Salary - value < 0)
            throw new ArgumentException("[EXCEPTION] Salary cannot be negative", nameof(value));
        
        return new Employee(e.Name, e.Salary - value);
    }
    public static Employee operator --(Employee e)
    {
        if (e == null) 
            throw new ArgumentNullException(nameof(e));
        decimal newSalary = e.Salary - 500m;
        if (newSalary <= 0)
            newSalary = 0;
        return new Employee(e.Name, newSalary);
    }

    public static bool operator <(Employee e1, Employee e2)
    {
        if (e1 == null)
            throw new ArgumentNullException(nameof(e1));
        if (e2 == null)
            throw new ArgumentNullException(nameof(e2));
        return e1.Salary < e2.Salary;
    }
    public static bool operator >(Employee e1, Employee e2)
    {
        if (e1 == null)
            throw new ArgumentNullException(nameof(e1));
        if (e2 == null)
            throw new ArgumentNullException(nameof(e2));
        return e1.Salary > e2.Salary;
    }

    public static bool operator ==(Employee e1, Employee e2)
    {
        if (ReferenceEquals(e1, e2))
            return true;
        if (e1 is null || e2 is null)
            return false;
        return e1.Salary == e2.Salary;
    }
    public static bool operator !=(Employee e1, Employee e2)
    {
        return !(e1 == e2);
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Employee e)
            return false;
        return Salary == e.Salary;
    }

    public override int GetHashCode()
    {
        return Salary.GetHashCode();
    }
}