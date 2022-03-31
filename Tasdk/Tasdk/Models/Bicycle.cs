using System;
using System.Collections.Generic;
using System.Text;

namespace Tasdk.Models
{
    class Bicycle:Vehicle,IWheel
    {
        public bool PedalKind { get; set; } //auto manual
        public double WheelThickness { get  ; set  ; }
        public override double DriveTime { get  ; set  ; }
        public override double DrivePath { get  ; set  ; }

      

        public override void ShowInfo()
        {
            Console.WriteLine($"PedalKind:{PedalKind},Wheel:{WheelThickness},DriveTime:{DriveTime},DrivePath:{DrivePath},Avarange Speed:{AvarangeSpeed()}");
        }
    }
}
