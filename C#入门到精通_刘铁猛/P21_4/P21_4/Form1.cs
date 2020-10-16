using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P21_4
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
            this.myButton.Click += MyButton_Click;
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            this.myTextBox.Text = "Hello, World!";
        }
    }
}
