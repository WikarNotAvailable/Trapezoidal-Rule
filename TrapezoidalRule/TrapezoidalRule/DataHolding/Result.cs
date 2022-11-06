using System;
using System.Collections.Generic;
using System.Text;

namespace TrapezoidalRule
{
    public class Result
    {
        public TimeSpan ElapsedTime { get; set; }
        public double CalculatedIntegral { get; set; }

        public Result(TimeSpan elapsedTime, double calculatedIntegral)
        {
            (ElapsedTime, CalculatedIntegral) = (elapsedTime, calculatedIntegral);
        }
    }
}
