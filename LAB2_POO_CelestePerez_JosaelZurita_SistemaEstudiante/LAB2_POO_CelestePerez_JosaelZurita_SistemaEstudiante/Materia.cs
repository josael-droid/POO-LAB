using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_POO_CelestePerez_JosaelZurita_SistemaEstudiante
{
    internal class Materia
    {
        private string nombre;
        private string codigo;
        private int creditos;
        private int cupos;
        private int inscritos;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Codigo
        {
            get => codigo;
            set => codigo = value;
        }

        public int Creditos
        {
            get => creditos;
            set
            {
                if (value <= 0) throw new ArgumentException("Créditos debe ser > 0");
                creditos = value;
            }
        }


        public int Cupos
        {
            get => cupos;
            set
            {
                if (value < 0) throw new ArgumentException("Cupos no puede ser negativo");
                cupos = value;
            }
        }
        public int Inscritos
        {
            get => inscritos;
            set
            {
                if (value < 0 || value > Cupos) throw new ArgumentException("Inscritos inválido");
                inscritos = value;
            }
        }
        public Materia(string nombre, string codigo, int creditos, int cupos = 0, int inscritos = 0)
        {
            Nombre = nombre;
            Codigo = codigo;
            Creditos = creditos;
            Cupos = cupos;
            Inscritos = inscritos;
        }

        public int CalcularCargaSemanal(int horasPorCredito)
        {
            return Creditos * horasPorCredito;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"[MATERIA] Nombre: {Nombre}, Código: {Codigo}, Créditos: {Creditos}, Cupos: {Cupos}, Inscritos: {Inscritos}");
        }


    }
}
