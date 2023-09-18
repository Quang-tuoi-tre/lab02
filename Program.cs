using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    class Program
    {
       
        static void addStudent(List<student> studentList)
        {
            Console.WriteLine("Nhap thong tin sinh vien: ");
            student student = new student();
            student.Input();
            studentList.Add(student);
            Console.WriteLine("Them sinh vien thanh cong");
        }
        static void DisplayStudent(List<student> studentList)
        {
            Console.WriteLine("---Danh sach thong tin sinh vien ---");
            foreach (student student in studentList)
            {
                student.show();
            }
        }
        static void displayfaculity(List<student> studentList, string faculty)
        {
            Console.WriteLine("--Danh sach sinh vien thuoc khoa{0} ", faculty);
            var students = studentList.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayStudent(students);
        }
        static void displayhighscore(List<student> studentList, float minDTB)
        {
            Console.WriteLine("--Danh sach sinh vien co diem tb >= {0} ", minDTB);
            var students = studentList.Where(s => s.AverageScore >= minDTB).ToList();
            DisplayStudent(students);
        }

        static void sorthighscore(List<student> studentList)
        {
            Console.WriteLine("--Danh sach sinh vien co diem tb tang dan ");
            var students = studentList.OrderBy(s => s.AverageScore).ToList();
            DisplayStudent(studentList);
        }

        static void displaybyfacandscore(List<student> studentList, string faculty, float minDTB)
        {
            Console.WriteLine("--Danh sach sinh vien co diem tb >={0} va thuoc khoa {1} ", minDTB, faculty);
            var students = studentList.Where(s => s.AverageScore>=minDTB && s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayStudent(studentList);
        }
        static void DisplayStudentWithHighestAverageByFaculty(List<student> studentList, string faculty)
        {
            Console.WriteLine("=== Sinh viên có điểm TB cao nhất khoa {0} ===", faculty);
            var studentsInFaculty = studentList.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();

            if (studentsInFaculty.Count > 0)
            {
                var highestAvgScore = studentsInFaculty.Max(s => s.AverageScore);
                var topStudents = studentsInFaculty.Where(s => s.AverageScore == highestAvgScore).ToList();

                Console.WriteLine("Điểm TB cao nhất trong khoa {0}: {1}", faculty, highestAvgScore);

                Console.WriteLine("Danh sách sinh viên có điểm TB cao nhất:");
                DisplayStudent(topStudents);
            }
            else
            {
                Console.WriteLine("Không có sinh viên thuộc khoa {0} trong danh sách.", faculty);
            }
        }
        //case 8
        static void CountStudentsByGrade(List<student> studentList)
        {
            Console.WriteLine("=== Số lượng của từng xếp loại ===");

            // Tạo biến để theo dõi số lượng từng loại
            int xuatSacCount = 0;
            int gioiCount = 0;
            int khaCount = 0;
            int trungBinhCount = 0;
            int yeuCount = 0;
            int kemCount = 0;

            foreach (student student in studentList)
            {
                float avgScore = student.AverageScore;

                // Dựa trên thang điểm 10, xác định xếp loại cho từng sinh viên
                if (avgScore >= 9.0)
                {
                    xuatSacCount++;
                }
                else if (avgScore >= 8.0)
                {
                    gioiCount++;
                }
                else if (avgScore >= 7.0)
                {
                    khaCount++;
                }
                else if (avgScore >= 5.0)
                {
                    trungBinhCount++;
                }
                else if (avgScore >= 4.0)
                {
                    yeuCount++;
                }
                else
                {
                    kemCount++;
                }
            }

            // In ra số lượng của từng xếp loại
            Console.WriteLine("Xuất sắc: {0} sinh viên", xuatSacCount);
            Console.WriteLine("Giỏi: {0} sinh viên", gioiCount);
            Console.WriteLine("Khá: {0} sinh viên", khaCount);
            Console.WriteLine("Trung bình: {0} sinh viên", trungBinhCount);
            Console.WriteLine("Yếu: {0} sinh viên", yeuCount);
            Console.WriteLine("Kém: {0} sinh viên", kemCount);
        }
        static void Main(string[] args)
        {
            List<student> studentList = new List<student>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Hien thi danh sach");
                Console.WriteLine("3. Hien thi danh sach sinh vien thuoc khoa cntt");
                Console.WriteLine("4. Hien thi danh sach sinh vien co diem tb lon hon 5");
                Console.WriteLine("5. Hien thi danh sach sinh vien co diem tb tang dan");
                Console.WriteLine("6. Hien thi danh sach sinh vien co deim tb lon hon 5 va thuoc khoa CNTT");
                Console.WriteLine("7. Hien thi sinh vien co diem cao nhat khoa CNTT");
                Console.WriteLine("8. Hien thi so luong cua tung xep loai danh sach sinh vien");
        
                Console.WriteLine("0. Thoat");
                Console.WriteLine("Chon chuc nang (1-8): ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        addStudent(studentList);
                        break;
                    case "2":
                        DisplayStudent(studentList);
                        break;
                    case "3":
                        displayfaculity(studentList, "CNTT");
                        break;
                    case "4":
                        displayhighscore(studentList, 5);
                        break;
                    case "5":
                        sorthighscore(studentList);
                        break;
                    case "6":
                        displaybyfacandscore(studentList, "CNTT", 5);
                        break;
                    case "7":
                        DisplayStudentWithHighestAverageByFaculty(studentList, "CNTT");
                        break;
                    case "8":
                        CountStudentsByGrade(studentList);
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Thoat");
                        break;
                    default:
                        Console.WriteLine("Chuong trinh khong hop le ");
                        break;
                }
                Console.WriteLine();
            }

        }
    }

   
}
