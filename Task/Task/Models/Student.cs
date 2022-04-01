using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Models
{
    class Student
    {
        private static int _id = 0;
        private double _point;
        private string _fullname;
        public int Id { get; }
        public string FullName
        {
            get { return _fullname; }
            set
            {
                if (!String.IsNullOrEmpty(value) || !String.IsNullOrWhiteSpace(value))
                {
                    _fullname = value.Trim();
                }
                else throw new Exception("Fullname Cant be empty");
            }
        }
        public double Point
        {
            get { return _point; }
            set
            {
                if (value <= 100 && value >= 0)
                    _point = value;
                else throw new Exception("Invalid Point values");
            }
        }
        public Student(string fullname, double point)
        {
            FullName = fullname;
            Point = point;

            Id = _id;
            _id++;
        }
        public string StudentInfo()
        {
            return ($"-----------------------\nId:{Id}\nFullName:{FullName}\nPoint:{Point}");
        }
        public override string ToString()
        {
            return StudentInfo();
        }

    }
}
