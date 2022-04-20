namespace Demo1
{
    internal class Student
    {
        private string _name;
        private int _age;
        private string _maSoSinhVien;
        private List<string> _monHoc;

        public Student()
        {
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public List<string> MonHoc
        {
            get { return _monHoc; }
            set

            {
                _monHoc = value;
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
            }
        }

        public string MaSoSinhVien
        {
            set
            {
                _maSoSinhVien = value;
            }
            get
            {
                return _maSoSinhVien;
            }
        }
    }
}