namespace NullableV2
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double? _gpa; //điểm tb có thể bỏ troong từ từ điền vào 

        public Student(String id, String name, int yob, double? gpa)
        {

            _id = id;
            _name = name;
            _yob = yob;
            _gpa = null;
        }
        public void ShowProfile()
        {
            Console.WriteLine($"Id {_id} || Name {_name} || Yob {_yob} | Gpa {_gpa}");
        }
    }
        
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("SE1", null, 2004, null);
            s1.ShowProfile();

            Student s2 = new Student("SE2", "Binh", 2004, 8.6);
            s2.ShowProfile();


        }
        //static void Main(string[] args)
        //{
        //    //double gpa = null;
        //    //Console.WriteLine("gpa: " + gpa);

        //    double? gpa = null;
        //    Console.WriteLine("gpa: " + gpa);

        //    Student s1 = null;


        //    //? đi kèm tên kiểu dữ liệu áp dụng cho biến object hoặc biến primitive/value-type đều được mang ý nghĩa: biến có thể chứa giá trị null - vô thường chưa xacs định giá trị 
        //    //với biến primitive value-type (lưu value thuần - dùng luôn)
        //    //Ngoài việc lưu như truiyeenf thống còn thêm việc lưu giá trị null mang ý nghĩa ko lưu gì cả
        //    //int?, long?, char?, ...
        //    //vanax lưu value như vbinhf thuòngw và thêm giá trị null
        //    //DATA TYPE lúc này gọi là nullable data type

        //    //Vơis biến object Student s; Student? s; bản chất là như nhau 

        //}
    }
}
