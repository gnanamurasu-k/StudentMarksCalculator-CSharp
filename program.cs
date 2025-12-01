using System;

class StudentMarksCalculator
{
    static void Main()
    {
        Console.WriteLine("=== Student Marks Calculator ===\n");

        // Ask how many subjects
        Console.Write("Enter the number of subjects: ");
        int subjectCount = int.Parse(Console.ReadLine());

        int[] marks = new int[subjectCount];
        int total = 0;

        // Get marks for each subject
        for (int i = 0; i < subjectCount; i++)
        {
            Console.Write($"Enter marks for subject {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
            total += marks[i];
        }

        // Calculate average
        double average = (double)total / subjectCount;

        // Decide grade
        string grade;
        if (average >= 90)
            grade = "A+";
        else if (average >= 80)
            grade = "A";
        else if (average >= 70)
            grade = "B";
        else if (average >= 60)
            grade = "C";
        else
            grade = "F";

        // Show results
        Console.WriteLine("\n--- Result ---");
        Console.WriteLine("Total Marks   : " + total);
        Console.WriteLine("Average Marks : " + average);
        Console.WriteLine("Grade         : " + grade);

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
