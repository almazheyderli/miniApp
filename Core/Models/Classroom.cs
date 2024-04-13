using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Classroom
    {

        private static int _id;
        public int Id;
        public string Name;

        ClassType ClassType;

        private Student[] _students = new Student[] { };
        public Classroom(string name, ClassType type)
        {
            if (!Helper.CorrectClassName(name))
            {
                throw new ArgumentException("Class adi duzgun formada deyil");
            }
            Id = ++_id;
            Name = name;
            ClassType = type;

        }


        public void AddStudent(Student student, ClassType type)
        {
            if (type == ClassType.Backend)
            {
                if (_students.Length >= 20)
                {
                    Console.WriteLine("Backend class is full. Cannot add more students.");
                    return;
                }
            }
            else if (type == ClassType.Frontend)
            {
                if (_students.Length >= 15)
                {
                    Console.WriteLine("Frontend class is full. Cannot add more students.");
                    return;
                }
            }

            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = student;
        }
        public Student FindId(int id)
        {
            for (int i = 0; i <= _students.Length; i++)
            {
                if (_students[i].Id == id)
                {
                    return _students[i];
                }
            }
            return null;
        }
        public void Delete(int id)
        {
            Student[] remainingStudents = new Student[0];


            for (int i = 0; i <= _students.Length; i++)
            {
                if (_students[i].Id != id)
                {
                    Array.Resize(ref remainingStudents, remainingStudents.Length + 1);
                    remainingStudents[remainingStudents.Length - 1] = _students[i];
                }
            }
            _students = remainingStudents;
        }
        public Student[] GetAllStudents()
        {
            return _students;
        }

    }
}
