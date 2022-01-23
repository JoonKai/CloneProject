using CloneLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace CloneConLibrary.Arrow
{
    /// <summary>
    /// CircleBaseArrow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CircleBaseArrow : UserControl
    {
        public int ArrowHeight { get; set; }
        public int ArrowHeaderLength { get; set; }
        public int ArrowHeaderHeight { get; set; }

        public CircleBaseArrow()
        {
            InitializeComponent();
            this.ArrowHeight = 10;
            this.ArrowHeaderHeight = 20;
            this.ArrowHeaderLength = 20;
        }
        public void SetLocation(double x0, double y0, double x1, double y1)
        {
            //double num1 = Helper.Math.Distance();
        }
    }
}
