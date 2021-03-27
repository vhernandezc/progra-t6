using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.clases;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string ruta = "";//acceso privado para la ruta
        clsAutomotor carrito;
        public Form1()
        {
            InitializeComponent();

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            carrito = new clsAutomotor("TESLA", 150);//damos valor a los parametros
            carrito.color = "blanco";
            btnacelerar.Visible = true;//hacemos visibles los botones
            btnencender.Visible = true;
            btnAlto.Visible = true;
            lblestado.Visible = true;
            lblvelocidad.Visible = true;
            lblcambios.Visible = true;

            checkboxparqueo.Checked = true;
            checkBoxdirecto.Visible = true;
            checkBoxneutro.Visible = true;
            checkboxparqueo.Visible = true;
            checkBoxretroceso.Visible = true;


            //mensaje en pantala
            MessageBox.Show($"  {carrito.marca} llega a {carrito.vel_maxima}km/h");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnencender_Click(object sender, EventArgs e)
        {


            //si carrito no está encendido dará un mensaje en pantalla
            if (carrito == null)
            {
                MessageBox.Show("crea el carro primero");
            }
            else
            {
                //si no va a mostrar la marca del carro y encenderá
                lblestado.Text = $"el carro{carrito.marca}:{carrito.encender()}";
            }
            axWindowsMediaPlayer1.Visible = true;
            btncargar.Visible = true;
            btnpausa.Visible = true;
            btnreproducir.Visible = true;
            btnparar.Visible = true;
            lblruta.Visible = true;

        }

        private void acelerar_Click(object sender, EventArgs e)
        {
            if (carrito == null)//si carrito no está encendido mostrará mensaje en pantalla
            {
                MessageBox.Show("crea el carro primero");
            }

            else

            if (checkboxparqueo.Checked)//si el checkbox de parquéo está marcado no se podrá acelerar
            {
                MessageBox.Show("el carro está en parqueo, cambie a Directo o retroceso para acelerar");

            }



            if (checkBoxneutro.Checked)
            {
                MessageBox.Show("el carro está en neutro, cambie a Directo o retroceso para acelerar");
            }
            if (checkBoxdirecto.Checked)
            {
                lblvelocidad.Text = carrito.acelerar();//acelerará el carro
            }
            if (checkBoxretroceso.Checked)
            {
                lblvelocidad.Text = carrito.acelerar();
            }
        }








        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAlto_Click(object sender, EventArgs e)
        {
            lblvelocidad.Text = carrito.detener_marcha();//detiene el carro por completo
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkboxparqueo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxparqueo.Checked)//si un checkbox está marcado los demás estarán sin marcar
            {

                checkBoxneutro.Checked = false;
                checkBoxdirecto.Checked = false;
                checkBoxretroceso.Checked = false;
            }
        }

        private void checkBoxretroceso_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxretroceso.Checked)
            {
                checkBoxneutro.Checked = false;
                checkboxparqueo.Checked = false;
                checkBoxdirecto.Checked = false;

            }
        }

        private void checkBoxneutro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxneutro.Checked)
            {
                checkBoxdirecto.Checked = false;
                checkboxparqueo.Checked = false;
                checkBoxretroceso.Checked = false;
            }
        }

        private void checkBoxdirecto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxdirecto.Checked)
            {
                checkBoxneutro.Checked = false;
                checkboxparqueo.Checked = false;
                checkBoxretroceso.Checked = false;

            }
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)//abrimos openfiledialog
            {
                ruta = openFileDialog1.FileName;//nombre archivo seleccionado
                lblruta.Text = ruta;//muestra la ruta del archivo seleccionado
            }
        }

        private void btnreproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta;//indicamos donde se encuentra lo que vamos a reproducir
            axWindowsMediaPlayer1.Ctlcontrols.play();//abstrae los controles de windows media player
        }

        private void btnparar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void btnpausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
    }
}