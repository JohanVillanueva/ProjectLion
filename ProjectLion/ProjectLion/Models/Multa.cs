using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLion.Models
{
    public class Multa
    {
        private int idMulta;

        public int IdMulta
        {
            get { return idMulta; }
            set { idMulta = value; }
        }

        private int idPropietario;

        public int IdPropietario
        {
            get { return idPropietario; }
            set { idPropietario = value; }
        }

        private string placa;

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        private double monto;

        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private DateTime plazo;

        public DateTime Plazo
        {
            get { return plazo; }
            set { plazo = value; }
        }

        private int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string propietario;

        public string Propietario
        {
            get { return propietario; }
            set { propietario = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private string latitud;

        public string Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }

        private string longitud;

        public string Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
    }
}
