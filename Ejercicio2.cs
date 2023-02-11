using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Tarea2kelvinRoque20091012959 : Form
    {
        public Tarea2kelvinRoque20091012959()
        {
            InitializeComponent();
        }

        private void buttoncalcular_Click(object sender, EventArgs e)
        {
            double nota_1, nota_2, nota_3, nota_4, promedio;
            string condicion;
            nota_1 = double.Parse(txtnota1.Text);
            nota_2 = double.Parse(txtnota2.Text);
            nota_3 = double.Parse(txtnota3.Text);
            nota_4 = double.Parse(txtnota4.Text);

            promedio = (nota_1 + nota_2 + nota_3 + nota_4) / 4;
            if (promedio < 0)
            {
                condicion = "DESAPROBADO";
                txtpromedio.Text = promedio.ToString("N2");
                txtcondicion.Text = condicion;
            }
            else if (promedio > 15 && promedio <= 20) ;
            {
                condicion = "Aprobado";
                txtpromedio.Text = promedio.ToString("N2");
                txtcondicion.Text = condicion;
            }
        }

        private void buttonlimpiar_Click(object sender, EventArgs e)
        {
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtnota4.Clear();
            txtpromedio.Clear();
            txtcondicion.Clear();
            txtnota1.Focus();
        }
    }
}
