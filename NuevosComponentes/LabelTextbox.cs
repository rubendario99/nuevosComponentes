using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevosComponentes
{
    [
         DefaultProperty("Posicion"),
         DefaultEvent("Load")
    ]

    public partial class LabelTextbox : UserControl
    {
        public LabelTextbox()
        {
            InitializeComponent();
            TextLbl = Name;
            TextTxt = "";
            recolocar();
        }

        //Pixeles de separación entre label y textbox
        private int separacion = 0;
        [Category("Design")]
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    recolocar();
                    CambiaSeparacion?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }



        //Indica donde está la etiqueta respecto al TextBox
        public enum ePosicion
        {
            IZQUIERDA, DERECHA
        }
        private ePosicion posicion = ePosicion.IZQUIERDA;
        [Category("Appearance")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]
        public ePosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosicion), value))
                {
                    posicion = value;
                    recolocar();

                    //añadimos un if dentro del if del set para que salte el evento
                    //cambiar posición cuando no sea nulo

                    //el código que tenemos ahora es una simplificación del anterior posible desde c# 6

                    CambiaPosicion?.Invoke(this, EventArgs.Empty);

                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }
        void recolocar()
        {
            switch (posicion)
            {
                case ePosicion.DERECHA:
                    //Establecemos posición del componente txt
                    txt.Location = new Point(0, 0);
                    //Establecemos ancho del Textbox (la label tiene ancho fijo)
                    txt.Width = this.Width - lbl.Width - Separacion;
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    //Establecemos altura del componente
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
                case ePosicion.IZQUIERDA:
                    lbl.Location = new Point(0, 0);
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    txt.Width = this.Width - lbl.Width - Separacion;
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }

        [Category("Appearance")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                recolocar();
            }
            get
            {
                return lbl.Text;
            }
        }
        [Category("Appearance")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }

        [Category("Appearance")]
        [Description("Sustituye lo escrito por un carácter concreto. Asociado al pswchar de text")]
        public char PswChar
        {
            set
            {
                txt.PasswordChar = value;
            }
            get
            {
                return txt.PasswordChar;
            }
        }

        private void LabelTextbox_SizeChanged(object sender, EventArgs e)
        {
            recolocar();
        }
        private void txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posición cambia")]
        public event System.EventHandler CambiaPosicion;

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la separación cambia")]
        public event System.EventHandler CambiaSeparacion;

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando cambia el texto del txt")]
        public event System.EventHandler TxtChanged;

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
          //  this.OnKeyUp(e);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            TxtChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
