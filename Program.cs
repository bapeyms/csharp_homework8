namespace csharp_homework8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- TASK 1 ---");
        Employee e1 = new Employee("Pusheen", 15000m);
        Employee e2 = new Employee("Buvette", 17000m);
        Employee e3 = new Employee("Jw Pei", 23000m);
        
        e1.Print();
        e2.Print();
        e3.Print();
        
        Console.WriteLine("--- (+ / -) ---");
        Console.Write($"e1 ({e1.Salary}) + 2000 = ");
        e1 = e1 + 2000m;
        Console.WriteLine(e1.Salary);
        
        Console.Write($"2000 + e2 ({e2.Salary}) = ");
        e2 = 2000m + e2;
        Console.WriteLine(e2.Salary);
        
        Console.Write($"e3 ({e3.Salary}) - 5000 = ");
        e3 = e3 - 5000m;
        Console.WriteLine(e3.Salary);
        Console.WriteLine();
        
        Console.WriteLine("--- (++ / --) ---");
        Console.Write($"e1 ({e1.Salary}) ++ = ");
        e1++;
        Console.WriteLine(e1.Salary);
        
        Console.Write($"e2 ({e2.Salary}) -- = ");
        e2--;
        Console.WriteLine(e2.Salary);
        Console.WriteLine();
        
        Console.WriteLine($"--- COMPARING ---");
        Console.WriteLine($"e1 == e2: {e1 == e2}");
        Console.WriteLine($"e1 != e2: {e1 != e2}");
        Console.WriteLine($"e1 > e2: {e1 > e2}");
        Console.WriteLine($"e1 < e2: {e1 < e2}");
        Console.WriteLine($"e1.Equals(e3): {e1.Equals(e3)}");
    }
}