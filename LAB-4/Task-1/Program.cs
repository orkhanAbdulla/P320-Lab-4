using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Group group = new Group();
            group.No = "P320";
            Enternum:
            Student std = new Student();
            Console.WriteLine("Input student fullname");
            std.FullName = Console.ReadLine();
            Console.WriteLine("Input student point");
            std.Point = int.Parse(Console.ReadLine());
            group.AddStudent(std);
            Console.WriteLine("do you want add new student? yes/no");
            string answer = Console.ReadLine();
            if (answer=="yes")
            {
                goto Enternum;
            }
            Console.WriteLine("Group no: " + group.No);
            foreach (var item in group.students)
            {
                Console.WriteLine("Fullname: "+ item.FullName+" "+"Point: "+item.Point);
            }
        }
    }
}
