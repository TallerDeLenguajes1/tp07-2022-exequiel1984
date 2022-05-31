using tp07_2022_exequiel1984;

string descripcion ="";
int duracion;


Random rand = new Random();
List<tarea> tareasPendientes = new List<tarea>();


Console.WriteLine("Ingrese la cantidad de tareas a cargar: ");
int cantidadTareas = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <=  cantidadTareas; i++)
{
    tarea tarea = new tarea();
    Console.WriteLine("Ingrese la descripcion: ");
    descripcion = Console.ReadLine();
    duracion = rand.Next(1, 61);
    tarea.cargarTarea(i, descripcion, duracion);
}



foreach (var tarea in tareasPendientes)
{
    tarea.mostrarTarea();
}