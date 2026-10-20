namespace csharp_homework8;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("--- TASK 1 ---");
        // Employee e1 = new Employee("Pusheen", 15000m);
        // Employee e2 = new Employee("Buvette", 17000m);
        // Employee e3 = new Employee("Jw Pei", 23000m);
        //
        // e1.Print();
        // e2.Print();
        // e3.Print();
        //
        // Console.WriteLine("--- (+ / -) ---");
        // Console.Write($"e1 ({e1.Salary}) + 2000 = ");
        // e1 = e1 + 2000m;
        // Console.WriteLine(e1.Salary);
        //
        // Console.Write($"2000 + e2 ({e2.Salary}) = ");
        // e2 = 2000m + e2;
        // Console.WriteLine(e2.Salary);
        //
        // Console.Write($"e3 ({e3.Salary}) - 5000 = ");
        // e3 = e3 - 5000m;
        // Console.WriteLine(e3.Salary);
        // Console.WriteLine();
        //
        // Console.WriteLine("--- (++ / --) ---");
        // Console.Write($"e1 ({e1.Salary}) ++ = ");
        // e1++;
        // Console.WriteLine(e1.Salary);
        //
        // Console.Write($"e2 ({e2.Salary}) -- = ");
        // e2--;
        // Console.WriteLine(e2.Salary);
        // Console.WriteLine();
        //
        // Console.WriteLine($"--- COMPARING ---");
        // Console.WriteLine($"e1 == e2: {e1 == e2}");
        // Console.WriteLine($"e1 != e2: {e1 != e2}");
        // Console.WriteLine($"e1 > e2: {e1 > e2}");
        // Console.WriteLine($"e1 < e2: {e1 < e2}");
        // Console.WriteLine($"e1.Equals(e3): {e1.Equals(e3)}");
        //
        Console.WriteLine("--- TASK 2 ---");
        Matrix m1 = new Matrix(new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        });
        Matrix m2 = new Matrix(new int[,]
        {
            { 1, 2, 3 },
            { 5, 7, 9 },
            { 4, 8, 1 }
        });
        
        Console.WriteLine($"Addition:");
        Console.WriteLine(m1 + m2);
        
        Console.WriteLine($"Subtraction:");
        Console.WriteLine(m1 - m2);
        
        Console.WriteLine($"Multiplication:");
        Console.WriteLine(m1 * m2);
        
        Console.WriteLine($"Multiplication by number:");
        Console.WriteLine(m1 * 3);
        
        Console.WriteLine($"m1 == m2: {m1 == m2}");
        Console.WriteLine($"m1 != m2:  {m1 != m2}");
        Console.WriteLine($"m1.Equals(m2): {m1.Equals(m2)}");
        Console.WriteLine($"Indexer: m1[0, 0] = {m1[0, 0]}");

        m1[0, 0] = 10;
        Console.WriteLine($"New m1[0, 0] = {m1[0, 0]}");
    }
}