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

            foreach (Student student in students)
            {
                if (student.Grade > maxGradeStudent.Grade)
                {
                    maxGradeStudent = student;
                }
            }
            Console.WriteLine($"student with max grade is {maxGradeStudent.Name} with a Grade of {maxGradeStudent.Grade}");
        }
    }
}
