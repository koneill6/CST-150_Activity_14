using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int s1 = Int32.Parse(listBox1.SelectedItem.ToString());
            int s2 = Int32.Parse(listBox2.SelectedItem.ToString());

            if (AddCheckBox.Checked)
            {
                AddLabel.Text = (s1 + s2).ToString();
            }

            if (SubtractCheckBox.Checked)
            {
                SubtractLabel.Text = (s1 - s2).ToString();
            }

            if (MultipleRadioButton.Checked)
            {

                MultiDivideLabel.Text = (s1 * s2).ToString();
            }

            if (DivideRadioButton.Checked)
            {
                MultiDivideLabel.Text = (s1 / s2).ToString();
            }

        }
    }
}
