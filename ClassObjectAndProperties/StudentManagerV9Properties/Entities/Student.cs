using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV9Properties.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        //GET() SET() theo style Hybrid - property 
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int Yob
        {
            get => _yob;
            set => _yob = value;
        }
        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }

        }
    }
}
