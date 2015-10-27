using System.IO;
using System.Linq;

namespace Students_Directory
{
    public class ClassStudent
    {
        public static void Main()
        {
            //  Problem 1.	Class Student - creating an instance of the StudentsDirectory class, so that we can use its List<Student> with sample students
            StudentsDirectory database = new StudentsDirectory();

            // printing
            database.Students.PrintStudentsInfo();
        }
    }
}