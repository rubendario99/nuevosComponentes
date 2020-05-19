using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaLabelTextbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Text = "Letra: " + e.KeyChar;
            
        }

        private void labelTextbox1_CambiaPosicion(object sender, EventArgs e)
        {
            this.Text=("Posicion: " + Convert.ToInt32(labelTextbox1.Posicion));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelTextbox1.Posicion == NuevosComponentes.LabelTextbox.ePosicion.IZQUIERDA)
            {
                labelTextbox1.Posicion = NuevosComponentes.LabelTextbox.ePosicion.DERECHA;

            }
            else
            {
                labelTextbox1.Posicion = NuevosComponentes.LabelTextbox.ePosicion.IZQUIERDA;

            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            labelTextbox1.Separacion = Convert.ToInt32(textBox1.Text);
        }

        private void labelTextbox1_CambiaSeparacion(object sender, EventArgs e)
        {
            this.Text = "Separación: " + labelTextbox1.Separacion;
        }

        private void labelTextbox1_KeyUp(object sender, KeyEventArgs e)
        {
            this.Text="Tecla: "+e.KeyCode;
        }

        private void labelTextbox1_TxtChanged(object sender, EventArgs e)
        {
            this.Text = "Texto: " + labelTextbox1.TextTxt;
        }

        
    }
}
