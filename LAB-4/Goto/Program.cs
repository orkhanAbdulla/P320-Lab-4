using System;

namespace Goto
{
    class Program
    {
        static void Main(string[] args)
        {
            #region goto
            string numstr;
            int num;
            Enternum:
            Console.WriteLine("eded daxil edin");
            numstr = Console.ReadLine();
            bool result = int.TryParse(numstr, out num);
            if (result==false)
            {
                goto Enternum;
            }
            Console.WriteLine("num"+num);

            #endregion
        }
    }
}
