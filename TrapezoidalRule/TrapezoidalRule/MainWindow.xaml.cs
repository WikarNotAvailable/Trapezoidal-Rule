using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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
using MyCSharpDLL;

namespace TrapezoidalRule
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    

    public partial class MainWindow : Window
    {
        [DllImport(@"C:\Users\wikar\OneDrive\Pulpit\PROGRAMOWANIE\Trapezoidal-Rule\TrapezoidalRule\x64\Debug\MyAsm.dll")]
        static extern int MyProc1(int a, int b);

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
