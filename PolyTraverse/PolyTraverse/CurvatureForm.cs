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
    public partial class CurvatureForm : Form
    {
        public CurvatureForm()
        {
            InitializeComponent();
        }

        private void SetCurvature_Click(object sender, EventArgs e)
        {
            try
            {
                PT_CONSTANTS.FIRST = double.Parse(First.Text);
                PT_CONSTANTS.SECOND = double.Parse(Second.Text);
                PT_CONSTANTS.THIRD = double.Parse(Third.Text);
                Close();
            }
            catch
            {
                MessageBox.Show("Ошибка представления данных", "Критерии вытянутости хода");
            }
        }
    }
}
