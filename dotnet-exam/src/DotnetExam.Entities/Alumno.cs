using DotnetExam.ConsoleApp;

namespace DotnetExam.Entities
{
    public class Alumno:Persona
    {
        public int AlumnoId { get; set; }
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Alumno()
        {
        
        }

        public string NombreCompleto { 
            get { 
                return $"{Nombre} {Apellido}";
            } 
        }

        public override string ToString()
        {
            return NombreCompleto;
        }

    }
}