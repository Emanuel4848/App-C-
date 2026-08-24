using TaskMaster;

namespace TaskMaster
{

    partial class Program
    {

        //creaciond eojbetos
        static FileActions<Task> fileActions = new("./06-TaskMaster/tasks.json"); //obtengo tareas
        static List<Task> tasks = fileActions.ReadFile();  //leo la tarea anterior - Ve al json, leelo y devuelve su contenido en una lista Task

        static Queries queries = new(tasks);    //mando las tareas a querys

        public static void TaskMaster()
        {
            bool salir = false;
            while (!salir)
            {
                ForegroundColor = ConsoleColor.White;
                WriteLine("------Menú de tareas------");
                WriteLine("\n1. Listar tareas");
                WriteLine("2. Añadir tarea");
                WriteLine("3. Marcar tarea como completada");
                WriteLine("4. Editar tarea");
                WriteLine("5. Eliminar tarea");
                WriteLine("6. Consultar tareas por estado");
                WriteLine("7. Consultar tarea por descripción");
                WriteLine("8. Salir");
                Write("\nSeleccione una opción: ");

                switch (ReadLine())
                {
                    case "1":
                        queries.ListTasks();
                        break;
                    case "2":
                        AddTask();
                        break;
                    case "3":
                        MarkAsCompleted();
                        break;
                    case "4":
                        EditTask();
                        break;
                    case "5":
                        RemoveTask();
                        break;
                    case "6":
                        //TasksByState();
                        break;
                    case "7":
                        //TasksByDescription();
                        break;
                    case "8":
                        salir = true;
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }


        //dentro de Partial Class en MainTask.cs:
        public static void AddTask()
        {
            try
            {
                var tasks = queries.AddTask();   //invoca a la funcion AddTasks() - Agrega tarea a la lista
                fileActions.WriteFile(tasks);    //Guarda esa tarea en el archivo Json



            }
            catch (Exception ex)
            {
                WriteLine($"Ocurrio un error al añadir la tarea: {ex.Message}");
            }
        }


        public static void MarkAsCompleted()
        {
            try
            {
                var tasks = queries.MarkAsCompleted();   //invoca a la funcion de queries- marcar tarea
                fileActions.WriteFile(tasks);    //Guarda ese cambio en el archivo Json



            }
            catch (Exception ex)
            {
                WriteLine($"Ocurrio un error al marcar la tarea: {ex.Message}");
            }
        }

        public static void EditTask()
        {
            try
            {
                var tasks = queries.EditTask();   //invoca a la funcion de queries- marcar tarea
                fileActions.WriteFile(tasks);    //Guarda ese cambio en el archivo Json



            }
            catch (Exception ex)
            {
                WriteLine($"Ocurrio un error al marcar la tarea: {ex.Message}");
            }
        }

        public static void RemoveTask()
        {
            try
            {
                var task = queries.RemoveTask();
                fileActions.WriteFile(tasks);
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(ex);
                ResetColor();
            }
        }


    }

}

