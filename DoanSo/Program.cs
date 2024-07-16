using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Chuong trinh doan so ===");
            Random random = new Random();
            int targetNumber = random.Next(100, 999);
            string targetString = targetNumber.ToString();
            int attemp = 1, MAX_GUESS = 7;
            string guest, feedback = "";
            while (feedback != "+++" && attemp <= MAX_GUESS)
            {
                Console.Write("Lan doan thu {0}: ", attemp);
                guest = Console.ReadLine();
                feedback = GetFeedback(targetString, guest);
                Console.WriteLine("Phan hoi tu may tinh {0}", feedback);
                attemp++;
            }
            Console.WriteLine("Nguoi choi da doan la nthu {0} lan. Tro choi ket thuc!", attemp - 1);
            if(attemp > MAX_GUESS)
            {
                Console.WriteLine("Nguoi choi thua cuoc. So lan doan la: {0}", targetNumber);
            } else
            {
                Console.WriteLine("Nguoi choi thang cuoc!", attemp);
            }
            Console.ReadLine();
        }
        static string GetFeedback(string targetString, string guest)
        {
            string feedback = "";
            for (int i = 0;i<targetString.Length; i++)
            {
                if (targetString[i] == guest[i])
                    feedback += "+";
                else if (targetString.Contains(guest[i].ToString()))
                    feedback += "?";
            }
            return feedback;
        }
    }
}
