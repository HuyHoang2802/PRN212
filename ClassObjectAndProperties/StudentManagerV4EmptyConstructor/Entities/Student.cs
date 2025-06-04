using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV4EmptyConstructor.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        //Mặc đinh nếu class ko có constructor thì khi runtime,  RUntime SDK sẽ tự tọa dùm ta 1 constructor rỗng/ default 
        //BẠn có quyền chủ đôngj tạo constructor default nếu bạn thích - EXPLICITLY CONSTRUCTOR 
        public Student()
        {

        }
        //MẸo nhỏ - Bạn có thể gõ từ khóa CTOR TAB để tưj Gẻneration ra constructor default 
    }
}
