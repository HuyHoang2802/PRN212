using StudentManagerV7Encapsulation.Entities;

namespace StudentManagerV7Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //PlayWithGetSet();
            PlayWithGetSetWithoutEncapsulation();
        }
        static void PlayWithGetSet()
        {
            int yob = 2000; //biến cục bộ Local - biến khai báo trong hàm dùng cú pháp con lạc đà ko có _ như _field 

            //tui muốn lấy giá trị của yob, get đó 
            // dùng tên biến là có value
            Console.WriteLine("Get yob: " + yob);

            int age = 2024 - yob;
            Console.WriteLine("get age: " + age);

            //Set - Thay đổi điều gì đó 
            yob = 2004;
            Console.WriteLine("Get yob again : " + yob);
            //Biến = value XXX nào đó chính là set, tức là thay đổi value của 1 biên, biến đc đổi value qua dấu bằng 

          
        }
        static void PlayWithGetSetWithoutEncapsulation()
        {
            Student s1 = new Student();
            //Get ()
            Console.WriteLine("Get: Id = " + s1.Id);
            Console.WriteLine("Get: Yob = " + s1.Yob);

            //Set()
            s1.Yob = 2004; //thay đổi value 
            Console.WriteLine("Get: Id = " + s1.Id);
            Console.WriteLine("Get: Yob = " + s1.Yob);
        }
    }
}
