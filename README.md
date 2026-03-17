อรณัญช์ ไกรอ่ำ 683450197-1

---

# Grade Calculation System (C# OOP)

## Class Diagram

Person (Abstract)
- name
+ Display()

Student : Person
- studentId
- score
+ GetScore()
+ GetGrade()
+ Display()

Subject
- subjectName
- subjectId
- List<Student>
+ AddStudent()
+ ShowAllStudents()
+ ShowMaxMin()
+ ShowAverage()

Program
- Main()
