using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_subject
{
    internal class Subject
    {
        private string subjectName;
        private string subjectId;
        private List<Student> students = new List<Student>();

        public Subject(string subjectName, string subjectId)
        {
            this.subjectName = subjectName;
            this.subjectId = subjectId;
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public void ShowAllStudents()
        {
            Console.WriteLine($"\nวิชา: {subjectName} ({subjectId})");
            foreach (var s in students)
            {
                s.Display();
            }
        }

        public void ShowMaxMin()
        {
            if (students.Count == 0) return;

            double max = students.Max(s => s.GetScore());
            double min = students.Min(s => s.GetScore());

            Console.WriteLine($"คะแนนสูงสุด: {max}");
            Console.WriteLine($"คะแนนต่ำสุด: {min}");
        }

        public void ShowAverage()
        {
            if (students.Count == 0) return;

            double avg = students.Average(s => s.GetScore());
            Console.WriteLine($"คะแนนเฉลี่ย: {avg:F2}");
        }
    }
}