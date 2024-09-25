using System;

public class School
{

    public string Name { get; set; }
    public string Principal { get; set; }
    public int StudentCount { get; set; }


    public School(string name, string principal, int studentCount)
    {
        Name = name;
        Principal = principal;
        StudentCount = studentCount;
    }

    // Method to display basic school information
    public void DisplaySchoolInfo()
    {
        Console.WriteLine($"School Name: {Name}");
        Console.WriteLine($"Principal: {Principal}");
        Console.WriteLine($"Student Count: {StudentCount}");
    }
}

public class MiddleSchool : School
{
    // Additional properties for MiddleSchool
    public int LowestGrade { get; set; }
    public int HighestGrade { get; set; }

    // Constructor for MiddleSchool
    public MiddleSchool(string name, string principal, int studentCount, int lowestGrade, int highestGrade)
        : base(name, principal, studentCount)
    {
        LowestGrade = lowestGrade;
        HighestGrade = highestGrade;
    }

    // Method to display MiddleSchool-specific information
    public void DisplayMiddleSchoolInfo()
    {
        DisplaySchoolInfo();
        Console.WriteLine($"Lowest Grade: {LowestGrade}");
        Console.WriteLine($"Highest Grade: {HighestGrade}");
    }
}

public class HighSchool : School
{
    // Additional property for HighSchool
    public string SportsFieldName { get; set; }

    // Constructor for HighSchool
    public HighSchool(string name, string principal, int studentCount, string sportsFieldName)
        : base(name, principal, studentCount)
    {
        SportsFieldName = sportsFieldName;
    }

    // Method to display HighSchool-specific information
    public void DisplayHighSchoolInfo()
    {
        DisplaySchoolInfo();
        Console.WriteLine($"Sports Field Name: {SportsFieldName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of MiddleSchool
        MiddleSchool middleSchool = new MiddleSchool("USF", "Mr. Smith", 500, 6, 8);
        Console.WriteLine("Middle School Information:");
        middleSchool.DisplayMiddleSchoolInfo();
        Console.WriteLine();

        // Create an instance of HighSchool
        HighSchool highSchool = new HighSchool("NYC", "Mrs. Jon", 800, "NYC Sports Complex");
        Console.WriteLine("High School Information:");
        highSchool.DisplayHighSchoolInfo();
    }
}