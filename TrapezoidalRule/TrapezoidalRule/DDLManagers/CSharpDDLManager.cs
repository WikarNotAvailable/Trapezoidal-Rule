using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using TrapezoidalRule.DataHolding;
using MyCSharpDLL;
using System.Threading.Tasks;
using System.Threading;

namespace TrapezoidalRule.DDLManagers
{
    public class CSharpDDLManager
    {
        private InputForIntegration _input { get; set; }

        public CSharpDDLManager(InputForIntegration input)
        {
            _input = input;
        }

        public Result CalculateIntegralInCSharp()
        {
            Stopwatch stopWatch = new Stopwatch();
            var accuracy = 2000000;
            var deltaX = (_input.RightRange - _input.LeftRange) / accuracy;
            List<Task<double>> tasks = new List<Task<double>>();
 
            stopWatch.Start();
            for(double i = _input.LeftRange; i < _input.RightRange; i += deltaX)
            {
                tasks.Add(Task<double>.Factory.StartNew((Object obj) =>
                {
                    TrapezeData input = obj as TrapezeData;

                    return TrapezeAreaCalculator.CalculateAreaOfTrapeze(input.a, input.b, input.c, input.LeftPoint, input.RightPoint);
                }, new TrapezeData(_input.a, _input.b, _input.c, i, i+deltaX)
                ));
            }
            Task.WaitAll(tasks.ToArray());
            stopWatch.Stop();

            double area = 0;
            for(int i = 0; i < tasks.Count; i++)
            {
                area += tasks[i].Result;
            }

            TimeSpan timeElapsed = stopWatch.Elapsed;

            return new Result(timeElapsed, area);
        }
    }
}
