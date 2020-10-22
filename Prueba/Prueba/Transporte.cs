using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public abstract class Transporte : IAvanzar
    {
        #region Atributos

        private int cantPasajeros;

        #endregion

        #region Constructor

        public Transporte(int cantPasajeros)
        {
            this.cantPasajeros = cantPasajeros;
        }

        #endregion

        #region Metodos
        public int CantPasajeros
        {
            get { return this.cantPasajeros; }
        }
        public virtual string Ocupante()
        {
            return "";
        }
        public virtual string Detener()
        { 
        return "Frenar";
        }
        public virtual string Avanzar()
        {
            return "Avanzar";
        }

        #endregion
    }
}
