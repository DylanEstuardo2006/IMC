using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        private ClaseImc imc;
        public Form1()
        {
            imc = new ClaseImc();

            InitializeComponent();
            CultureInfo cultura = new CultureInfo("es-MX"); // Ajusta según tu necesidad
            CultureInfo.DefaultThreadCurrentCulture = cultura; 
            CultureInfo.DefaultThreadCurrentUICulture = cultura;
        }

        private void btn_messagebox_calculos_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_estatura.Text) || string.IsNullOrEmpty(txt_sancadas.Text) || string.IsNullOrEmpty(txt_peso.Text) || string.IsNullOrEmpty(txt_pasos.Text))
            {

                MessageBox.Show("Datos vacios","ALERTA");
            }
            else
            {
                imc.Nombre = txt_nombre.Text;
                imc.Sancadas = (double.Parse(txt_sancadas.Text));
                imc.Estatura = (double.Parse(txt_estatura.Text));
                imc.Peso = (double.Parse(txt_peso.Text));
                imc.Pasos = double.Parse(txt_pasos.Text);


                imc.Calcular_imc();
                imc.calcular_nivel_imc();
                imc.Calcular_distancia();
                imc.Calcular_distancias();


                MessageBox.Show("Su IMC es: " + imc.Imc + "\n" + imc.mensaje_imc + "\n Usted a recorrido: " + imc.Distancia_Recorrida + "m" + "\n Usted le faltan: " + imc.Distancia_faltante + "m", imc.Nombre);
            }

            // Vamos a ver que me sale si lo modifico
           
            
        }
       private void txt_estatura_TextChanged(object sender, EventArgs e)
       {

       }

        private void txt_estatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) // <--- Es una condición que compara si el valor es número o digito alfabetico.
            {
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != '.')// <---- En pocas palabras verifica si es la tecla regresar y deja que se ejecute.
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_peso_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) // <--- Es una condición que compara si el valor es número o digito alfabetico.
            {
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != '.') // <---- En pocas palabras verifica si es la tecla regresar y deja que se ejecute.
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_sancadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) // <--- Es una condición que compara si el valor es número o digito alfabetico.
            {
                if (e.KeyChar != (char)Keys.Back) // <---- En pocas palabras verifica si es la tecla regresar y deja que se ejecute.
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_pasos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) // <--- Es una condición que compara si el valor es número o digito alfabetico.
            {
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != '.') // <---- En pocas palabras verifica si es la tecla regresar y deja que se ejecute.
                {
                    e.Handled = true;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
