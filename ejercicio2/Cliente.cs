using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace operacionesBancarias.dominio
{
    class Cliente:IComparable<Cliente>
    {
        // Atributos para datos
        private String primerNombre;
        private String apellido;
        // Atributos para la agregación
        private ArrayList cuentas;
        private int numeroDeCuentas = 0;

        public Cliente(String p, String a)
        {
            primerNombre = p;
            apellido = a;
            cuentas = new ArrayList();
        }

        public void AgregaCuenta(Cuenta cta)
        {
            //int i = numeroDeCuentas++;
            cuentas.Add(cta);
            numeroDeCuentas = cuentas.Count;
        }
        public Cuenta GetCuenta(int indiceCuenta)
        {
            return (Cuenta) cuentas[indiceCuenta];
        }

        public String PrimerNombre
        {
            get
            {
                return primerNombre;
            }
        }
        public String Apellido
        {
            get
            {
                return apellido;
            }
        }
        public int NumeroDeCuentas
        {
            get
            {
                return numeroDeCuentas;
            }
        }

        public int CompareTo(Cliente other)
        {
            int aux = 1;
            if (other == null) return aux;
            aux = this.Apellido.CompareTo(other.Apellido);
            if (aux != 0) return aux;
            aux = this.primerNombre.CompareTo(other.PrimerNombre);
            if (aux != 0) return aux;
            return 0;
        }
    }
}
