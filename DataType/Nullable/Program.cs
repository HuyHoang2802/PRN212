using System.ComponentModel;
using System.Security.Cryptography;

namespace Nullable
{
    //trong khuôn viên NAMESPACE bạn có thể tạo nhiều 
    //Class
    //Interface 
    //Delegate( bản chất là 1 class, class rất đặc biệt hơn interface)
    internal class Student
    {
        //Quy tác đat tên của field: danh từ + con lạc đà + từ đầu tiên chữ thường kèm SHIFT gạch dấu cách underscore 
        private string _id;     //biến khai báo trong class thì được gọi là field, attribute,
        private string _name;   // Instance variable (nếu ko cso chữ static đi kèm)
        private int _yob;       // class level variable (nếu có chữ static đi kèm) 
        public double _gpa;    // Hàm gọi là method là đoạn code được đặt tên xử lí các biến 
                                //Hàm + field thì được gọi chung là member of a class 
                                //thành viên của class
                                //Biến khai báo ở tham số hàm (có thể xài thêm in out ref ) và khai báo trong hàm => gọi chung là local variable - biến cục bộ  
        //constrictor + method xử lí cấc biến /field  
        public Student(string id, string name, int yob, double gpa)
        {           //biến cucj bộ theo cú pháp con lạc đà 
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa; // dư thừa, ko cso nhầm lẫn in4 bên ngoài và cái tui cá nhân bên trong 
        }
        //show profile 
        public void ShowProfile()
        {
            Console.WriteLine($"{_id} | {_name} | {_yob} | {_gpa}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateAStudentObject();
            PlayWithNullV6();
        }
        //Nullable - em có khả năng mang giá trị null 
        //Với biến object, mọi biến object 1 cách tự nhiên đã được quyền lưu null
        //với ý nghĩa, biến chưa đề cập đến 1 object cụ hể nào đó, từ từ sẽ có object cụ thể 
        //biến object = null là chuyện bình thường sau đó có thể trỏ vùng new() ... nào đó 

        //cuộc chơi phức tạp 1 chút khi ta chơi với CSDL 
        //
        static void PlayWithNullV6()
        {
            //Học thêm toán tủ 3 ngôi ? mà bên C, java cũng có 
            //Phía sau chính là if else luôn 

            //dưaj vào năm sinh thì in ra msg: GEN Z, TOO OLD ...

            int yob = 2004;
            string msg;
            if ( yob > 2000)
                msg = "Gen z";
            else
                msg = "Too old";

            msg = yob > 2000 ? "GENZ" : "To old";
            Console.WriteLine(msg); 
        }



        static void PlayWithNullV5()
        {
            Student s1 = null;
            Student s2 = s1 ?? new Student("SE1", "An", 2004, 8.6);
            s2.ShowProfile();



            s1 = new Student("SE9", "CHinh", 2009, 9.9);
            Student s3 = s1 ?? new Student("SE3", "BA", 2003, 9.3);
        }

        static void PlayWithNullV4()
        {
            //Gán giá trị default nào đó cho biến object 
            Student s1 = null;
            Student s2 = s1;
            s2?.ShowProfile(); //if (s2 != null) s2.ShowProfile();

            s2 = s1 ?? new Student("SE2", "Binh", 2004, 9.2);
            Console.WriteLine("s2 first :");
            s2.ShowProfile();

            if (s1 != null)
                s2 = s1; //check 1 biến object có null ko, ko null, gán biến 
            else
                s2 = new Student("SE3", "Cuong", 2004, 9.2);
            //đảm bảo biến s2 luôn trỏ object tử tế, ko trỏ null
            Console.WriteLine("s2 later: ");
            s2.ShowProfile();
        }


        static void PlayWithNullV3()
        {
            //Gán các biến object cho nhau
            int a = 10;
            int b = a; //vùng ram b mang giá trị y chang a, nhhunwg là 2 vùng ram riêng biệt, bên này đổi ko ảnh hưởng 
            b = 2004;
            Console.WriteLine("a =" + a);
            Console.WriteLine("b =" + b);

            Student s3 = new Student("SE1", "An", 2004, 8.8);
            Student s4 = s3; //2 biến object trỏ chung 1 vùng ram đã new với full info
            Console.WriteLine("check if s4 points to the same s3 points to ...");
            s4.ShowProfile();
            //chứng minh trỏ chung tòa độ 
            s4._gpa = 999;
            s3.ShowProfile();

            //nếu truyền 1 biến object qua tham số hàm F(student S)
            //Khi gọi F(s3) F(s4) thì s, s3, s4 trỏ cùng 1 chỗ new 
            // void F(Student s)
            // {
            //   s.cái gì đó thì sẽ thay đổi s3, s4 ở ngoài. Mặc nhiên biến object là truyền tham chiếu mà ko cần REF, OUT 
            //}
            Console.WriteLine( "Check profile after assigning null to s3");
            // s3 và s4 đang cùng trỏ vùng new 999 
            s3 = null;
            s3?.ShowProfile();
            s4.ShowProfile();
        }


        static void PlayWithNullV2()
        {
            Student s2 = null;
           // s2.ShowProfile();
           if (s2 == null ) 
                Console.WriteLine("S2 points to null. Please creating an object before using it");
           else
                s2.ShowProfile();

            if (s2 is null)
                Console.WriteLine("S2 points to null. Please creating an object before using it");
            else
                s2.ShowProfile();
            //kĩ thuât jmoi
            Console.WriteLine("the new way to check null a variable");
            s2?.ShowProfile();
            // câu lệnh ? đi kèm tên biến  object giúp kiểm tra xem biến đó có null hay ko,  nếu ko null tức là biến đã trở vbuingf new thì cứ tự nhiên gọ hàm ko sợ bị báo lỗi run time reference. thực ra là lệnh gộp của if else ở trên !!!
            //? đi kèm lời gọi gàm cyar object gộp kuêmr tra null trước khi gọi hàm 
            //? được gọi là: null conditional operation - toán tử kiểm tra null của object 
            //thay vì dùng IS NULL, == NULL ta có thể dùng ! khi gọi 1 hàm của object 

        }

        static void PlayWithNullV1()
        {
            Student s1;
            // s1.ShowProfile();//BIẾN MỚI KHAI BÁO THÌ CHỈ LÀ XIN RAM CHỨ CHƯA CÓ VALUE, NÓI THẲNG LÀ VALUE RÁC CỦA APP TRƯỚC ĐÓ ĐỂ LẠI
            //JAVA VÀ C#: KHAI BÁO BIẾN XONG PHẢI GÁN VALUE NÀO ĐÓ SAU ĐÓ MỚI ĐC DÙNG BIẾN 
            //C: THOẢI MÁI, XIN BIẾN XONG DUNG LUÔN KO GÁN GIÁ TRỊ, SAI RÁNG CHỊU
            Student s2 = null;// có xin ram và gán luôn giá trị cho vùng ram, vùng ram đó đc dọn dẹp r, lúc này biến lưu toa đọ của tầng trêtj - trỏ tới tầng 0 toàn số 0
            s2.ShowProfile(); //vì đã có value, ko bị cảnh báo viết code là xài rấc!!!!
                              //Lỗi lúc runtime: S2 = NULL nghĩa là biến s2 trỏ đấy ram, byte null 
                              //Ở đây ko có codde của hàm ShowProFile(), sẽ bị báo lỗi tham chiếu lộn 
                              //chỗ ko có code 
                              //khái niệm null đưa ra để giải quyết nhìu chuyện, chuyenej phổ biến nhất là dùng cho hàm SEARCH 1 Object, 1 Student nếu tìm thấy thì trả về Object/SV nào đó
                              //Nếu ko tìm thấy thì trả về null, để nói ràng ko có object thỏa
                              //trỏ null là trỏ vùng ko thấy, ko có, ráng tin thông tin báo lỗi 
        }
        static void CreateAStudentObject()
        {
            Student       s3 =             new Student("SE1", "AN", 2004, 8.6);
          //data type     biến object      value/object
            s3.ShowProfile();
        }

    }
}
