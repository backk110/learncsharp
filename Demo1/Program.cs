namespace Demo1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var students = new Student[] {
                new Student
                {
                    Name = "Nam",
                    MaSoSinhVien = "1234IQY",
                    Age = 20,
                    MonHoc = new List<string> { "Toán", " The duc", "Tin", "Văn" }
                },
                new Student
                {
                    Name = "An",
                    MaSoSinhVien = "2133LKK",
                    Age = 21,
                    MonHoc = new List<string> { "Toán", " The duc", "Tin", "Văn" }
                },
                new Student
                {
                    Name = "Bảo",
                    MaSoSinhVien = "1237GHQ",
                    Age = 22,
                    MonHoc = new List<string> { "Toán", " The duc", "Tin", "Văn" }
                }
            };

            string mssv = "1234IQY";

            for (int i = 0; i < students.Length; i++)
            {
                if (mssv == students[i].MaSoSinhVien)
                {
                    Console.WriteLine("Tên sinh viên là: " + students[i].Name + " | Tuổi sinh viên đó là: " + students[i].Age + " | Mã số sinh viên là: " + students[i].MaSoSinhVien);
                    Console.WriteLine("Môn Học là: " + students[i].MonHoc[0] + " |" + students[i].MonHoc[1] + " |" + students[i].MonHoc[2] + " |" + students[i].MonHoc[3]);
                }
            }

            string subjectForRemove = "Văn";

            for (int i = 0; i < students.Length; i++)
            {
                var subjectsOfCurrenStudent = students[i].MonHoc;

                for (int n = 0; n < subjectsOfCurrenStudent.Count; n++)
                {
                    if (subjectForRemove == subjectsOfCurrenStudent[n])
                    {
                        subjectsOfCurrenStudent[n] = null;
                    }
                }
            }
            int a = 0;
        }
    }
}