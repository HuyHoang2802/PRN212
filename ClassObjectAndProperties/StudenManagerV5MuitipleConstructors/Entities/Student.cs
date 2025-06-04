using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenManagerV5MuitipleConstructors.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        //1 class có bao nhiêu constructor 
        //Tùy cách bạn muốn đổ info vào các field 
        
        
        //Nếu bạn không tạo constructor rỗng và class ko có constructor nào khác nữa thì runtime tự sinh dùm để ta vẫn new đc 1 object mà chưa default field sau đó dùng set để chỉnh lại giá trị 
        //Bạn có thể chủ động tạo constructor rỗng/default
        //Từ khóa ctor tab để tự generate, thì runtime đâu cần tọa nữa
        //
        //3. nếu class có 1 constructor có tham số bất kì 
        //thì runtime tuyệt dôids ko tạo dùm constructor default, lí đo: đã  có 1 cachs đúc vừa nói rồi vần gì constructor khác nữa 
        public Student(string id ) 
        { 
            _id = id;
        }

        public Student(string id, string name, int yob, double gpa) 
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }
        //Mẹo để tạo nhanh constructor có tham số bất kì 
        //Gõ Keyword  CTRL . chọn generate constructor

        public Student()
        {
            
        }


    }
}
