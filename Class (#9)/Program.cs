namespace Class___9_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string fName, lName;

            students.Add(new Student("Foscar", "Grouch"));
            students.Add(new Student("Alfred", "Barkley"));
            students.Add(new Student("Steven", "Aldworth"));

            Console.WriteLine("Testing setters and getters");
            students[2].FirstName = "Steve";                //Test set property FirstName
            Console.WriteLine(students[2].FirstName);       //Test get property FirstName
            Console.WriteLine(students[2].StudentNum);   //Test get property StudentNumber
            students[1].LastName = "Hitchcock";             //Test set property LastName
            Console.WriteLine(students[1].LastName);        //Test get property FirstName
            Console.WriteLine(students[1].Email);           //Test get property get email

            Console.WriteLine();
            Console.WriteLine();

            //Displays all names in list
            Console.WriteLine("Students: ");
            foreach (Student student in students)
                Console.WriteLine(student); //ToString() implicitly called here

            Console.WriteLine();
            Console.WriteLine();

            //Adds new students
            Console.WriteLine("Adding new students");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Please enter a first name:");
                fName = Console.ReadLine();
                Console.WriteLine("Please enter a last name:");
                lName = Console.ReadLine();
                students.Add(new Student(fName, lName));
            }

            Console.WriteLine();
            Console.WriteLine();

            //Prints email addresses
            Console.WriteLine("Email addresses:");
            foreach (Student student in students)
                Console.WriteLine(student.Email);

            Console.WriteLine();
            Console.WriteLine();

            //Sorts list using CompareTo()
            Console.WriteLine("Sorted List:");
            students.Sort();

            //Prints sorted list
            foreach (Student student in students)
                Console.WriteLine(student);


            Console.WriteLine();
            Console.WriteLine("Press Enter to quit");
            Console.ReadLine();
        }
    }
}