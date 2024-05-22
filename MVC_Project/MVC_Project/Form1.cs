using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_Project
{
    public partial class Form1 : Form
    {
        ControllerParallelepiped controllerParallelepiped = new ControllerParallelepiped();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var a = Convert.ToDouble(textBox1.Text);
                var b = Convert.ToDouble(textBox2.Text);
                var h = Convert.ToDouble(textBox3.Text);
                textBox4.Text = controllerParallelepiped.S(a, b, h).ToString();
                textBox5.Text = controllerParallelepiped.V(a, b, h).ToString();
            }
            catch
            {
                MessageBox.Show("Помилка введення!", "Error");
            }
        }
    }
}
