namespace PROG7312_ICE_1_ST10070895
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(12345, "Vin", "Cent", "Computer Science", 50);

            student[1] = "kyle";
            Console.WriteLine(student[0]);
            Console.WriteLine(student[1]);
            Console.WriteLine(student[2]);
            Console.WriteLine(student[3]);
            Console.WriteLine(student[4]);

            student["mark"] = 50;
            Console.WriteLine("Student ID: " + student["studentid"]);
            Console.WriteLine("First Name: " + student["firstname"]);
            Console.WriteLine("Last Name: " + student["lastname"]);
            Console.WriteLine("Subject: " + student["subject"]);
            Console.WriteLine("Mark: " + student["mark"]);
        }
    }
}