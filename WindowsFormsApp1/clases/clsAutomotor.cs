using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.clases
{
    class clsAutomotor
    {
        public string marca { get; }
        public int vel_maxima { get;  }
        public string color { get; set; }
        private int vel_actual = 0;
        public bool encendido { get; set; } = false;

        public clsAutomotor(string marcacarro, int max_vel)
        {
            this.vel_maxima = max_vel;
            this.marca = marcacarro;

        }
        public clsAutomotor(string marcacarro, int max_vel, string color_carro)
        {
            this.vel_maxima = max_vel;
            this.marca = marcacarro;
            this.color = color_carro;
        }

        public string encender()

        {
            if (encendido)
            {
                return "el carro ya esta encendido";
            }
            else
            {
                vel_actual = 0;
                encendido = true;
                return "listo, pon waze para que no te pierdas";

            }
        }
        public string detener_marcha()
        {
         if(!encendido)
            {
                return "enciende el carro primero";
            }
            vel_actual = 0;
            return "auto detenido";
        }
        public string acelerar()
        {
            if (!encendido)
            {
                return "enciende el carro primero";
            }
            if (vel_actual > vel_maxima)
            {
                vel_actual = vel_maxima;
                return $"ha llegado al limite de velocidad {vel_maxima}km/h";
            }
            else
            {

                vel_actual = vel_actual + 10;
                return $"vas a {vel_actual}km/h";

            }
           

        }
        
        
    }
}

