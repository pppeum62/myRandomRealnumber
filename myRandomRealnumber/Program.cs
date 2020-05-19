using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myRandomRealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rand = (int) (random.NextDouble() * 100);

            bool state = true;

            while(state)
            {
                Console.Write("숫자를 입력해주세요 >> ");
                int user = int.Parse(Console.ReadLine());

                if (rand < user)
                {
                    Console.WriteLine(user + "보다는 작은 숫자입니다.\n");
                } else if (rand > user)
                {
                    Console.WriteLine(user + "보다는 큰 숫자입니다.\n");
                } else if (rand == user)
                {
                    Console.WriteLine("정답입니다!\n");
                    state = false;
                }
            }
        }
    }
}
