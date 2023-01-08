using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8
{
    public class ColorScreenPhone : BlackScreenPhone
    {
        public string SecondNumber;
        public int CountOfColor;
        public bool HavingTwoSIM { get; private set; }

        public ColorScreenPhone() : base()
        {
            MakeSecondNumber();

            CountOfColor = 7;
        }

        public override void Call()
        {
            Console.WriteLine("�� ���� ����� �� ������ ��������������?");
            string Number = writeANumber();

            if (HavingTwoSIM)
            {
                Console.WriteLine("� ����� ������ �� ������ ��������������?\n[1] - {0}\t[2] - {1}", this.Number, SecondNumber);
                var temp = Console.ReadLine();

                if (temp == "1" || temp == "2")
                {
                    Console.WriteLine("*�� ���������� � {0} ���� �� ����� {1}*",
                    temp == "1" ? "�����" : (temp == "2" ? "�����" : ""), Number);
                }
                else Console.WriteLine("�������!");
            }
            else Console.WriteLine("*�� ���������� �� ������� {0}*", Number);
        }

        public override void AcceptCall()
        {
            Console.WriteLine("1234567 ��������!");
            if (HavingTwoSIM)
            {
                Console.WriteLine("� ��� ���� �� ������ �������� ������?\n[1] - {0}\t[2] - {1}", this.Number, SecondNumber);
                var temp = Console.ReadLine();

                if (temp == "1" || temp == "2")
                {
                    Console.WriteLine("*�� �������� ������ � {0} ����*",
                    temp == "1" ? "�����" : (temp == "2" ? "�����" : ""));
                }
                else Console.WriteLine("�������!");
            }
            else Console.WriteLine("*�� ������� �� ������*");
        }

        public override void SendSms()
        {
            Console.Write("������ �����������, ��� ������ �������� 12345678: ");
            string message = Console.ReadLine();
            if (HavingTwoSIM)
            {
                Console.WriteLine("� ��� ����?\n[1] - {0}\t[2] - {1}", this.Number, SecondNumber);
                var temp = Console.ReadLine();

                if (temp == "1" || temp == "2")
                {
                    Console.WriteLine("*�� ��������� ����������� � {0} ����*",
                    temp == "1" ? "�����" : (temp == "2" ? "�����" : ""));
                }
                else Console.WriteLine("�������!");
            }
            else Console.WriteLine("³���������!");
        }

        public void SendMms()
        {
            Console.Write("������ ����� ��������, ��� ��������� �� 12345678 : ");
            string message = Console.ReadLine();
            if (HavingTwoSIM)
            {
                Console.WriteLine("� ��� ����?\n[1] - {0}\t[2] - {1}", this.Number, SecondNumber);
                var temp = Console.ReadLine();

                if (temp == "1" || temp == "2")
                {
                    Console.WriteLine("*�� ��������� �������� � {0} ����*",
                    temp == "1" ? "�����" : (temp == "2" ? "�����" : ""));
                }
                else Console.WriteLine("�������!");
            }
            else Console.WriteLine("³���������!");
        }

        public void AcceptMms()
        {
            Console.Write("�� �������� ����������� �� 12345678 : image.png");

        }

        private void MakeSecondNumber()
        {
            while (true)
            {
                Console.WriteLine("�� ������ ������� ���� ����?\n[1] - Yes\t [2] - No");
                string temp = Console.ReadLine();
                if (temp == "1")
                {
                    HavingTwoSIM = true;
                    this.SecondNumber = writeANumber();
                    break;
                }
                else if (temp == "2")
                {
                    HavingTwoSIM = false;
                    Console.WriteLine("�����!");
                    break;
                }
                else Console.WriteLine("�������");
            }
        }
    }
}