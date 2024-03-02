using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uber_HernandezMatias
{
    class Viaje
    {

        private string Dominio;
        private float Distancia;

        public Viaje()
        {
            this.Dominio = "SIN DATOS";
            this.Distancia = 0;
        }
        public Viaje(string domi, float dist)
        {
            this.Dominio = domi;
            this.Distancia = dist;
        }
        public  static float costoKM { get; set; }
        public static float minKm { get; set; }

        public string getDominio() { return this.Dominio; }
        public void setDominio(string domi)
        {
            this.Dominio = domi;
        }
        public float getDistancia() { return this.Distancia; }
        public void setDistancia(float dist) { this.Distancia = dist; }


        public float Preciofinal()
        {
            float total;
            if (this.getDistancia() < minKm)
            {
                this.setDistancia(minKm);
            }
            total = this.getDistancia() * costoKM;
            return total;
        }

        public string DarDatos()
        {
            string datos;
            datos = "\nDOMINIO\t" + this.getDominio();
            datos += "\nDISTANCIA\t" + this.getDistancia();
            datos += "\nMONTO FINAL\t" + this.Preciofinal();
            return datos;
        }
        public bool Comparar(Viaje otro)//mas caro
        {
            if(this.Preciofinal() < otro.Preciofinal() )
            {
                return true;
            }
            return false;
        }

    }
}
