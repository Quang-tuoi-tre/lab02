using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    class student
    {
        private string studentID;
        private string fullName;
        private float averageScore;
        private string faculty;

        public student()
        {

        }
        public student(string studentID, string fullName, float averageScore, string faculty)
        {
            this.studentID = studentID;
            this.fullName = fullName;
            this.averageScore = averageScore;
            this.faculty = faculty;
        }
        

        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public float AverageScore { get => averageScore; set => averageScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }

        public void Input()
        {
            Console.Write("Nhap mssv: ");
            studentID = Console.ReadLine();
            Console.Write("Nhap ho va ten: ");
            fullName = Console.ReadLine();
            Console.Write("Nhap diem trung binh: ");
            averageScore = float.Parse(Console.ReadLine());

            Console.Write("Nhap khoa: ");
            faculty = Console.ReadLine();
        }

        public void show()
        {
            Console.WriteLine("MSSV: {0} Ho ten: {1} Khoa {2} DiemTB: {3}", this.studentID, this.fullName, this.faculty, this. averageScore);
        }
    }
  

}
