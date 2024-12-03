using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec09_Chart
{
    public partial class UserControlFunction : UserControl
    {
        public event Action FunctionChanged;

        public string FunctionDescription
        {
            get => groupBox.Text;
        }
        public UserControlFunction()
        {
            InitializeComponent();

            numericUpDownABC_ValueChanged(null, null);
        }

        private void numericUpDownABC_ValueChanged(object sender, EventArgs e)
        {
            groupBox.Text = $"f(x) = {numericUpDownA.Value}x² + {numericUpDownB.Value}x + {numericUpDownC.Value}";
            if (FunctionChanged != null)
            {
                FunctionChanged();
            }
        }

        internal double GetValueY(double x)
        {
            return (double)numericUpDownA.Value * x * x +
                   (double)numericUpDownB.Value * x +
                   (double)numericUpDownC.Value;
        }
    }
}
