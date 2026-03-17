อรณัญช์ ไกรอ่ำ 683450197-1

---

classDiagram

%% ===== Abstract Class =====
class Person {
    <<abstract>>
    - name : string
    + Display()*
}

%% ===== Student =====
class Student {
    - studentId : string
    - score : double
    + GetScore() double
    + GetGrade() string
    + Display() void
}

%% ===== Course =====
class Course {
    - courseName : string
    - courseId : string
    - students : List~Student~
    + AddStudent(student) void
    + ShowStudents() void
    + ShowMaxMinScore() void
    + ShowAverageScore() void
    + GetCourseInfo() string
}

%% ===== Relationships =====
Person <|-- Student
Course "1" --> "*" Student
