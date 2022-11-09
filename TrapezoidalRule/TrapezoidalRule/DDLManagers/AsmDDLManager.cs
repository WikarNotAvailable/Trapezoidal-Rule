using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TrapezoidalRule.DataHolding;

namespace TrapezoidalRule.DDLManagers
{
    public class AsmDDLManager
    {
        [DllImport(@"C:\Users\wikar\OneDrive\Pulpit\PROGRAMOWANIE\Trapezoidal-Rule\TrapezoidalRule\x64\Debug\MyAsm.dll")]
        static extern double CalculateAreaOfTrapeze(double a, double b, double c, double leftpoint, double rightpoint);

        private InputForIntegration _input { get; set; }
        public AsmDDLManager(InputForIntegration input)
        {
            _input = input;
        }
        public Result CalculateIntegralInAsm()
        {
            Stopwatch stopWatch = new Stopwatch();
            var accuracy = 2000000;
            var deltaX = (_input.RightRange - _input.LeftRange) / accuracy;
            List<Task<double>> tasks = new List<Task<double>>();

            stopWatch.Start();
            for (double i = _input.LeftRange; i < _input.RightRange; i += deltaX)
            {
                tasks.Add(Task<double>.Factory.StartNew((Object obj) =>
                {
                    TrapezeData input = obj as TrapezeData;

                    var val = CalculateAreaOfTrapeze(input.a, input.b, input.c, input.LeftPoint, input.RightPoint);
                    return val;
                }, new TrapezeData(_input.a, _input.b, _input.c, i, i + deltaX)
                ));
            }
            Task.WaitAll(tasks.ToArray());
            stopWatch.Stop();

            double area = 0;
            for (int i = 0; i < tasks.Count; i++)
            {
                area += tasks[i].Result;
            }

            TimeSpan timeElapsed = stopWatch.Elapsed;

            return new Result(timeElapsed, area);
        }
    }
}
