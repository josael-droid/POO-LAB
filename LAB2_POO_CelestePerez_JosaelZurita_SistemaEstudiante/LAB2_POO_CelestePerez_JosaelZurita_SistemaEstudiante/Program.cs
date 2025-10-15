using LAB2_POO_CelestePerez_JosaelZurita_SistemaEstudiante;

public class Program
{
    public static void Main()
    {
        // Creación de las materias con sus parametros
        Materia m1 = new Materia("Programación", "INF101", 4, 30, 25);
        Materia m2 = new Materia("Matemáticas", "MAT201", 3, 40, 38);
        Materia m3 = new Materia("Física", "FIS301", 2, 35, 20);

        // Crear de obajetos estudiantes con y sin beca
        Estudiante e1 = new Estudiante("Ana Torres", "2025001", "Ingeniería");
        Estudiante e2 = new Estudiante("Luis Gómez", "2025002", "Sistemas");
        EstudianteBecado eb1 = new EstudianteBecado("Carlos Pérez", "2025003", "Electrónica", 50);

        // Crear calificaciones 
        Calificacion c1 = new Calificacion(e1, m1, 85);
        Calificacion c2 = new Calificacion(e2, m2, 90);
        Calificacion c3 = new Calificacion(eb1, m3, 95);

        // Relacionar calificaciones con estudiantes
        e1.Calificaciones.Add(c1);
        e2.Calificaciones.Add(c2);
        eb1.Calificaciones.Add(c3);

        
        //Aqui guaradamos los diferentes objetos estudiantes, materia y calificación
        List<Interface> items = new List<Interface>()
        {
            e1, e2, eb1,
            m1, m2, m3,
            c1, c2, c3
        };

        //Recorre la lista usando la interfaz
        Console.WriteLine("=== DEMOSTRACIÓN DE POLIMORFISMO ===");
        foreach (Interface i in items)
        {
            i.MostrarDatos();
        }

        //operaciones aritméticas
        Console.WriteLine("\n=== RESULTADOS ARITMÉTICOS ===");
        Console.WriteLine($"Promedio {e1.Nombre}: {e1.CalcularPromedio():0.00}");
        Console.WriteLine($"Carga semanal de {m1.Nombre}: {m1.CalcularCargaSemanal(3)} horas");
        Console.WriteLine($"Puntos por calificación de {c1.Estudiante.Nombre} en {c1.Materia.Nombre}: {c1.CalcularPuntos()}");
        Console.WriteLine($"Matrícula con descuento de {eb1.Nombre}: {eb1.CalcularMatriculaConDescuento(1200):0.00} USD");
    }
}