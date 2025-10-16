using System;
class Program
{
    static void Main(string[] args)
    {
        // Create Professors
        Professor prof1 = new Professor("Alice", "Java", 9000);
        Professor prof2 = new Professor("Bob", "Math", 8000);

        // Create Students
        Student student1 = new Student("Lisa", "Java", 90);
        Student student2 = new Student("Tom", "Math", 80);

        // Print Professor Details
        Console.WriteLine("Professor Details:");
        Console.WriteLine($"Name: {prof1.GetName()}, Class: {prof1.GetClassTeach()}, Salary: {prof1.GetSalary()}");
        Console.WriteLine($"Name: {prof2.GetName()}, Class: {prof2.GetClassTeach()}, Salary: {prof2.GetSalary()}");

        // Print Student Details
        Console.WriteLine("\nStudent Details:");
        Console.WriteLine($"Name: {student1.GetName()}, Class: {student1.GetClassEnroll()}, Grade: {student1.GetGrade()}");
        Console.WriteLine($"Name: {student2.GetName()}, Class: {student2.GetClassEnroll()}, Grade: {student2.GetGrade()}");

        // Salary Difference
        double salaryDiff = Math.Abs(prof1.GetSalary() - prof2.GetSalary());
        Console.WriteLine($"\nSalary Difference between Professors: {salaryDiff}");

        // Total Grade
        double totalGrade = student1.GetGrade() + student2.GetGrade();
        Console.WriteLine($"Total Grade of Lisa and Tom: {totalGrade}");
    }

    class Professor
    {
        private string profName;
        private string classTeach;
        private double salary;

        public Professor(string name, string classTeach, double salary)
        {
            this.profName = name;
            this.classTeach = classTeach;
            this.salary = salary;
        }

        public void SetSalary(double salary_amount)
        {
            salary = salary_amount;
        }

        public double GetSalary()
        {
            return salary;
        }

        public string GetName()
        {
            return profName;
        }

        public string GetClassTeach()
        {
            return classTeach;
        }
    }

    class Student
    {
        private string studentName;
        private string classEnroll;
        private double studentGrade;

        public Student(string name, string classEnroll, double grade)
        {
            this.studentName = name;
            this.classEnroll = classEnroll;
            this.studentGrade = grade;
        }

        public void SetGrade(double newGrade)
        {
            studentGrade = newGrade;
        }

        public double GetGrade()
        {
            return studentGrade;
        }

        public string GetName()
        {
            return studentName;
        }

        public string GetClassEnroll()
        {
            return classEnroll;
        }
    }

}


