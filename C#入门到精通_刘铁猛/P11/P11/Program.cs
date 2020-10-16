using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using P10;



namespace P11
{
    class Program
    {
        static void Main(string[] args)
        {
            var myForm = new Form() { Text = "Hello" };
            var person = new { Name = "Mr.Okay", Age = 34 };

            // Form myForm = new Form() { Text = "Hello" , FormBorderStyle=FormBorderStyle.SizableToolWindow};
            //myForm.ShowDialog();
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.GetType().Name);
        }
    }
}
