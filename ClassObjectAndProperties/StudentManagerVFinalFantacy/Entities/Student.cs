using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerVFinalFantacy.Entities
{
    public class Student
    {


        //quên thì gõ propfull
        //Ngắn gọn tự động generation ra _BackingField, Loại bỏ bolder Plate 
        //Gõ: prop tab tab, tự sửa lại cho phù hợp 
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }
        //Kĩ thuật này ko thấy nhà bếp chỉ thấy tiếp tân, interface matwj tuền, runtime tự generate dùm full code như JAVA 
        //Kĩ thuật này gọi là AUTO_IMPLEMENTED PROPERTY 
        // hậu trường runtime tự generrate ra _backing fields và GET() SET() truyền thống 

        //Dù xài Full PROPERTY hay AUTO - IMPLEMENTED PROPERTY ta cũng new theo style 
        //new Student() {...} Object Initializer 

        
    }
}