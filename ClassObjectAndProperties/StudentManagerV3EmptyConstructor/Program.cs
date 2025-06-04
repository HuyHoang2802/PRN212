using System.Runtime.Intrinsics.Arm;
using StudentManagerV3EmptyConstructor.Entities;

namespace StudentManagerV3EmptyConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(); //Constructor rỗng 
            s1.ShowProfile();
            s1.SetName("An");
            s1.SetYob(2006);
            Console.WriteLine("Check s1 object after setting:");
            s1.ShowProfile();
        }
    }
}
