using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            ArmStrongNumber();
        }
       static void ArmStrongNumber()
        {
            Console.WriteLine("ENTER THE NUMBER WHICH YOU WANT TO CHECK WHETHER IT IS ARMSTRONG NUMBER OR NOT");
            int numbers = Convert.ToInt32(Console.ReadLine());
            int temp = numbers;
            int sum = 0;
            for(int i=0;i<numbers;)
            {
                int mode = numbers % 10;
                numbers = numbers / 10;
                sum = sum + mode * mode * mode;
            }
            if(temp.Equals(sum))
            {
                Console.WriteLine(temp + " is a ArmStrongNumber");

            }
            else
            {
                Console.WriteLine(temp + " is not a ArmStrongNumber");
            }
        }
    }
}
