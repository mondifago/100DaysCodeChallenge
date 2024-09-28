namespace _100DaysCodeChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
            new Student { Name = "John", Grade = 85 },
            new Student { Name = "Sarah", Grade = 92 },
            new Student { Name = "Tom", Grade = 78 },
            new Student { Name = "Anna", Grade = 88 },
            new Student { Name = "Robert", Grade = 94 }
            };

            var maxGradeStudent = students[0];
            var minGradeStudent = students[0];

            foreach (Student student in students)
            {
                if (student.Grade > maxGradeStudent.Grade)
                {
                    maxGradeStudent = student;
                }
            }
            Console.WriteLine($"student with max grade is {maxGradeStudent.Name} with a Grade of {maxGradeStudent.Grade}");

            foreach (Student student in students)
            {
                if (student.Grade < minGradeStudent.Grade)
                {
                    minGradeStudent = student;
                }
            }
            Console.WriteLine($"student with max grade is {minGradeStudent.Name} with a Grade of {minGradeStudent.Grade}");

            double studentsum = 0.0;
            double studentAve = 0.0;

            foreach (Student student in students)
            {
                studentsum = studentsum + student.Grade;
                studentAve = studentsum / students.Count;
            }

            Console.WriteLine($"Average Grade for all students is {studentAve}");

        }
    }
}
