using System;
using System.Collections.Generic;
using System.Text;

namespace Tasdk.Models
{
    class Plane:Vehicle,IEngine,IWheel,ITransmission
    {
        public double WingLength { get; set; }
        public double HorsePower { get  ; set  ; }
        public double TankSize { get  ; set  ; }
        public double CurrentOil { get  ; set  ; }
        public string FuelType { get  ; set  ; }
        public override double DriveTime { get  ; set  ; }
        public override double DrivePath { get  ; set  ; }
        public double WheelThickness { get  ; set  ; }
        public static TransmissionKind { get  ; set  ; }

       

        public override void ShowInfo()
        {
            Console.WriteLine($"WingLength:{WingLength},HorsePower:{HorsePower},TankSize:{TankSize}" +
                $",CurrentOil:{CurrentOil},FuelType:{FuelType},DriveTime:{DriveTime}" +
                $",DrivePath{DrivePath},WheelThickness:{WheelThickness},TransmissionKind:{TransmissionKind},Avarange Speed:{AvarangeSpeed()}");
        }
    }
}
