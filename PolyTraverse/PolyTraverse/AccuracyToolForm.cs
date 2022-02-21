using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyTraverse
{
    public partial class AccuracyToolForm : Form
    {
        public AccuracyToolForm()
        {
            InitializeComponent();
        }

        private void SetAccuracy_Click(object sender, EventArgs e)
        {
            try
            {
                PT_CONSTANTS.ACCURACY_ANGLE = double.Parse(AccuracyAngle.Text);
                PT_CONSTANTS.ACCURACY_LENGTH_FIRST = double.Parse(AccuracyLengthFirst.Text);
                PT_CONSTANTS.ACCURACY_LENGTH_SECOND = double.Parse(AccuracyLengthSecond.Text);
                Close();
            }
            catch
            {
                MessageBox.Show("Ошибка представления данных", "Точность инструмента");
            }
        }
    }
}
