using System;
using System.Collections.Generic;
using System.Text;

namespace Tasdk.Models
{
    abstract class Vehicle
    {
        public abstract double DriveTime { get; set; }
        public abstract double DrivePath { get; set; }

        public double AvarangeSpeed()
        {
            try
            {
                return DrivePath / DriveTime;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public abstract void ShowInfo();
       
    }
}
