using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3EmptyConstructor.Entities
{
   public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        //public string GetName() => _name;
        //public void SetName(string name) => _name = name; //Hàm Set() tức là thay đổi 1 object 
        //                                                  //Bằng cách nhận vào 1 value nào đó và thay đổi bên trogn object 
        //public int GetYob() => _yob;
        //public void SetYob(int yob) => _yob = yob;
        //public double GetGpa() => _gpa;
        //public void SetGpa(double gpa) => _gpa = gpa;

        public void SetYob(int value) => _yob = value; 
        
        public void SetName(string value) => _name = value;

        public override string ToString() => $"Id: {_id} || Name: {_name} || Yob: {_yob} || Gpa: {_gpa}";

        public void ShowProfile()
        {
            Console.WriteLine(ToString());
        }
        
    }
    

}
