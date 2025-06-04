using StudentManagerV2MultipleConstructors.Entities;

namespace StudentManagerV2MultipleConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //Console.WriteLine(x); Lỗi ngay lúc gõ do lấy rác trong RAM để in 

            Student s1 = new("SE1", "AN", 2004, 8.6);
            Student s2 = new("SE2", "Binh", 2004, 8.7);
            var s3 = new Student("SE3", "Cuong");
            Console.WriteLine("s3 detail with default values inside: ");
            Console.WriteLine(s3);

            s3.SetYob(2005);
            s3.SetGpa(9.99);
            Console.WriteLine("s3 after setting: ");
            Console.WriteLine(s3);

            Student s4 = new Student("SE4", "Dung", 2004, 9.0);
            
            s4.showProfile();


            new Student("SE4", "Dung", 2004, 9.0).showProfile();

            s4 = null; // Vùng new trước đó bị trỏ bởi s4 đã mồ côi
        }
    }
}
