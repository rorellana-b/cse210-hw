using System;
using System.Collections.Generic;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1._firstname = "Ronal";
        p1._lastname = "Orellana";
        p1._age = 30;

        Person p2 = new Person();
        p2._firstname = "Mary";
        p2._lastname = "Smith";
        p2._age = 29;

        List<Person> people =new List<Person>();
        people.Add(p1);
        people.Add(p2);
        
        foreach (Person p in people)
        {
            System.Console.WriteLine(p._firstname);
        }

        SaveToFile(people);

    }

    public static void SaveToFile(List<Person> people)
    {
        string filename = "people.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Person p in people)
            {
                outputFile.WriteLine(p._firstname);
            }
        }
    }

}