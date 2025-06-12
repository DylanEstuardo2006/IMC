using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void btn_messagebox_calculos_Click(object sender, EventArgs e)
        {
            imc.Nombre = txt_nombre.Text;
            imc.Sancadas = (float.Parse(txt_sancadas.Text));
            imc.Estatura = (float.Parse(txt_estatura.Text));
            imc.Peso = (float.Parse(txt_peso.Text));
            imc.Pasos = float.Parse(txt_pasos.Text);


            imc.Calcular_imc();
            imc.calcular_nivel_imc();
            imc.Calcular_distancia();
            imc.Calcular_distancias();

            MessageBox.Show("Su IMC es: " + imc.Imc + "\n" + imc.mensaje_imc + "\n Usted a recorrido: " + imc.Distancia_Recorrida + "m" + "\n Usted le faltan: " + imc.Distancia_faltante + "m", imc.Nombre);
        }
    }
}
