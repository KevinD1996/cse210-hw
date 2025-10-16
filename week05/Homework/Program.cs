using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Fenda Bondo", "Subtraction");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Nancy Boakai", "Division", "25.5", "15/5");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Kevin Chacha", "The paragraf", "The purpose of Mormon Army");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}