using System;
using System.Collections.Generic;
using System.Text;
using Tasdk.Exceptions;
namespace Tasdk.Models
{
    abstract class Vehicle
    {
        double _drivePath;
        double _driveTime;
        public double DriveTime
        {
            get { return _driveTime; }
            set
            {
                if(value >= 0)
                    _driveTime = value;
                else throw new NegativeException("Cant be Negative");
            }
        }
        public double DrivePath
        {
            get { return _drivePath; }
            set
            {
                if (value >= 0)
                    _drivePath = value;
                else throw new NegativeException("Cant be Negative");
            }
        }

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

        static void NegativeCheck(ref ValueTuple value)
        {

        }
        static void ZeroOrNegativeCheck()
        {

        }


    }
}
