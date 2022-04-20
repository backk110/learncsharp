using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.Write("Hello World \n");
            //Console.Write("số của bạn là: ");

            //Int32 num = 30;

            //Console.Write(num);

            //Console.Write(Environment.NewLine);

            //Console.Write("Số double của bạn là: ");

            //double num1 = 17.20;

            //Console.Write(num1);
            //Console.Write(Environment.NewLine);

            //Console.WriteLine("kiêu boolean của bạn trả về kết quả là :");

            ////Boolean status = true;

            ////Console.Write(status);

            //String message = "Xin Chào Mình  :))";
            //Console.WriteLine(message);
            //Int32 val1 = 10, val2 = 20;
            //bool status = true;
            //Console.WriteLine(val1 + val2);
            //Console.WriteLine(val1 < val2);
            //Console.WriteLine(!(status));

            //Int32 value = 11;
            //if(value < 10)
            //{
            //    Console.WriteLine("Số của bạn nhỏ hơn 10");
            //}
            //else
            //{
            //    Console.WriteLine("Số của bạn lớn hơn 10");
            //}
            //Int32 valueA = 6;
            //switch (valueA)
            //{
            //    case 1: Console.WriteLine("value is 1");
            //        break;
            //    case 2: Console.WriteLine("Value is 2");
            //        break;
            //    case 3: Console.WriteLine("Kết quả bằng 3");
            //        break;
            //    default: Console.WriteLine("Value ís different");
            //        break;
            //}
            ////Int32 valueB = 4 ,i = 0;
            ////while (i < valueB)
            ////{
            ////    Console.WriteLine(i);
            ////    i = i + 1;
            ////}

            ////for (Int32 i = 0; i < 5; i++)
            ////{
            ////    Console.WriteLine(i);
            ////}
            //Int32[] valueC;
            //valueC = new Int32[4];
            //valueC[0] = 1;
            //valueC[1] = 2;
            //valueC[2] = 3;
            //valueC[3] = 4;

            //Console.WriteLine(valueC[0]);
            //Console.WriteLine(valueC[1]);
            //Console.WriteLine(valueC[2]);
            //Console.WriteLine(valueC[3]);
            //Accounts User1 = new Accounts();
            //User1.Nhap();
            //User1.Xuat();

            ////User1.Info();
            //Vehicle OtoCon = new Vehicle();
            //OtoCon.TenXe = "Vinfast";
            //OtoCon.Color = "Đen";
            //OtoCon.Speed = 200;
            //OtoCon.Height = 50;
            //OtoCon.SoBanhXe = 4;
            //OtoCon.Width = 100;
            //OtoCon.MyCar();
            //StudentN nam = new StudentN("879123WQE7123", "Nam", 10);
            //nam.Age = 19;
            //Console.WriteLine("Tuổi" + nam.Age);
            //Student sv1 = new Student("nam", 20, "1234IQY");
            //string[] monHoc1 = new string[4] { "GDQP", "Toán", "Triết học", "Thể dục" };
            //Console.WriteLine("Mời bạn nhập mssv: ");
            //sv1.MaSoSinhVien1 = Console.ReadLine();

            //Student[] students = new Student[3];
            //students[0] = new Student("Tuan", 10, "1231BCD", "GDQP");
            //students[1] = new Student("Cuong", 15, "1123LKJ", "mac-le-nin");
            //students[2] = new Student("Duc", 21, "2133LKK", "Toán");

            //for (int i = 0; i < students.Length; i++)
            //{
            //    students[i].Xuat();
            //}
            Student[] students = new Student[3];
            Student sv1 = new Student();
            sv1.Name = "Nam";
            sv1.MaSoSinhVien = "1234IQY";
            sv1.Age = 20;
            sv1.MonHoc = new string[] { "Toán", " The duc", "Tin", "Văn" };
            students[0] = sv1;
            Student sv2 = new Student();
            sv2.Name = "An";
            sv2.MaSoSinhVien = "2133LKK";
            sv2.Age = 21;
            sv2.MonHoc = new string[] { "Toán", " The duc", "Tin", "Văn" };
            students[1] = sv2;

            Student sv3 = new Student();
            sv3.Name = "Bảo";
            sv3.MaSoSinhVien = "1237GHQ";
            sv3.Age = 22;
            sv3.MonHoc = new string[] { "Toán", " The duc", "Tin", "Văn" };
            students[2] = sv3;
            Console.WriteLine("Mời bạn nhập mssv: ");
            string s = Console.ReadLine();
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && s == students[i].MaSoSinhVien)
                {
                    Console.WriteLine("Tên sinh viên là: " + students[i].Name + " | Tuổi sinh viên đó là: " + students[i].Age + " | Mã số sinh viên là: " + students[i].MaSoSinhVien);
                    Console.WriteLine("Môn Học là: " + students[i].MonHoc[0] + " |" + students[i].MonHoc[1] + " |" + students[i].MonHoc[2] + " |" + students[i].MonHoc[3]);
                }
            }
            Console.WriteLine("Mời bạn nhập môn học cần xóa: ");
            string s1 = Console.ReadLine();
            int count = 0;
            for (int j = 0; j < students.Length; j++)
            {
                for (int n = 0; n < students[j].MonHoc.Length; n++)
                {
                    if (students[j] != null && s1 == students[j].MonHoc[n] || s1 == students[j].MonHoc[3])
                    {
                        for (int m = n; m < students[j].MonHoc.Length - 1; m++)
                        {
                            students[j].MonHoc[m] = students[j].MonHoc[m + 1];
                        }
                        count = count + 1;
                    }
                    else
                    {
                        Console.WriteLine("Bạn đã nhập sai môn học cần xóa");
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("xóa không thành công");
            }
            else
            {
                Console.WriteLine("xóa thành công");
                for (int j = 0; j < students.Length - 1; j++)
                {
                    Console.WriteLine(students[j].MonHoc[j] + " ");
                }
            }
            for (int j = 0; j < students.Length; j++)
            {
                //Console.WriteLine("Môn Học là: " + students[j].MonHoc[0] + students[j].MonHoc[1] + students[j].MonHoc[2]);
                Console.WriteLine("Môn là :" + students[j].MonHoc[0] + students[j].MonHoc[1] + students[j].MonHoc[2]);
            }
        }
    }
}