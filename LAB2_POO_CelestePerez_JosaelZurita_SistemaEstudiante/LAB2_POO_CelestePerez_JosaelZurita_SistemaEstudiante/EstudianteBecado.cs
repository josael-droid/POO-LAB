using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LAB2_POO_CelestePerez_JosaelZurita_SistemaEstudiante
{
    internal class EstudianteBecado : Estudiante
    {
        private double porcentajeBeca;

        public double PorcentajeBeca
        {
            get => porcentajeBeca;
            set
            {
                if (value < 0 || value > 100) throw new ArgumentException("Porcentaje debe estar entre 0 y 100");
                porcentajeBeca = value;
            }
        }

        public EstudianteBecado(string nombre, string id, string carrera, double porcentajeBeca)
            : base(nombre, id, carrera)
        {
            PorcentajeBeca = porcentajeBeca;
        }

        public double CalcularMatriculaConDescuento(double matriculaBase)
        {
            return matriculaBase * (1 - (PorcentajeBeca / 100.0));
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"[BECADO] Nombre: {Nombre}, ID: {Id}, Carrera: {Carrera}, Promedio: {CalcularPromedio():0.00}, Beca: {PorcentajeBeca}%");
        }
    }
}
