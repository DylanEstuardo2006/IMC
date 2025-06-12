using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class ClaseImc
    {
        //Asignamos los atributos
        private string nombre, mensaje_nivel;
        private float estatura;
        private float peso;
        private float sancadas;
        private float pasos;
        private float imc;
        private float distancia_recorrida;
        private float distancia_faltante;

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

        public float Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }

        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public float Sancadas
        {
            get { return sancadas; }
            set { sancadas = value; }
        }

        public float Pasos
        {
            get { return pasos; }
            set { pasos = value; }
        }

        public string mensaje_imc
        {
            get { return mensaje_nivel; }
        }
        public float Imc
        {
            get { return imc; }
            set { imc = value; }
        }

        public float Distancia_Recorrida
        {
            get { return distancia_recorrida; }
            set { distancia_recorrida = value; }
        }
        public float Distancia_faltante
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
            distancia_recorrida = pasos * sancadas;
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
    }
}

