using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowernumberDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pow = 1, fn, sn;
            Console.WriteLine("Enter first number:");
            fn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            sn = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sn; i++)
            {
                pow = pow * fn;
            }
            Console.WriteLine("p=" + pow);
            Console.ReadLine();

            
        }
             
    }
}
