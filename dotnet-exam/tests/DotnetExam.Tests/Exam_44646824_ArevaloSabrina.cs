using DotnetExam.Entities;
using Xunit;

using System.Globalization;
using System.Runtime;




namespace DotnetExam.Tests
{
    public class Exam_44646824_ArevaloSabrina
    {
        [Fact]
        public void Test1_Teoria_NET()
        {

            //Describa la diferencia entre .NET Framework y .NET Core
           
            var respuesta = "La principal diferencia que hay entre .NET Framework y .NET Core está en el alcance que " +
                "tiene cada uno. .NET Core es multiplataforma, pudiendose utilizar en plataformas windows, linux y mac, " +
                "caso contrario, .NET Framework solo se puede utilizar en Windows";

            Assert.NotEqual(string.Empty, respuesta);


        }

        [Fact]
        public void Test2_Teoria_Assembly()
        {


            //Describa que es un assembly o ensamblado en .NET
            var respuesta = "Un ensamblado en .NET es una biblioteca que contiene collecciones de recursos compilados que se utilizaran posteriormente en los proyectos";

            Assert.NotEqual(string.Empty, respuesta);


        }


        [Fact]
        public void Test3_Teoria_IL()
        {


            //Describa que es el Lenguaje Intermedio o IL
            var respuesta = "El lenguaje intermedio o IL es es la base para crear entornos de ejecución y desarrollo, todo esto para que los lenguajes y las bibliotecas puedan funcionar juntos.";

            Assert.NotEqual(string.Empty, respuesta);


        }




        [Fact]

        public void Test4_DateTime_Formatting()
        {
           

            var finalWorldCupMatch = new DateTime(2022, 12, 18, 15, 30, 23);


            Assert.Equal("18/12/22 15:30:23", finalWorldCupMatch.ToString("dd/MM/yy HH:mm:ss"));
            Assert.Equal("18/12/22 03:30 p. m.", finalWorldCupMatch.ToString("dd/MM/yy hh:mm \\p. \\m\\."));
            Assert.Equal("18 de diciembre de 2022", finalWorldCupMatch.ToString("dd \\de MMMM \\de yyyy"));


        }

        [Fact]
        public void Test5_DateTime_Days()
        {


            var finalWorldCupMatch = new DateTime(2022, 12, 18, 15, 30, 23);
            var today = new DateTime(2023, 5, 9, 15, 00, 00);

            var diferencia = today.Subtract(finalWorldCupMatch);

            var result = $"{diferencia.Days} Días totales desde la final del mundo";

            Assert.Equal("141 Días totales desde la final del mundo", result );

        }

        [Fact]
        public void Test6_POO_Materia()
        {
            var materia = new Materia(123456, "Programacion III");

            Assert.Equal("Programacion III", materia.Nombre);
            Assert.Equal(123456, materia.MateriaId);

        }


       [Fact]
        public void Test7_POO_Alumno()
        {
            var alumno = new Alumno();

            alumno.AlumnoId = 123456;
            alumno.Legajo = "000010/22";
            alumno.Nombre = "Lionel";
            alumno.Apellido = "Messi";


            Assert.Equal(123456, alumno.AlumnoId);
            Assert.Equal("000010/22", alumno.Legajo);
            Assert.Equal("Lionel Messi", alumno.NombreCompleto);
        }



       

       [Fact]
        public void Test8_POO_UML()
        {
            //En base al diagrama UML del examen
            //Codifique las clases e interfaces necesarias

            var docente = new Docente(1, "Lionel", "Scaloni");

            var alumno1 = new Alumno();


            var alumno2 = new Alumno();


            var materia = new Materia(1, "Programacion ")
            {
                Profesor = docente
            };
            
            materia.Alumnos.Add(alumno1);
            materia.Alumnos.Add(alumno2);

            materia.Profesor.Id = 1;
            materia.Profesor.DocenteId = 1;
            materia.Profesor.Nombre = "Lionel";
            materia.Profesor.Apellido = "Scaloni";


          
            materia.Alumnos[1].Id = 777;
            materia.Alumnos[1].AlumnoId = 777;
            materia.Alumnos[1].Legajo = "000007/22";
            materia.Alumnos[1].Nombre = "Rodrigo";
            materia.Alumnos[1].Apellido = "De Paul";
            materia.Alumnos[0].Id = 101010;
            materia.Alumnos[0].Legajo = "101010";
            materia.Alumnos[0].AlumnoId = 101010;
            materia.Alumnos[0].Nombre = "Lionel";
            materia.Alumnos[0].Apellido = "Messi";

            Assert.Equal("Programacion III", materia.Nombre);
            Assert.Equal(123456, materia.MateriaId);

            Assert.Equal(1, materia.Profesor.Id);
            Assert.Equal(1, materia.Profesor.DocenteId);
            Assert.Equal("Lionel", materia.Profesor.Nombre);
            Assert.Equal("Scaloni", materia.Profesor.Apellido);

            Assert.Equal(101010, materia.Alumnos.First().Id);
            Assert.Equal("101010", materia.Alumnos.First().Legajo);
            Assert.Equal(101010, materia.Alumnos.First().AlumnoId);
            Assert.Equal("Lionel", materia.Alumnos.First().Nombre);
            Assert.Equal("Messi", materia.Alumnos.First().Apellido);

            Assert.Equal(777, materia.Alumnos.Last().Id);
            Assert.Equal(777, materia.Alumnos.Last().AlumnoId);
            Assert.Equal("000007/22", materia.Alumnos.Last().Legajo);
            Assert.Equal("Rodrigo", materia.Alumnos.Last().Nombre);
            Assert.Equal("De Paul", materia.Alumnos.Last().Apellido);

        }


        /*    [Fact]
            public void Test9_Collection_GetCountFirtLast()
            {
                //Utilice la coleccion del trabajo practico que presento
                //Para poder con el generador completar dicha coleccion
                //y buscar las primeras materias y primeros y ultimos alumnos
                var materias = new List<Materia>();

                materias.AddRange(MateriaGenerador.Generar(10000, 1000));

                Assert.Equal(10000, materias.Count);

                Assert.Equal(1000, materias.First().Alumnos.Count);
                Assert.Equal("M1-000001/23", materias.First().Alumnos.First().Legajo);
                Assert.Equal("M1-001000/23", materias.First().Alumnos.Last().Legajo);

                Assert.Equal(1000, materias.Last().Alumnos.Count);
                Assert.Equal("M10000-000001/23", materias.Last().Alumnos.First().Legajo);
                Assert.Equal("M10000-001000/23", materias.Last().Alumnos.Last().Legajo);

            }


            [Fact]
            public void Test10_Linq_BuscarLegajo()
            {
                //Busque los alumnos en las materias que contengan el legajo 000999
                //Utilice la coleccion del trabajo practico que presento
                var materias = new List<Materia>();

                materias.AddRange(MateriaGenerador.Generar(10000, 1000));

                //Ayuda: where a.Legajo.Contains("000999/23")
                var query = null;

                Assert.Equal(1000, query.ToList().Count);

            }

            */
    }
}