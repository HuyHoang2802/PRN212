using StudentManagerV1.Entities;

namespace StudentManagerV1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //đúc object, clone cái form, khuôn, class, template, fill - nhiều việc cùng lúc: gọi new gọi phễu constructor kèm value vật liệu mực bít đổ vào 
            //giống đưa hệ số cho phương trinh để có 1 phương trình cụ thể 
            Student       s1 = new             Student("SE1", "An", 2004, 8.89);
            //data type   biến object           object tốn ram 
            //                                  public hoạcw private gì đó ở object 
            //                           chấm để giao tiếp 
            Console.WriteLine("Show profile......");
            s1.ShowProfile();
            Student s2 = new Student("SE2", "Binh", 2004, 8.8);
            Console.WriteLine("S2 show profile");
            Console.WriteLine(s2.ToString());
            Console.WriteLine(s2); //gọi thầm tên em ToString()
                                   //và nếu ko có ToString() thì JAVA sẽ băm(hash) vừng new thành dãy hex
                                   //C# sẽ báo vùng new này là vùng new Student
                                   //Muốn ko bị khó hiêủ kết quả, hay muốn in toàn bộ info bên trong object đã đổ vào, in toàn bộ info của vùng new bạn nên chủ động tạo hàm ToString() à khi gọi hàm này ko cần .ToString(), C# và JAVA tự gọi dùm 
                                   //Khi dùng biến object ở các lệnh kiểu chuỗi cw(biến-object)
                                   //string msg = s2; 
            Student s3 = new ("SE3", "Cuong", 2004, 8.7);
            //ko cần new Student - cú pháp mới do đã có ở vế trái rồi 
            Console.WriteLine("s3 show profile ..");
            s3.ShowProfile();

            var s4 = new Student ("SE4", "Dung", 2004, 8.7); //TyPE INFERENT - SUY luận kiểu - có manh mối cho mình suy ra vùng ram 
            Console.WriteLine("s4 show profile ..");
            s4.ShowProfile();

            var s5 = new Student(name: "EM", yob: 2004, gpa: 9.0, id: "SE5");
            //name argument: dùng tên tham số để đảo thứ tự đầu vào theo yêu thích 
            Console.WriteLine("s5 show profile ..");
            s5.ShowProfile();

            Student s6 = s5;
            Console.WriteLine("s6 show profile ..");
            s6.ShowProfile();


            //Gọi hàm nhận vào 1 object, biến object 
            Console.WriteLine("Check s5 before calling method: ");//9.0
            Console.WriteLine(s5) ;
            PassAStudent(s5);
            Console.WriteLine("Checked s5 after calling method: ");//9.99
            Console.WriteLine(s5);

        }
        //thửu nghiêm vêf truyền object - bản chất là truyền địa chỉ - tham chiếu - mà ko cần ref và out 
        static void PassAStudent(Student x) // x là biến object 
                                            // nó sẽ lưu tòaj đọ 1 vùng new 
        {
            x.SetGpa(9.99); //x và  biến đưa vào cùng trỏ 1 vùng new 
                            //x sửa gì vùng new qua x.Set ()
                            //thì vùng new bên ngoài của biến đưa vào bị sửa luôn 
                            //nên truyền biến object qua  hàm bản chất là truyền tham chiếu rồi mà ko cần ref out 
                            //Trong hàm mà sửa, ngoài hàm hốt đủ 
                            
        }
    }
}
