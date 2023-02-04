using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class KelvinRoque20091012959 : Form
    {
        public KelvinRoque20091012959()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0, parimpar = 0;
            num = int.Parse(textBox1.Text);
            parimpar = num % 2;

            if (parimpar > 0)
            {
                textBox2.Text = "El Numero Es Impar";

            }

            else
            {
                textBox2.Text = "El Numero Es Par";
            }
        {

        }
    }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
