using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV10PropertyHotK.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        //quên cú pháp gõ propertíe 
        //1. Tạo các _field như bth
        //2. Gõ propfull tab tab 


        //Kĩ thuật viết code gồm cả _BACKING FIELD và GET SET style mới property gọi là 
        //Kĩ thuật Full propertíe - bản full ko che về properties 
        public string Id  //Lễ tân, tiếp tân, receptionist 
                          //interface giao tiếp ra ngoài .Id .Id = 
                          //_Backing FIELD là nhà bếp chống đỡ giúp
        {
            get => _id;
            set => _id = value;
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
        public double Ggpa
        {
            get => _gpa;
            set => _gpa = value;
        }
        //Properties Full hay: tạo được liên kết giữa backing field và property che bên ngoài 
        //Viết tự nhiên theo style chấm biến, biến = .Gpa .Gpa = 
        //Nên nó mới gọi là properties của object - Ko nhầm lẫn nó vi phạm encapsulation 
        //Nô vẫn là Hàm Public GET() SET(), nhưng lại xài như biến cho tự nhiên, gọi 
        //GET() ko tự nhiên, cho tui biết tên của bạ, bạn.tên 


        //Nhưng nó vẫn bị Boiler Plate 
        //Tự nhiên ở sài biến nhưng lắp lại công thức viết cho các _BACKING FIELD 

        //Dẹp luôn Boiler Plate GET () SET() ở trên nếu có thế 

    }
}
