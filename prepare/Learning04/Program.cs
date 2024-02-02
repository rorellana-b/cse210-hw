using System;

class Program
{
    static void Main(string[] args)
    {
        Assigment a1 = new Assigment("Samuel Bennett", "Multiplication");
        System.Console.WriteLine(a1.GetSummary());

        MathAssigment m1 = new MathAssigment ("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        System.Console.WriteLine(m1.GetSummary());
        System.Console.WriteLine(m1.GetHommeworkList());

        WritingAssignment w1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        System.Console.WriteLine(w1.GetSummary());
        System.Console.WriteLine(w1.GetWritingInformation());
    }
}