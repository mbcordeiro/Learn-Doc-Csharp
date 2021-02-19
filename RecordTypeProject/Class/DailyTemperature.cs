using System;
using System.Collections.Generic;
using System.Text;

namespace RecordTypeProject.Class
{
    public record DailyTemperature(double HighTemp, double LowTemp)
    {
        public double Mean => (HighTemp + LowTemp) / 2.0;
    }
}
