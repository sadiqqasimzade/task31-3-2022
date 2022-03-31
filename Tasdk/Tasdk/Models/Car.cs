using System;
using System.Collections.Generic;
using System.Text;

namespace Tasdk.Models
{
    class Car:Vehicle,ITransmission,IEngine,IWheel
    {
        public int DoorCount { get; set; }
        public string VinCode { get; set; }
        public double WheelThickness { get  ; set  ; }
        public double HorsePower { get  ; set  ; }
        public double TankSize { get  ; set  ; }
        public double CurrentOil { get  ; set  ; }
        public string FuelType { get  ; set  ; }
        public string TransmissionKind { get  ; set  ; }
        public override double DriveTime { get  ; set  ; }
        public override double DrivePath { get  ; set  ; }


        public override void ShowInfo()
        {
            Console.WriteLine($"DoorCount:{DoorCount},VinCode:{VinCode},WheelThickness:{WheelThickness}" +
                $",HorsePower:{HorsePower},CurrentOil:{CurrentOil},FuelType:{FuelType},Transmission Auto:{TransmissionKind}" +
                $",DriveTime:{DriveTime},DrivePath:{DrivePath},Avarange Speed:{AvarangeSpeed()}");
        }
    }
}
