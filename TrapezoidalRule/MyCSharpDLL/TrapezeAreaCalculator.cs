using System;

namespace MyCSharpDLL
{
    public class TrapezeAreaCalculator
    {
        public static double CalculateAreaOfTrapeze(double a, double b, double c, double leftRange, double rightRange)
        {
            var firstValueOfFunction = a * leftRange * leftRange + b * leftRange + c;
            var secondValueOfFunction = a * rightRange * rightRange + b * rightRange + c;
            var range = rightRange - leftRange;

            var trapezeArea = ((firstValueOfFunction + secondValueOfFunction) * range / 2);

            return  trapezeArea >= 0 ? trapezeArea : -trapezeArea;
        }
    }
}
