using tp07_2022_exequiel1984;

string descripcion;
int duracion;
string salida = "";
int IdTarea = 1;
string DescripcionTarea;
string ControlTareaRealizada = "";
string PalabraClave = "";
int MinutosTrabajados = 0;

Random rand = new Random();
List<tarea> ListadotareasPendientes = new List<tarea>();
List<tarea> ListadotareasRealizadas = new List<tarea>();

do
{
    System.Console.WriteLine("Ingrese la descripcion de la tarea:");
    DescripcionTarea = Console.ReadLine();

    tarea NuevaTareaPendiente = new tarea();

    NuevaTareaPendiente.TareaID = IdTarea++;
    NuevaTareaPendiente.Descripcion = DescripcionTarea;
    NuevaTareaPendiente.Duracion = rand.Next(1, 61);

    ListadotareasPendientes.Add(NuevaTareaPendiente);

    System.Console.WriteLine("Desea ingresar una nueva tarea (s/n)?");
    salida = Console.ReadLine();
} while (salida != "n");

System.Console.WriteLine("\n-----Listado de tareas pendientes cargadas-----\n");
foreach (var TareaPendiente in ListadotareasPendientes)
{
    TareaPendiente.mostrarTarea();
}

System.Console.WriteLine("\n-----Control de tareas realizadas-----\n");
foreach (var tareaPendiente in ListadotareasPendientes)
{
    System.Console.WriteLine("La tarea " + tareaPendiente.Descripcion + " se realizo (s/n)?");
    ControlTareaRealizada = Console.ReadLine();
    if (ControlTareaRealizada == "s")
    {
        ListadotareasRealizadas.Add(tareaPendiente);
    }
}
ListadotareasPendientes = ListadotareasPendientes.Except(ListadotareasRealizadas).ToList();

System.Console.WriteLine("\n-----Listado de tareas pendientes-----\n");
foreach (var TareaPendiente in ListadotareasPendientes)
{
    TareaPendiente.mostrarTarea();
}

System.Console.WriteLine("\n-----Listado de tareas realizadas-----\n");
foreach (var TareaRealizada in ListadotareasRealizadas)
{
    TareaRealizada.mostrarTarea();
}

System.Console.WriteLine("-----Ingrese la descripcion de la tarea a buscar:");
PalabraClave = Console.ReadLine();
foreach (var tareaPendiente in ListadotareasPendientes)
{
    tareaPendiente.buscarTarea(PalabraClave);
}
foreach (var tareaRealizada in ListadotareasRealizadas)
{
    tareaRealizada.buscarTarea(PalabraClave);
}

foreach (var tareaRealizada in ListadotareasRealizadas)
{
    MinutosTrabajados += tareaRealizada.Duracion;
}
System.Console.WriteLine("\nTotal de minutos trabajados por el empleado: " + MinutosTrabajados);