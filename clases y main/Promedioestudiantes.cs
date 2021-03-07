using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_y_main
{
    class Promedioestudiantes
    {

        int calificacion;
        int promedio;
        int suma = 0;

        public void prom()
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Dame tu calificacion: ");
                calificacion = Convert.ToInt32(Console.ReadLine());

                suma = calificacion + suma;
            }


            promedio = suma / 5;

            Console.WriteLine("El promedio final es: " + promedio);
        }
    }
}
