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



        
    }
}
