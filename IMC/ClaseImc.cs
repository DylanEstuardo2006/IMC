using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    internal class ClaseImc
    {
        //Asignamos los atributos
        private string nombre, mensaje_nivel;
        private double estatura;
        private double peso;
        private double sancadas;
        private double pasos;
        private double imc;
        private double distancia_recorrida;
        private double distancia_faltante;

        //Creamos el constructor 
        public ClaseImc()
        {
            nombre = "";
            mensaje_nivel = "";
            estatura = 0f;
            peso = 0f;
            sancadas = 0f;
            pasos = 0f;
            imc = 0f;
            distancia_recorrida = 0f;
            distancia_faltante = 0f;

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double Sancadas
        {
            get { return sancadas; }
            set { sancadas = value; }
        }

        public double Pasos
        {
            get { return pasos; }
            set { pasos = value; }
        }

        public string mensaje_imc
        {
            get { return mensaje_nivel; }
        }
        public double Imc
        {
            get { return imc; }
            set { imc = value; }
        }

        public double Distancia_Recorrida
        {
            get { return distancia_recorrida; }
            set { distancia_recorrida = value; }
        }
        public double Distancia_faltante
        {
            get { return distancia_faltante; }
            set { distancia_faltante = value; }
        }
        public void Calcular_imc()
        {

            imc = peso / (estatura * estatura);
           
        }
        public void Calcular_distancia()
        {
            distancia_recorrida = pasos/100000 * sancadas;
        }
        // Metodos 

        public void calcular_nivel_imc()
        {

               

                if (imc >= 18.55 && imc < 24.9)
                {
                    mensaje_nivel = "Usted se encuentra en su peso normal, necesita caminar un mínimo de 3Km";

                }
                else if (imc >= 24.9 && imc <= 29.9)
                {
                    mensaje_nivel = "Usted se encuentra en sobre peso, necesita caminar un mínimo de 5Km";
                }
                else if (imc >= 30)
                {
                    mensaje_nivel = "Usted se encuentra en obesidad, necesita caminar un mínimo de 10Km";
                }
            
        }
        public void Calcular_distancias()
        {
            if (imc >= 18.55 && imc < 24.9)
            {
                distancia_faltante = 3000f - distancia_recorrida;
            }
            else if (imc >= 24.9 && imc <= 29.9)
            {
                distancia_faltante = 5000f - distancia_recorrida;
            }
            else if (imc >= 30)
            {
                distancia_faltante = 10000f - distancia_recorrida;
            }
        }

        public void MensajeBox_informacion()
        {
           
            
        }
    }
}

