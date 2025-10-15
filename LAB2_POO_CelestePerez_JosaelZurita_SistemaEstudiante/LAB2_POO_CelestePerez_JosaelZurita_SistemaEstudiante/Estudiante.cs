using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_POO_CelestePerez_JosaelZurita_SistemaEstudiante
{
    internal class Estudiante
    {
        private string nombre;
        private string id;
        private string carrera;
        private List<Calificacion> calificaciones = new List<Calificacion>();

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Carrera
        {
            get => carrera;
            set => carrera = value;
        }

        public List<Calificacion> Calificaciones
        {
            get => calificaciones;
        }

        public Estudiante(string nombre, string id, string carrera)
        {
            Nombre = nombre;
            Id = id;
            Carrera = carrera;
        }

        public Estudiante() { }

        public double CalcularPromedio()
        {
            if (Calificaciones.Count == 0) return 0;

            double sumaPonderada = 0;
            int totalCreditos = 0;
            foreach (var c in Calificaciones)
            {
                sumaPonderada += c.Nota * c.Materia.Creditos;
                totalCreditos += c.Materia.Creditos;
            }
            return sumaPonderada / totalCreditos;
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine($"[ESTUDIANTE] Nombre: {Nombre}, ID: {Id}, Carrera: {Carrera}, Promedio: {CalcularPromedio():0.00}");
        }
    }
}

