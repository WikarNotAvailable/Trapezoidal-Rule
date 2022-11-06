using System;
using System.Collections.Generic;
using System.Text;

namespace TrapezoidalRule.DataHolding
{
    public class InputForIntegration
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double LeftRange { get; set; }
        public double RightRange { get; set; }

        public InputForIntegration(double _a, double _b, double _c, double leftRange, double rightRange)
        {
            (a, b, c, LeftRange, RightRange) = (_a, _b, _c, leftRange, rightRange);
        }
    }
}
