using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8
{
    public class BlackScreenPhone : ButtonsPhone
    {
        internal string ScreenResolution;
        internal string ScreenSize;
        public string Color;

        public BlackScreenPhone() : base()
        {
            Console.WriteLine("������ �������� �������� ������: ");
            ScreenResolution = Console.ReadLine();
            Console.WriteLine("������ �����: ");
            ScreenSize = Console.ReadLine();
            Console.WriteLine("������ ����: ");
            Color = Console.ReadLine();
        }
        public virtual void SendSms()
        {
            Console.Write("������ ���, ��� ������ ��������� �� 0930530941 :");
            string message = Console.ReadLine();
        }

        public virtual void AcceptSms()
        {
            Console.WriteLine("� ��� 1 ���� �����������: �����");
        }
    }
}