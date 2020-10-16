using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    class Cliente
    {

        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido1;

        public string apellido1
        {
            get { return _apellido1; }
            set { _apellido1 = value; }
        }

        private string _apellido2;

        public string apellido2
        {
            get { return _apellido2; }
            set { _apellido2 = value; }
        }

        private string _direccion;

        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private DateTime _FechaNac;

        public DateTime fechaNac

        {
            get { return _FechaNac; }
            set { _FechaNac = value; }
        }

        private int _edad;

        public int edad
        {
            get { return _FechaNac.Year - DateTime.Now.Year; }
            set { _edad = _FechaNac.Year - DateTime.Now.Year; }
        }

        private LinkedList<int> _telefonos;

        public LinkedList<int> telefonos
        {
            get { return _telefonos; }
            set { _telefonos = value; }
        }

        private string _estado;
        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public Cliente(int id, string nombre, string apellido1, string apellido2, string direccion, DateTime fechaNac, LinkedList<int> telefonos, string estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.direccion = direccion;
            this.fechaNac = fechaNac;
            this.edad = edad;
            this.telefonos = telefonos;
            this.estado = estado;
        }

        

    }
}
