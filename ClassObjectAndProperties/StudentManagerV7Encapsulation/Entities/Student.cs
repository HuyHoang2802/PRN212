using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV7Encapsulation.Entities
{
    public class Student
    {
        private string Id; //private thì là _id
        private string Name;
        private int Yob;
        private double Gpa;

        //Ko làm costructor thì dùng default constructor, mọi field lúc này là public - ko private() sẽ default số thì là 0 

        //Vì để public cho nên chạm đc 4  biến trên liền ngya và luôn sau khi new, chạm trục tiếp luôn mà ko cần hàm Get() Set() 

        //Xài GET() SET() khỏi có Boiler-plate - ko nhàm chán, ngắn gọn nữa là khác 

           
    }
}
