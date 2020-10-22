using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
   
        public class Avion : Transporte
        {
            public override string Detener()
            {
                return "Frenar";
            }
        public Avion(int cantPasajeros) : base(cantPasajeros) { }

        public override string Ocupante()
        {
            return this.CantPasajeros + " pasajeros";
        }

    }



    }

