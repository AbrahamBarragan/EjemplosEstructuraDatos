using EjemplosEstructuraDatos;

List<Alumno> lista = new List<Alumno>();

Alumno alumno1 = new Alumno();

alumno1.Nombres = "Isidro";
alumno1.ApellidoPaterno = "Cedeño";
alumno1.Matricula = "453";
alumno1.FechaNacimiento = new DateTime(2008, 09, 13);

Alumno alumno2 = new Alumno();

alumno2.Nombres = "Aldo";
alumno2.ApellidoPaterno = "Lujan";
alumno2.Matricula = "789";
alumno2.FechaNacimiento = new DateTime(2000, 10, 08);

Alumno alumno3 = new Alumno();

alumno3.Nombres = "Fancisco";
alumno3.ApellidoPaterno = "Garza";
alumno3.Matricula = "256";
alumno3.FechaNacimiento = new DateTime(2001, 04, 21);

lista.Add(alumno1);
lista.Add(alumno2);
lista.Add(alumno3);

foreach ( Alumno alumnoEnLista in lista)
{
    Console.WriteLine 
        (
         " Nombre: "
         + alumnoEnLista.NombreCompleto
         + " Matricula: "
         + alumnoEnLista.Matricula
         + " fecha nacimiento: "
         + alumnoEnLista.FechaNacimiento.ToString("dd-MM-yyyy"));
}