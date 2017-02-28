using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Num_Sum
{
    public partial class calculatorProgressForm : Form
    {
        public calculatorProgressForm()
        {
            InitializeComponent();
        }

        private void calculatorProgressForm_Load(object sender, EventArgs e)
        {
            this.Activate();
        }

        public void changeLabel(string labeltext)
        {
            progressLabel.Text = labeltext;
        }
    }
}
