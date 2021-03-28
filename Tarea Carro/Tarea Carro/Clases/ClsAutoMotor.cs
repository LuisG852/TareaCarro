using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Carro.Clases
{
    class ClsAutoMotor
    {
        public String marca { get; }
        public int vel_max { get; }
        public String color { get; set; }

        private int velocidadActual = 0;
        public bool encendido { get; set; } = false;

        public ClsAutoMotor(string marcaCarro, int MAxVel)
        {
            this.vel_max = MAxVel;
            this.marca = marcaCarro;
        }
        public ClsAutoMotor(string marcaCarro, int MaxVel, string colorCarro)
        {
            this.vel_max = MaxVel;
            this.marca = marcaCarro;
            this.color = colorCarro;
        }


        public String Encender()
        {

            if (encendido)
            {
                return "Lo siento el carro ya esta encendido";
            }
            else
            {
                velocidadActual = 0;
                encendido = true;
                return "Listo, pon waze para que te pierdas";
            }



        }

        public string DetenerMarcha()
        {
            if (!encendido)
            {
                return "Enciende El Carro Primero!";

            }
            velocidadActual = 0;
            return "Auto Detenido";
        }


        public string Acelerar()
        {
            if (!encendido)
            {
                return "Enciende el carro primero";
            }
            if (velocidadActual > vel_max)
            {
                velocidadActual = vel_max;
                return $"Parale llegaste a la velocidad maxima {vel_max}Km/h";
            }
            else
            {
                velocidadActual = velocidadActual + 10;


            }
            return $"vas a {velocidadActual}Km/h";
        }
        public string Velocidad()
        {

            string X = "";
            if (!encendido)
            {

                return "Acelera el carro de primero";
            }
            if (velocidadActual == 30)
            {
                X = "2da";

            }
            else if (velocidadActual == 50)
            {
                X = "3ra";

            }
            else if (velocidadActual == 80)
            {
                X = "4ta";

            }
            else if (velocidadActual == 100)
            {
                X = "5ta";
            }

            return X;


        }
        public bool camb()
        {

            bool Y;
            switch (velocidadActual)
            {

                case 20:
                case 40:
                case 70:
                case 90:
                    Y = false;
                    break;
                default:
                    Y = true;
                    break;
            }
            return Y;
        }
        public string Frenar()
        {
            if (!encendido)
            {
                return "Enciende el carro primero";
            }

            else
            {
                velocidadActual = velocidadActual - 20;


            }
            return $"vas a {velocidadActual}Km/h";

        }
    }
}

