using DotnetExam.ConsoleApp;

namespace DotnetExam.Entities
{
    public class Docente:Persona
    {
        public int DocenteId { get; set; }
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int Id { get; set; }


        public Docente(int ID, string nombre, string apellido)
        {
            DocenteId = ID;
            Legajo = nombre;
            Nombre = apellido;

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