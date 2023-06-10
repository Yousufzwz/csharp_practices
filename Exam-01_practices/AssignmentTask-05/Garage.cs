using MyCodes.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodes.Core;

    internal  class Garage
    {
        public int TotalVehicleCount { get; set; }

        public Garage(Vehicle v)
        {
            TotalVehicleCount++;
        }

        public int Add(Vehicle t) { return TotalVehicleCount++; }

    }

