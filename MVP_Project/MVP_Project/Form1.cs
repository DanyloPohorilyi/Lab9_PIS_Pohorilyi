using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Project
{
    public partial class Form1 : Form, IParallelepipedView
    {
        private ParallelepipedPresenter presenter;
        public Form1()
        {
            InitializeComponent();
            presenter = new ParallelepipedPresenter(this, new Parallelepiped());
        }
        void IParallelepipedView.SetS(double S)
        {
            textBox5.Text = S.ToString();
        }

        void IParallelepipedView.SetV(double V)
        {
            textBox4.Text = V.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.LoadParallelepiped(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));

        }
    }
}
