namespace Students_HW_week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //getting students' names
            Console.WriteLine("please enter first student's First Name: ");
            string FirstName1 = Console.ReadLine();
            Console.WriteLine("please enter first student's Last Name: ");
            string LastName1 = Console.ReadLine();


            Console.WriteLine("please enter second student's First Name: ");
            string FirstName2 = Console.ReadLine();
            Console.WriteLine("please enter second student's Last Name: ");
            string LastName2 = Console.ReadLine();


            Console.WriteLine("please enter third student's First Name: ");
            string FirstName3 = Console.ReadLine();
            Console.WriteLine("please enter third student's Last Name: ");
            string LastName3 = Console.ReadLine();


            //creating objects
            Student[] Students = new Student[3] {new Student(FirstName1, LastName1), new Student(FirstName2, LastName2), new Student(FirstName3, LastName3)};

            foreach (Student student in Students)
            {
                Console.WriteLine();
                Console.WriteLine($"My name is {student.FirstName} {student.LastName} and my average is {student.GradeAverage()}");
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }



}
