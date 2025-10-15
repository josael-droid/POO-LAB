﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_POO_CelestePerez_JosaelZurita_SistemaEstudiante
{
    internal class Calificacion
    {
    private Estudiante estudiante;
        private Materia materia;
        private double nota;

        public Estudiante Estudiante
        {
            get => estudiante;
            set => estudiante = value;
        }

        public Materia Materia
        {
            get => materia;
            set => materia = value;
        }

        public double Nota
        {
            get => nota;
            set
            {
                if (value < 0 || value > 100) throw new ArgumentException("La nota debe estar entre 0 y 100");
                nota = value;
            }
        }

        public Calificacion(Estudiante estudiante, Materia materia, double nota)
        {
            Estudiante = estudiante;
            Materia = materia;
            Nota = nota;
        }

        public double CalcularPuntos()
        {
            return Nota * Materia.Creditos;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"[CALIFICACIÓN] Estudiante: {Estudiante.Nombre}, Materia: {Materia.Nombre}, Nota: {Nota}");
        }
    }

}

