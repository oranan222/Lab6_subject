using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_subject
{
    internal class Student : Person
    {
       private string studentId;
    private double score;

    public Student(string name, string studentId, double score) : base(name)
    {
        this.studentId = studentId;
        this.score = score;
    }

    public double GetScore()
    {
        return score;
    }

    public string GetGrade()
    {
        if (score >= 80) return "A";
        else if (score >= 75) return "B+";
        else if (score >= 70) return "B";
        else if (score >= 65) return "C+";
        else if (score >= 60) return "C";
        else if (score >= 55) return "D+";
        else if (score >= 50) return "D";
        else return "F";
    }

    public override void Display()
    {
        Console.WriteLine($"Namw: {name}, ID: {studentId}, Score: {score}, Grade: {GetGrade()}");
    }
}
}
