using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E003_1_Exercise.src
{
    public class Box
    {
        public double lengthCm;
        public double widthCm;
        public double heightCm;

        public double GetVolume()
        {
            //change the code so that it returns the volume
            return lengthCm * widthCm * heightCm;
        }
    }
}
