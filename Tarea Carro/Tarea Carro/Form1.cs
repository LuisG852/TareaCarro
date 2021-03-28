using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_Carro.Clases;

namespace Tarea_Carro
{
    public partial class labelEstadoVelocidad : Form
    {
        ClsAutoMotor carrito;
        public labelEstadoVelocidad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutoMotor("Meches",130);
            carrito.color = "rojo";

            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max}Km/h");
            buttonAcelerar.Visible = true;
            buttonEncender.Visible = true;
            buttonParar.Visible = true;
            CMB.Visible = true;
            buttonFrenar.Visible = true;           
        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            buttonAcelerar.Visible = true;
            if (carrito == null)
            {
                MessageBox.Show("Crea el carro primero");
            }else
            {
                
                labelEstado.Text = $"el carro {carrito.marca}  : {carrito.Encender()}";
            }
            BMW.Visible = false;
            button1.Visible = false;
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            buttonAcelerar.Visible = carrito.camb();
            if (carrito == null)
                {
                    MessageBox.Show("Crea el carro primero");
                }
                else
                {
                    labelEstadoVelocidadr.Text = carrito.Acelerar();
                }     
            
              
        }

        private void BMW_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutoMotor("BMW", 200);
            carrito.color = "Blanco";

            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max}Km/h");
            buttonAcelerar.Visible = true;
            buttonEncender.Visible = true;
            buttonParar.Visible = true;
            CMB.Visible = true;
            buttonFrenar.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidadr.Text = carrito.DetenerMarcha();

            

        }

        private void CMB_Click(object sender, EventArgs e)
        {
            buttonAcelerar.Visible = carrito.camb();
            buttonAcelerar.Show();
            labelCambio.Text = carrito.Velocidad();
        }

        private void buttonFrenar_Click(object sender, EventArgs e)
        {
            buttonFrenar.Visible = carrito.camb();
            if (carrito == null)
            {
                MessageBox.Show("Crea el carro primero");
            }
            else
            {
                labelEstadoVelocidadr.Text = carrito.Frenar();
            }
        }

    }
    }
