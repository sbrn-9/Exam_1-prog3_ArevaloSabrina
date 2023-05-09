namespace DotnetExam.Entities
{
    public class Materia
    {
        public int MateriaId { get; set; }
        public string Nombre { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public Docente Profesor { get; set; }




        public Materia()
        {
            Alumnos = new List<Alumno>(); 
        }

        public Materia(int ID, string nombre)
        {
          MateriaId = ID;
            Nombre = nombre;
        }




    }
}