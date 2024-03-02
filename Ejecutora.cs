using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uber_HernandezMatias
{
    class Ejecutora
    {
        static void Main(string[] args)
        {
            const int cantViajes = 10;
            Viaje[] Listado = new Viaje[cantViajes];

            Ingreso(Listado);
            Imprimir(Listado);
            darMasCaro(Listado);

            Console.WriteLine("\n\n<fin>");
            Console.ReadKey();
        }
        public static void Ingreso(Viaje[]lista)
        {
            Console.WriteLine("\nING PRECIO POR KM\n");
            float auxPrecioKm = float.Parse(Console.ReadLine());
            Console.WriteLine("\nING KM minimo\n");
            float auxMinKm = float.Parse(Console.ReadLine());
            Viaje.costoKM = auxPrecioKm;
            Viaje.minKm = auxMinKm;

            for (int i=0; i < lista.Length; i++)
            {

                Console.WriteLine("\n\nING DOMINIO\n");
                string auxDominio = Console.ReadLine();
                Console.WriteLine("\nING DISTANCIA\n");
                float auxDistancia = float.Parse(Console.ReadLine());

                lista[i] = new Viaje(auxDominio, auxDistancia);
                
               
            }
        }
        public static void Imprimir(Viaje[]listado)
        {
            Console.WriteLine("\n\nIMPRESION\n");
            foreach(Viaje v in listado)
            {
                Console.WriteLine(v.DarDatos());
            }
        }
        public static void darMasCaro(Viaje[] listado)
        {
            Viaje Caro = listado[0];
            foreach(Viaje v in listado)
            {
                if (Caro.Comparar(v)) Caro = v;//si es verdadero v es mas caro
            }
            Console.WriteLine("\n\nVIAJE MAS CARO=\t"+Caro.DarDatos());
        }
    }
}
