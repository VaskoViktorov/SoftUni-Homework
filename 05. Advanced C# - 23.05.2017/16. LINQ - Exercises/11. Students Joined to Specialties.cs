using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> studentList = new List<Student>();
            List<StudentSpeciality> specialitiesList = new List<StudentSpeciality>();

            while (input != "Students:")
            {
                string[] arr = input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                input = Console.ReadLine();
                StudentSpeciality speciality = new StudentSpeciality();
                speciality.Name = arr[0] + " " + arr[1];
                speciality.Number = int.Parse(arr[2]);
                specialitiesList.Add(speciality);
            }
            input = Console.ReadLine();
            while (input != "END")
            {
                string[] arr = input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                Student student = new Student();
                student.Name = arr[1] + " " + arr[2];
                student.Number = int.Parse(arr[0]);
                studentList.Add(student);

                input = Console.ReadLine();
            }

            studentList.Join(specialitiesList, st => st.Number,
                sp => sp.Number, (st, sp) => new
                {
                    Names = st.Name,
                    FacNum = st.Number,
                    Spec = sp.Name
                }
            ).OrderBy(x => x.Names).ToList().ForEach(res => Console.WriteLine($"{res.Names} {res.FacNum} {res.Spec}"));

        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }
    public class StudentSpeciality
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }
}
