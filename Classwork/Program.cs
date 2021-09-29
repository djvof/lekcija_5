using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[3];
            var texts = new string[2];
            bool[] values = new bool[4];

            nums[0] = 15;
            nums[1] = 27;

            foreach (int num in nums)
            {
                Console.WriteLine($"Inside foreach {num}"  );
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                Console.WriteLine($"Inside for {num}");
            }

            int j = 0;
            while (j < nums.Length)
            {
                int num = nums[j];
                Console.WriteLine($"Inside while {num}");
                j++;
            }


            int userNumber = GetNumberSafe();
            Console.WriteLine($"Saely got number: {userNumber}");

            Console.ReadLine();
        }
        static int GetNumberSafe()
        {

            int num;
            bool isValidNum = false;
            do
            {
                Console.WriteLine("Ievadiet veselu skaitļi? ");
                string userText = Console.ReadLine();
                isValidNum = int.TryParse(userText, out num);


            } while (!isValidNum);

            return num;
        }

    }
}
