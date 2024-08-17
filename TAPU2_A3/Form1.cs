using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAPU2_A3
{
    public partial class frmAtraparLetras : Form
    {
        // ---------------- Clase global ----------------
        Random letraAleatoria = new Random();
        // ---------------- Variable global ----------------
        int puntaje = 0;
        int cambioDeVelocidad = 0;
        // ---------------- Cuadro de DialogResult global ----------------
        DialogResult reinicio = new DialogResult();

        // ----------------- Constructor ----------------
        public frmAtraparLetras()
        {
            InitializeComponent();
        }

        // ----------------- Eventos -----------------

        //Creación de un evento tick para el timer donde mostrará las letras que aparecerán en el formulario
        private void tmrMostrarLetras_Tick(object sender, EventArgs e)
        {
            //Se crea una variave char donde se guardarán las letras por medio de una clase random donde trendremos que
            //realizar un "cast" para convertir los numeros generados en letras por medio de su codigo ASCII (las letras
            //en el formulario apaereceran en mayusculas)
            char conversionALetras = (char)(letraAleatoria.Next(65, 90));
            //Se estarán concatenando de manera sucesiva las letras y se grardaran en el label lblLetra en su propiedad 
            //text (se deberá convertir la variable de tipo char a string)
            lblLetra.Text += conversionALetras.ToString();
            //Al inciarse aletoriamente las letras tendran una primera velocidad por default hasta que llegue a 5 ticks
            //por medio deun contador llamado cambio de velocidad que despues de cada tick incrementará su valor
            cambioDeVelocidad += 1;
            //Cuando el cntador cambio de velocidad llegue a 5 las letras cambiarán su velocidad de aparición
            if (cambioDeVelocidad == 5)
            {
                tmrMostrarLetras.Interval = 1000;
                tmrEvaluacion.Interval = 1000;
            }
            //Cuando el cntador cambio de velocidad llegue a 10 las letras cambiarán su velocidad de aparición
            if (cambioDeVelocidad == 10)
            {
                tmrMostrarLetras.Interval = 900;
                tmrEvaluacion.Interval = 900;
            }
            //Cuando el cntador cambio de velocidad llegue a 15 las letras cambiarán su velocidad de aparición
            if (cambioDeVelocidad == 15)
            {
                tmrMostrarLetras.Interval = 800;
                tmrEvaluacion.Interval = 800;
            }

            //Si las letras logran llegar al limite de la parte derecha del formualrio se detendrán, enviando un mensaje
            //de que el juego terminó y la opcion de poder reinciarlo
            if (lblLetra.Right >= ClientSize.Width)
            {
                //Se apaga el evento para tmrEvaluacion
                tmrEvaluacion.Enabled = false;
                //Se pausa el evento de tmrMostrarLEtras
                tmrMostrarLetras.Stop();
                //Se reinicia el texto, las letras precionadas y el puntaje
                lblLetra.Text = "";
                lblTeclaUsuario.Text = "-";
                reinicio = MessageBox.Show("Fin del Juego\nReiniciar", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                lblNumeroPuntaje.Text = "0";
                //Secuencia de evaluación donde sí el usuario decide reiniciar evaluará su respuesta y empezará a
                //acativar todo nuevamente
                if (reinicio == DialogResult.Yes)
                {
                    //Al reiniciar el juego las letras se iniciarán nuevamente y el contador reinicia su valor en 0
                    tmrMostrarLetras.Start();
                    tmrEvaluacion.Enabled = true;
                    cambioDeVelocidad = 0;
                }
            }
        }

        //Se crea un evento keyPress en el formulario la cual guardará las teclas presionadas por el usuario
        private void frmAtraparLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Modificar el lablel lblTeclaUsuario en su propiedad text con la tecla presionada por el usuario
            //(convertir a string la tecla precionada por el usuario guardada por el evento keyPress)
            lblTeclaUsuario.Text = Convert.ToString(e.KeyChar);
        }

        //Se añade otro timer con el evento tick que evalua las teclas presionadas por el usario
        private void tmrEvaluacion_Tick(object sender, EventArgs e)
        {
            //Declaración de una variable utilizada para guardar el valor del label lblLetra en su propiedad text 
            //antes de que se pueda atualizar
            string comparacionTextoAnterior = lblLetra.Text;
            //Creación de una nueva variable para poder eliminar la tecla presionada a tiempo
            string nuevoTexto;
            //Igualar la variable nuevoTexto con el valor del lablel lblLetra en su propiedad text
            nuevoTexto = lblLetra.Text;
            //Obtener el ultimo valor de la cadena de caracteres para que con el metodo TrimEnd obtener y eliminar la
            //ultima letra presionada por el usuario
            nuevoTexto = nuevoTexto.TrimEnd(Convert.ToChar(lblTeclaUsuario.Text));
            //Asignarle el nuevo texto al label lblLetra nn su propiedad text el nuevo valor sin la letra precionada
            lblLetra.Text = nuevoTexto;
            //Secuencia comparatia para determinar si el texto anterior del labl lblLetra guardado en la variable
            //comparacionTextoAnterior con el valor actual del label lblLetra en su propiedad text
            if (comparacionTextoAnterior != lblLetra.Text)
            {
                //En caso de cumplirse la sentencia se aumentará el valor de la variable puntaje 1 unidad para
                //determinar un puntaje de teclas correctas, ademas de también modificar el label lblNumeroPuntaje
                //en su propiedad text con el valor de puntaje (convertir antes a tipo sting lo guardado en la
                //variable puntaje)
                puntaje += 1;
                lblNumeroPuntaje.Text = Convert.ToString(puntaje);
            }
        }
    }
}