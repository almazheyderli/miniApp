using Core.Models;

namespace BeynimiYandiranApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Classroom classroom = null;
            string choice;

            do
            {
                Console.WriteLine("1.Classroom yarat");
                Console.WriteLine("2.Student yarat");
                Console.WriteLine("3.Butun telebeleri ekrana cixart");
                Console.WriteLine("4.Secilmis sinifdeki telebleri ekrana cixart");
                Console.WriteLine("5.Telebe sil");
                Console.WriteLine("0.Cixis");
                Console.WriteLine("seciminizi daxil edin");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateClassroom();
                        break;
                    case "2":
                        if (classroom != null)
                        {
                            CreateStudent(classroom);
                        }
                        else
                        {
                            Console.WriteLine("classroom yaranmiyib");
                        }
                        break;


                }

            } while (choice != "0");
        }

        static void CreateClassroom()
        {
            try
            {
                Console.WriteLine("sinif adi daxil et");
                string className = Console.ReadLine();

                Console.WriteLine("class tipi daxil et (1: Backend, 2: Frontend):");
                if (!Enum.TryParse(Console.ReadLine(), out ClassType type))
                {
                    Console.WriteLine("type duzgun formatda deyil");

                }

                Classroom classroom = new Classroom(className, type);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        static void CreateStudent(Classroom classroom)
        {
            try
            {
                Console.WriteLine("Enter student name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter student surname:");
                string surname = Console.ReadLine();
                Console.WriteLine("tipi daxil et");
                if (!Enum.TryParse(Console.ReadLine(), out ClassType type))
                {
                    Console.WriteLine("type duzgun formatda deyil");

                }



                Student student = new Student(name, surname);
                classroom.AddStudent(student, type);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    }

