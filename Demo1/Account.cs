using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Accounts
    {
        public string UserName;
        public string Password;
        public string Email;
        public void Nhap()
        {
            Console.WriteLine("Nhập Tên tài khoản:");
            UserName = Console.ReadLine();
            Console.WriteLine("Nhập Password : ");
            Password = Console.ReadLine();
            Console.WriteLine("Nhập Email của bạn : ");
            Email = Console.ReadLine();

        }
        public void Xuat()
        {
            Console.WriteLine("Tên Tài khoản {0} --- Mật Khẩu {1} --- Tài Khoản Email của bạn là : {2}", UserName, Password, Email);
        }

    }
}
