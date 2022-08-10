using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ravish_List
{
    class Program
    {
        public class Student
        {
            public int? Id { get; set; }
            public string name { get; set; }
        }


        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>()
                {
                    new Student{ Id = 1, name = "Ashish" },
                    new Student{ Id = 2, name = "Ravish" },
                    new Student{ Id = 3, name = "Avinash" },
                    new Student{ Id = 4, name = "Abhishek" }
                };

            return students;
        }

        static void Main(string[] args)
        {

            List<Student> result = Program.GetStudents();

            foreach (var res in result)
            {
                Console.WriteLine("Id:- {0} Name:- {1}", res.Id, res.name);
            }

            Console.ReadKey();


            List<int> num = new List<int>();
            num.Add(2);
            num.Add(5);
            num.Add(7);

            //int result = num.FirstOrDefault(a => a == 2);
            //Console.WriteLine("Result = {0}", result);

            Console.Write("Print the nunbers:- ");

            foreach (var number in num)
            {
                Console.Write("{0} ", number);
            }

            Console.ReadKey();
        }
    }
}
