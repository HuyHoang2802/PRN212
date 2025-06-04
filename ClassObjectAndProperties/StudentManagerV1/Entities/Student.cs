using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV1.Entities
{
    public class Student
    {
        private String _id; //đặc điểm field, state, biến db nằm ngoài hàm nhưng trong class của 1 object theo quy tắc: Con lạc đà và _từ đầu tiên
        private String _name; 
        private int _yob;
        private double _gpa;
        //lấy cây bút điền in4 vào form khi mình new, clone, xin 1 cái form để lưu info, khi mình cần lưu ìnfo của 1 sv mới bất kì 
        //nói theo cái khuôn đúc, thì nó chính là cái phễu hứng vật liệu đỏo vào rtong khuôn 
        //hàm CONSTRUCTOR
        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }
        //Lập trình class/ôop chính là lập trình các xử lí trên các biến 1 cách chung chung nhất, lát hồi đôr info vào sẽ có giá trị cụ thể 
        //y chang như giải phương trình bậc 2 
        // Mai mốt đưa info cụ thể vào thì có info cụ thể trả về sau xử lí 
        // đưa a b c vào thì có x1 x2 
        //đưa id, name, yob, gpa có cái gì đó trả về cụ thể 

        //Các hàm xử lí info ra vô object, y chang mình giao tiếp bên ngoài 

        //Hàm hỏi - hỏi nhau câu chuyện - GET()/GETTER()
        public string GetName()
        {
            return _name;
        }
        public int GetYob()
        {
            return _yob;
        }
        public double GetGgpa() => _gpa;//expression body/bodied

        //hàm thay đổi - thấy thnawgf bạn có gì đó mình về bbawts chước chỉnh sửa mình - SET()- SETTER()
        public void SetName(string name)
        {
            _name = name;
        }
        public void SetYob(int yob)
        {
            _yob = yob;
        }

        public void SetGpa(double gpa) => _gpa = gpa;
        
        //hàm flex thôgn tin nhiều info thay vì lẻ từng miếng info get lẻ 
        //y chang mỗi các nhân có 1 profile trên mxh: FB, TT...
        public void ShowProfile()
        {
            Console.WriteLine("My profile:");
            Console.WriteLine("ID: " + _id);
            Console.WriteLine("Name" + _name);
            Console.WriteLine("Yob: " + _yob);
            Console.WriteLine("GPA: " + _gpa);
        }
        //hành động chuẩn hóa của mọi object, như hành động đem theo CMND, CCCD khi được hỏi show ra cho việc kiểm tra hành chiinsh 
        //với lập trình object show hết thông tin thân nhân gọi là ToString()
        public override string ToString() => $"ID: {_id} || Name: {_name} || Yob: {_yob} || Gpa: {_gpa}";

        //public override string ToString()
        //{

        //    return $"ID: {_id} || Name: {_name} || Yob: {_yob} || Gpa: {_gpa}";
        //}
    }
}
