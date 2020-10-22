using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            #region aviones
            List<Avion> aviones = new List<Avion>();

            aviones.Add(new Avion(100));
            aviones.Add(new Avion(30));
            aviones.Add(new Avion(10));
            aviones.Add(new Avion(20));
            aviones.Add(new Avion(80));

            

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("En el avion " + (i + 1) + " hay: " + aviones[i].Ocupante());

            }
            //Console.ReadKey();

            #endregion aviones

            #region Auto
            List<Auto> Automoviles = new List<Auto>();

            Automoviles.Add(new Auto(3));
            Automoviles.Add(new Auto(2));
            Automoviles.Add(new Auto(3));
            Automoviles.Add(new Auto(4));
            Automoviles.Add(new Auto(1));

            for (int c = 0; c < 5; c++)
            {

                Console.WriteLine("En el automovil " + (c + 1) + " hay: " + Automoviles[c].Ocupante());

            }
            Console.ReadKey();
            #endregion Auto
        }
    }
}