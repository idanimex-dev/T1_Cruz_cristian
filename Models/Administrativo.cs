using System;

namespace POOI_T1_Cruz.Models
{
    public class Administrativo : Empleado
    {
        private int _anioIngreso;
        private bool _postGrado;

        public int anioIngreso { get { return _anioIngreso; } set { _anioIngreso = value; } }
        public bool postGrado { get { return _postGrado; } set { _postGrado = value; } }

        public Administrativo() : base()
        {
            _anioIngreso = DateTime.Now.Year;
            _postGrado = false;
        }

        public double Incentivo()
        {
            if (postGrado == true)
                return 500;

            return 0;
        }

        public override double Bonificacion()
        {
            int aniosServicio = DateTime.Now.Year - anioIngreso;

            if (aniosServicio < 5)
                return 200;
            else if (aniosServicio <= 10)
                return 450;
            else
                return 300;
        }

        public override double MontoAPagar()
        {
            return SueldoBasico() + Escolaridad() + Bonificacion() + Incentivo();
        }
    }
}
