using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2MultipleConstructors.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int  _yob;
        private double _gpa;

        

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string ToString() =>  $"ID: {_id} || Name: {_name} || Yob: {_yob} || Gpa: {_gpa}";
        

        //Hàm showProfile 
        public void showProfile() => Console.WriteLine(ToString());      




        public string GetName() => _name;

        //Hàm set nhận value bên ngoài đưa vào miễn có ý nghĩa 
        public void SetName(string name) { _name = name; }
        public int GetYob() => _yob;
        public void SetYob(int yob) => _yob = yob;

        public double GetGpa() => _gpa;
        public double SetGpa(double gpa) => _gpa = gpa;

        //1 form có nhiều cấch điền, 1 account cũng có những info phải điền trước, info khác điền sau, linh hoạt trong cách điền info. Vậy ta cũng có nhiều constructor ứng với nhiều cách điền info khác nhau, đúc tưởngj với chất liệu khác nhau liều lượng khác nhau 
        //1 class có nhìu constructor, ứng với có nhìu cach tạo object từ 1 cái class/khuôn 

        //Constructor là hàm luôn gọi kèm toán tử new 
        //New nghĩa là xin vùng ram, nghĩa là đi clone, phôto tờ giấy forrm để chuẩn bị điền info, tên nó vì vậy phải 100% giống tên class mang ý nghĩa clone 1 student, new 1 student, new 1 cacis forrm để điền vào, tham số chính là cách đỏo mực điền mực vvaof các in4 chưaf chỗ là cách đổ vật liêu jvaof các chi tiết ngóc ngách trogn khuônS
        //crtl . chọn generaconstructor 


    }
}
