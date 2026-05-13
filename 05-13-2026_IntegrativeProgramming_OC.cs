using System;

public class StudentGrade {
    private double average_grade;
    public Double computeAverage(double g1, double g2) {
        average_grade = (g1 + g2) / 2;
        return average_grade;
    }

    public void averageChecker (double average) {
        if (average >= 59) {
            Console.WriteLine("The student has passed.");
        } else {
            Console.WriteLine("The student has failed.");
        }
    }
}

public class Program {
    public static void Main(string[] args) 
    {
        StudentGrade student = new StudentGrade();
        Console.Write("Enter the first grade: ");
        double g1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second grade: ");
        double g2 = Convert.ToDouble(Console.ReadLine());
        double average = student.computeAverage(g1, g2);

        Console.WriteLine("The student's average grade is: " + average);
        student.averageChecker(average);
    }
}