using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P21_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //  this.button3.Click += this.buttonClicked;
            // this.button3.Click += new EventHandler(buttonClicked);
            //  this.button3.Click += delegate (object sender, EventArgs e)
            //  {
            //      this.textBox1.Text = "Ha Ha !";
            //  };
            //this.button3.Click += (object sender, EventArgs e) => { this.textBox1.Text = "Ho Ho!"; };
            this.button3.Click += (sender, e) => { this.textBox1.Text = "Ho Ho!"; };
        }

        private void buttonClicked(object sender, EventArgs e)
        {
            // this.textBox1.Text = "Hello world";
            if (sender == this.button1)
            {
                this.textBox1.Text = "Hello!";
            }

            if (sender==this.button2)
            {
                this.textBox1.Text = "World!";
            }

            if (sender == this.button3)
            {
                this.textBox1.Text = "It's OK!";
            }
        }
    }
}
