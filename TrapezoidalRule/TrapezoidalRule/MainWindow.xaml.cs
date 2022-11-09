using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using MyCSharpDLL;
using TrapezoidalRule.DataHolding;
using TrapezoidalRule.DDLManagers;

namespace TrapezoidalRule
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    

    public partial class MainWindow : Window
    {

        private int _numberOfThreads;
        private bool _isImplementedInAsm;
        private CSharpDDLManager _cSharpManager;
        private AsmDDLManager _asmManager;

        public MainWindow()
        {     
            ThreadPool.SetMinThreads(1, 1);
            InitializeComponent();
            ThreadSlider.Value = Convert.ToDouble(Environment.ProcessorCount);
        }

        private void CalculateIntegral(object sender, RoutedEventArgs e)
        {
            double a, b, c, leftRange, rightRange = 0;
            try
            {
                a = Convert.ToDouble(aCoefficient.Text);
                b = Convert.ToDouble(bCoefficient.Text);
                c = Convert.ToDouble(cCoefficient.Text);
                leftRange = Convert.ToDouble(StartRange.Text);
                rightRange = Convert.ToDouble(EndRange.Text);

                _numberOfThreads = Convert.ToInt32(ThreadSlider.Value);
                _isImplementedInAsm = Convert.ToBoolean(checkAsm.IsChecked);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MainPanel.Visibility = Visibility.Hidden;
                BadInput.Visibility = Visibility.Visible;
                return;
            }

            if(leftRange > rightRange)
            {
                var placeholder = leftRange;
                leftRange = rightRange;
                rightRange = placeholder;
            }

            ThreadPool.SetMaxThreads(_numberOfThreads, _numberOfThreads);

            var input = new InputForIntegration(a, b, c, leftRange, rightRange);


            IntegralResult.Text = "Wait for the result, program is being executed.";
            IntegralResult.Foreground = new SolidColorBrush(Colors.Red);
            ExecutionTime.Text = "Wait for the result, program is being executed.";
            ExecutionTime.Foreground = new SolidColorBrush(Colors.Red);
            ChosenDDL.Text = "Loading information.";

            MainPanel.Visibility = Visibility.Hidden;
            Results.Visibility = Visibility.Visible;
            Dispatcher.Invoke((Action)(() => { }), DispatcherPriority.Render);

            if (_isImplementedInAsm)
            {
                ChosenDDL.Text = "Assembler";
                _asmManager = new AsmDDLManager(input);

                var result = _asmManager.CalculateIntegralInAsm();

                IntegralResult.Text = result.CalculatedIntegral.ToString("N3");
                IntegralResult.Foreground = new SolidColorBrush(Colors.Black);
                ExecutionTime.Text = result.ElapsedTime.ToString();
                ExecutionTime.Foreground = new SolidColorBrush(Colors.Black);

                return;
            }         
            else
            {
                ChosenDDL.Text = "C#";
                _cSharpManager = new CSharpDDLManager(input);

                var result = _cSharpManager.CalculateIntegralInCSharp();

                IntegralResult.Text = result.CalculatedIntegral.ToString("N3");
                IntegralResult.Foreground = new SolidColorBrush(Colors.Black);
                ExecutionTime.Text = result.ElapsedTime.ToString();
                ExecutionTime.Foreground = new SolidColorBrush(Colors.Black);
            }
            ChosenDDL.Text = "";
        }
        private void GoBack(object sender, RoutedEventArgs e)
        {
            MainPanel.Visibility = Visibility.Visible;
            Results.Visibility = Visibility.Hidden;
            BadInput.Visibility = Visibility.Hidden;
        }
    }
}
