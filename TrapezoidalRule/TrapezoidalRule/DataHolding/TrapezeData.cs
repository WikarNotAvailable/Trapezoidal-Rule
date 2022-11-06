using System;
using System.Collections.Generic;
using System.Text;

namespace TrapezoidalRule.DataHolding
{
    public class TrapezeData
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double LeftPoint { get; set; }
        public double RightPoint { get; set; }

        public TrapezeData(double _a, double _b, double _c, double leftPoint, double rightPoint)
        {
            (a, b, c, LeftPoint, RightPoint) = (_a, _b, _c, leftPoint, rightPoint);
        }
    }
}

