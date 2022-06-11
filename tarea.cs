
namespace tp07_2022_exequiel1984
{
    public class tarea {
        private int tareaID;
        private string? descripcion;
        private int duracion;

        public int TareaID { get => tareaID; set => tareaID = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        public tarea(){
            tareaID=0;
            descripcion="";
            duracion=0;
        }
        public tarea(int tareaID, string descripcion, int duracion){
            this.TareaID = tareaID;
            if(!string.IsNullOrEmpty(descripcion)) Descripcion = descripcion; else Descripcion = "";
            //this.Descripcion = descripcion;
            this.Duracion = duracion;

        } 

        public void cargarTarea(int i, string descripcion, int duracion){
            this.TareaID = i+1;
            this.Descripcion = descripcion;
            this.Duracion = duracion;
        }

        public void mostrarTarea(){
            System.Console.WriteLine("Tarea: " + TareaID);
            System.Console.WriteLine("Descripcion: " + Descripcion);
            System.Console.WriteLine("Duracion: " + Duracion);
            System.Console.WriteLine("\n");
        }

        public void buscarTarea(string palabraClave){
            
                if (palabraClave == Descripcion){
                        System.Console.WriteLine("Tarea: " + TareaID);
                        System.Console.WriteLine("Descripcion: " + Descripcion);
                        System.Console.WriteLine("Duracion: " + Duracion);
                }    
            
            /* foreach (var TareaRealizada in ListadoTareasRealizadas)
            {
                if (palabraClave == TareaRealizada.Descripcion){
                        System.Console.WriteLine("Tarea: " + TareaRealizada.TareaID);
                        System.Console.WriteLine("Descripcion: " + TareaRealizada.Descripcion);
                        System.Console.WriteLine("Duracion: " + TareaRealizada.Duracion);
                }    
            } */
        }
    }
}