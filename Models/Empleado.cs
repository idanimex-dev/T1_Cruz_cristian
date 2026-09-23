using System;

namespace POOI_T1_Cruz.Models
{
    public class Empleado
    {
        private string _idEmpleado;
        private string _nomapeEmpleado;
        private string _categoriaEmpleado;
        private int _nHijos;
        private string _tipoContrato;

        public string idEmpleado { get { return _idEmpleado; } set { _idEmpleado = value; } }
        public string nomapeEmpleado { get { return _nomapeEmpleado; } set { _nomapeEmpleado = value; } }
        public string categoriaEmpleado { get { return _categoriaEmpleado; } set { _categoriaEmpleado = value; } }
        public int nHijos { get { return _nHijos; } set { _nHijos = value; } }
        public string tipoContrato { get { return _tipoContrato; } set { _tipoContrato = value; } }

        public Empleado()
        {
            _idEmpleado = "";
            _nomapeEmpleado = "";
            _categoriaEmpleado = "";
            _nHijos = 0;
            _tipoContrato = "";
        }

        public virtual double SueldoBasico()
        {
            double sueldo = 1700;

            if (categoriaEmpleado == "E1")
                sueldo = 5500;
            else if (categoriaEmpleado == "E2")
                sueldo = 2500;
            else if (categoriaEmpleado == "E3")
                sueldo = 2200;

            return sueldo;
        }

        public double Escolaridad()
        {
            return nHijos * 108;
        }

        public virtual double Bonificacion()
        {
            double bonificacion = 0;

            if (tipoContrato == "Indefinido")
                bonificacion = SueldoBasico() * 0.15;
            else if (tipoContrato == "Contratado")
                bonificacion = SueldoBasico() * 0.10;

            return bonificacion;
        }

        public virtual double MontoAPagar()
        {
            return SueldoBasico() + Escolaridad() + Bonificacion();
        }
    }
}
