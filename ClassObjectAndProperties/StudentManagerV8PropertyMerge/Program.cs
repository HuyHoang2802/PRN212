using StudentManagerV8PropertyMerge.Entities;

namespace StudentManagerV8PropertyMerge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();// new default bên trong 
            s1.Id = "SE1"; //Set từng câu 
            s1.Name = "An"; //Cách cũ giống JAVA 
            s1.Yob = 2004;
            s1.Gpa = 8.6;
            //Tự nhiên như nhìn  cccd 
            Console.WriteLine("S1 detail " + s1.ToString());
            Console.WriteLine("S1 detail " + s1);
            //Cách mới đẻ new object, ko có trong java
            //Vừa new vừa gán value, vừa new vừa SET() luôn  trên 1 dòng 
            Student s2 = new Student() { Id = "SE2", Name = "Binh", Gpa = 8.7, Yob = 2005 };//thoải mái đauw properties theo bất kì thứ tự - ko nhầm với name argument 
            Console.WriteLine("S2 detail: " + s2);
            Student s3 = new Student()
            {
                Id = "SE3",
                Name = "Cuong",
                Gpa = 8.7, 
                Yob = 2005
            };
            //Stype viết chuẩn - new object kèm SET() value cho properties 
            //Kỹ thuaattj New qua SET() properties đc gọi là 
            //Object initializer - tạo object và khởi động luôn các đặc tính 
            Console.WriteLine("S3 detail: " + s3);
        }
    }
}
