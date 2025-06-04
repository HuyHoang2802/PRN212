using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV6Property.Entities //package bên Java - thư mục chứa class/code 
{
    public class Student
    {
        private string _id;
        private string _name;
        private int  _yob;
        private double _gpa;

        //Bỏ qua constructor, gọi default() sau đó gọi get() set()
        public string GetId () => _id; 
        public void SetId(string value) => _id = value;
        public string GetName () => _name;
        public void SetName (string value ) => _name = value;

        public int GetYob () => _yob;
        public void SetYob(int value) => _yob = value;
        public double GetGgpa () => _gpa;

    
        }

}
