using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8
{
    public class RotaryPhone
    {
        internal List<char> symbols = new List<char> { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        public readonly string Number;
        public virtual void Call()
        {
            Console.WriteLine("������, ���� �� ������ ��������������");
            string Number = writeANumber();
            Console.WriteLine("�� ��������������: " + Number);
        }

        public virtual void AcceptCall()
        {
            Console.WriteLine("�� ������ ������");
        }

        internal string writeANumber()
        {
            string tempStr;
            int tempInt;
            var sb = new StringBuilder();
            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("������ {0} ����� ������ ������:", i + 1);
                tempStr = Console.ReadLine();
                if (tempStr.Length != 1)
                {
                    Console.WriteLine("�������!");
                    --i;
                    continue;
                }
                if (Int32.TryParse(tempStr, out tempInt) == false)
                {
                    Console.WriteLine("�������!");
                    --i;
                    continue;
                }
            }
            return sb.ToString();
        }
    }
}