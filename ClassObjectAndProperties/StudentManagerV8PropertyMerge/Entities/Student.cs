using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV8PropertyMerge.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        //public string Id; //nói về ID chính là nói về _id
        //.Id là Get() return _id
        //.Id = "Se1" là set(_id = value SE1 )
        public string Id //public ra ngoài, mà là đăc trưng đặc điểm của 1 object - đặc điểm là Properties
                         //Sinh viên có những đặc điểm mô ta là: ID, name, yob, Gpa
                         //Tự nhiên vô cùng khi đề cập và truy suất đăcj tính của 1 đổi tượng ko như java 
                         //Lúc runtime thì hàm GET() SET() nhưng lucs code thì dễ nhìn hơn 
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name 
        {
            get { return _name; }
            set { _name = value;}
        }
        public int Yob 
        {
            get { return _yob; }
            set { _yob = value; }
        }
        public double Gpa 
        {
            get { return _gpa; }
            set { _gpa = value;}          
        }

        public override string? ToString() => $"Id: {_id} || Name: {_name} || Yob: {Yob} || Gpa: {Gpa}";

    }
}
