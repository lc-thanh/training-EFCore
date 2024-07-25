using OneToMany.Models;

namespace OneToMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var grade = new Grade();
                grade.GradeName = "Class 1";
                grade.Section = "C#/.NET";
                grade.Students = new List<Student>();

                var student = new Student();
                student.Name = "Thanh";
                student.Grade = grade;

                grade.Students.Add(student);

                context.Grades.Add(grade);
                //context.Students.Add(student);

                context.SaveChanges();
            }

            //using (var context = new SchoolContext())
            //{
            //    var grade = new Grade();
            //    grade.GradeId = 6;

            //    context.Grades.Remove(grade);

            //    context.SaveChanges();
            //}
        }
    }
}