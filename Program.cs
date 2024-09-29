using _100DaysCodeChallenge.Day_2;
using _100DaysCodeChallenge.Day_3;

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

            // Sort the list by Grade in descending order
            students.Sort((s1, s2) => s2.Grade.CompareTo(s1.Grade));

            Console.WriteLine("Students sorted by grade (highest to lowest):");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}: {student.Grade}");
            }

            // If you need the highest grade student, it's now the first in the list
            var highestGradeStudent = students[0];
            Console.WriteLine($"\nStudent with highest grade: {highestGradeStudent.Name}, Grade: {highestGradeStudent.Grade}");

            Applicant a1 = new Applicant { Name = "john", Age = 50, MonthlyIncome = 5000, YearsEmployed = 5 };
            Applicant a2 = new Applicant { Name = "sarah", Age = 35, MonthlyIncome = 1000, YearsEmployed = 6 };
            Applicant a3 = new Applicant { Name = "joe", Age = 15, MonthlyIncome = 4000, YearsEmployed = 4 };
            Applicant a4 = new Applicant { Name = "Ada", Age = 35, MonthlyIncome = 10000, YearsEmployed = 3 };
            Applicant a5 = new Applicant { Name = "paul", Age = 20, MonthlyIncome = 3000, YearsEmployed = 2 };
            Applicant a6 = new Applicant { Name = "obi", Age = 15, MonthlyIncome = 2000, YearsEmployed = 7 };

            LoanEligibilityChecker checker = new LoanEligibilityChecker();

            Console.WriteLine($"{a1.Name} is eligible: {checker.IsEligibleForLoan(a1)}");
            Console.WriteLine($"{a2.Name} is eligible: {checker.IsEligibleForLoan(a2)}");
            Console.WriteLine($"{a3.Name} is eligible: {checker.IsEligibleForLoan(a3)}");
            Console.WriteLine($"{a4.Name} is eligible: {checker.IsEligibleForLoan(a4)}");
            Console.WriteLine($"{a5.Name} is eligible: {checker.IsEligibleForLoan(a5)}");
            Console.WriteLine($"{a6.Name} is eligible: {checker.IsEligibleForLoan(a6)}");

            List<Product> inventory = new List<Product>
            {
            };
        }
    }
}
