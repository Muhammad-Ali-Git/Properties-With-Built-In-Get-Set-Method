// See https://aka.ms/new-console-template for more information
using System;

public class Student
{
    private int _id;
    private string _name;
    private int _passMark = 35;

    public int PassMark
    {
        get
        {
            return this._passMark;
        }
    }

    public int ID
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("Student ID cannot be negative.");
            }
            this._id = value;
        }
        get
        {
            return this._id;
        }
    }

    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty (value))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._name = value;
        }
        get
        {
            return this._name;
        }
    }

    public int SetPassMarks
    {
        set
        {
            if (value < 35)
            {
                throw new Exception ("You are not passed.");
            }
            this._passMark = value;
        }
        get
        {
            return this._passMark;
        }
    }
}

public class Program
{
    static void Main()
    {
        Console.WriteLine("This code prints Result Card of a Student.");
        Console.WriteLine("Enter you ID: ");
        int Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your name: ");
        string Name = Console.ReadLine();

        Console.WriteLine("Enter your marks: ");
        int Marks = int.Parse(Console.ReadLine());

        Student S = new Student();
        S.ID = Id;
        S.Name = Name;
        S.SetPassMarks = Marks;

        Console.WriteLine("Result Card: \n");

        Console.WriteLine("Passing Marks: {0}", S.PassMark);

        Console.WriteLine("\n Student ID: {0} \n Student Name: {1} \n Student Marks: {2} \n Status: Passed", S.ID, S.Name, S.ID);
    }
}
