using System;
using System.Collections.Generic;
using System.Text;
using Task.Custom_Exceptions;
namespace Task.Models
{
    class Group
    {
        private int _studentLimit;
        private string _groupno;
        public string GroupNo
        {
            get { return _groupno; }
            set
            {
                if (CheckGroupNo(value))
                    _groupno = value;
                else throw new Exception("Must contain 2 upper letters and 3 digits");
            }
        }
        public int StudentLimit
        {
            get { return _studentLimit; }
            set
            {
                if (value >= 5 && value <= 18)
                    _studentLimit = value;
                else throw new Exception("Limit cant be less than 5 and more than 18");
            }
        }
        Student[] students = new Student[0];

        public Group(string groupno, int studentlimit)
        {
            GroupNo = groupno;
            StudentLimit = studentlimit;
        }
        public bool CheckGroupNo(string groupNo)
        {
            if (!String.IsNullOrEmpty(groupNo) && !String.IsNullOrWhiteSpace(groupNo) && groupNo.Length == 5)
            {
                int upperCounter = 0;
                int digitCounter = 0;
                for (int i = 0; i < 2; i++)
                    if (char.IsUpper(groupNo[i])) upperCounter++;

                if (upperCounter == 2)
                {
                    for (int i = 2; i < 5; i++)
                        if (char.IsDigit(groupNo[i]))
                            digitCounter++;
                }
                else return false;
                if (digitCounter == 3) return true;
            }
            return false;
        }
        public void AddStudent(Student student)
        {
            if (students.Length < StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
            else throw new NoSpaceAvailable("No space avairable");
        }
        public Student GetStudent(int? id)
        {
            if (id !=null)
            {
                foreach (var student in students)
                {
                    if (student.Id == id) return student;
                }
                throw new Exception("Not Found");
            }

            throw new Exception("Cant be null");
        }
        public Student[] GetAllStudents()
        {
            return students;
        }
    }
}
