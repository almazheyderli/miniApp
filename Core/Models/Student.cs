using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Student
    {
        private static int _id;
        public int Id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(string name, string surname)
        {
            if (!Helper.CorrectName(name) || !Helper.CorrectSurname(surname))
            {
                throw new ArgumentException("duzgun ad formati deyil");
            }
            Id = ++_id;
            Name = name;
            Surname = surname;

        }
        public override string ToString()
        {
            return $"{Name} {Surname} {Id}";
        }

    }
}
