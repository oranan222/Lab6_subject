อรณัญช์ ไกรอ่ำ 683450197-1

---
```mermaid
classDiagram
    class Person {
        <<abstract>>
        #name: string
        +Person(name: string)
        +Display()*
    }

    class Student {
        -studentId: string
        -score: double
        +Student(name: string, studentId: string, score: double)
        +GetScore() double
        +GetGrade() string
        +Display()
    }

    class Subject {
        -subjectName: string
        -subjectId: string
        -students: List~Student~
        +Subject(subjectName: string, subjectId: string)
        +AddStudent(s: Student)
        +ShowAllStudents()
        +ShowMaxMin()
        +ShowAverage()
    }

    class Program {
        +Main()$
    }

    Person <|-- Student
    Subject o-- Student
