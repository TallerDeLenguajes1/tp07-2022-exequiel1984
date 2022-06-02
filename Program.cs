using tp07_2022_exequiel1984;

string descripcion;
int duracion;
string salida = "";
int IdTarea = 1;
string DescripcionTarea;
Random rand = new Random();
List<tarea> tareasPendientes = new List<tarea>();


// Console.WriteLine("Ingrese la cantidad de tareas a cargar: ");
// int cantidadTareas = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i <= cantidadTareas; i++)
// {
//     tarea tarea = new tarea();
//     Console.WriteLine("Ingrese la descripcion: ");
//     descripcion = Console.ReadLine();
//     duracion = rand.Next(1, 61);
//     tarea.cargarTarea(i, descripcion, duracion);
// }

do
{
    System.Console.WriteLine("Ingrese la descripcion de la tarea:");
    DescripcionTarea = Console.ReadLine();

    tarea Ntarea = new tarea();

    Ntarea.TareaID = IdTarea++;
    Ntarea.Descripcion = DescripcionTarea;
    Ntarea.Duracion = rand.Next(1, 61);

    tareasPendientes.Add(Ntarea);

    System.Console.WriteLine("Desea ingresar una nueva tarea (s/n)?");
    salida = Console.ReadLine();
} while (salida != "n");


foreach (var tarea in tareasPendientes)
{
    tarea.mostrarTarea();
}