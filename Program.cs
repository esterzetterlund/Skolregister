namespace Skolregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fName;
            string lName;
            string role;
            int pNumber;
            string subject;
            string course;
            bool run = true;
            List<Person> people = new List<Person>();
            do
            {
                Console.WriteLine("Add to register: \n1. Add Techer: \n2. Add Student: \n3. Print register: \nExit: Input exit to exit");
                string temp = Console.ReadLine();
                switch (temp)
                {
                    case "1":
                        Console.WriteLine("Input Firstname: ");
                        fName = Console.ReadLine();
                        Console.WriteLine("Input Lastname: ");
                        lName = Console.ReadLine();
                        Console.WriteLine("Input Role: ");
                        role = Console.ReadLine();
                        Console.WriteLine("Input Personalnumber: ");
                        pNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input Subject: ");
                        subject = Console.ReadLine();


                        Teacher t1 = new Teacher(fName, lName, role, pNumber, subject);
                        people.Add(t1);
                        break;
                    case "2":
                        Console.WriteLine("Input Firstname: ");
                        fName = Console.ReadLine();
                        Console.WriteLine("Input Lastname: ");
                        lName = Console.ReadLine();
                        Console.WriteLine("Input Role: ");
                        role = Console.ReadLine();
                        Console.WriteLine("Input Personalnumber: ");
                        pNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input Course: ");
                        course = Console.ReadLine();

                        Student s1 = new Student(fName, lName, role, pNumber, course);
                        people.Add(s1);
                        break;
                    case "3":
                        foreach (var item in people)
                        {
                            item.PrintInfo();
                        }
                        break;
                    case "exit":
                        run = false;
                        break;
                }
            } while (run == true);

           



            

        }
    }
}