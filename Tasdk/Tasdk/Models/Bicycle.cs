using System;
using System.Collections.Generic;
using System.Text;

namespace Tasdk.Models
{
    class Bicycle:Vehicle,IWheel
    {
        

        public bool PedalKind { get; set; } //auto manual
        public double WheelThickness { get  ; set  ; }


      

    }
}
