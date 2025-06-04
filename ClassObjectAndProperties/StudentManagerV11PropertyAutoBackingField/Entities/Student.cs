using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV11PropertyAutoBackingField.Entities
{
    public class Student
    {
        public int Id { get; set; } // Tự lúc runtime tự sinh ra giùm _id
                                    
        public string Name { get; set; }//Tự sinh ra giùm backing field 
        public int Yob { get; set; } 
        public double Gpa { get; set; }

        // .id .id = "SE1"
    }
}
