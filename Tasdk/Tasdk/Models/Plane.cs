using System;
using System.Collections.Generic;
using System.Text;
using Tasdk.Exceptions;
namespace Tasdk.Models
{
    class Plane : Vehicle, IEngine, IWheel, ITransmission
    {
        double _currentOil;
        public double WingLength { get; set; }
        public double HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrentOil
        {
            get { return _currentOil; }
            set
            {
                if (value >= 0)
                    _currentOil = value;
                else throw new NegativeException ("Cant be Negative");
            }
        }
        public string FuelType { get; set; }
        public double WheelThickness { get; set; }
        public string TransmissionKind { get; set; }


    }
}

