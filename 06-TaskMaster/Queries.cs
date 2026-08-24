using BetterConsoleTables;

namespace TaskMaster
{
  public class Queries(List<Task> _tasks)
  {
    private List<Task> Tasks = _tasks;

    // Desarrollar métodos para gestionar las tareas 

    //lISTAR TAREAS GET
    public void ListTasks()
    {
      ForegroundColor = ConsoleColor.DarkBlue;
      WriteLine("-----Lista de tareas-----");

      Table table = new Table("Id", "Descripción", "Completado");
      foreach (var task in Tasks)
      {
        table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "");
      }
      table.Config = TableConfiguration.Unicode();

      Write(table.ToString());
      ReadKey();

    }

    //Agregar Tareas
    public List<Task> AddTask()
    {
      try
      {
        //Pedir al usuario la descripcion
        ResetColor();
        Clear();
        WriteLine("----Añadir tarea----");
        WriteLine("Ingrese la descirpcion de la tarea: ");
        var descirption = ReadLine()!;

        Task tareaNueva = new Task(Utils.GenerateId(), descirption);  //crea un ientificador unico globa
        Tasks.Add(tareaNueva);        //agrego la nueva tarea.
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Tarea añaidad con exito");
        ResetColor();
        return Tasks;


      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Error al agregar una tarea: {ex.Message}");
        return Tasks;
      }
    }


    //Marcar una tarea como conpletado
    public List<Task> MarkAsCompleted()
    {

      try
      {
        ResetColor();
        Clear();
        WriteLine("----Marcar tarea como completada----");
        Write("Ingrese el Id de la tarea a marcar como COMPLETADA: ");
        var id = ReadLine()!;


        Task task = Tasks.Find(t => t.Id == id)!;    //creo variable tipo Task, task es la variable, Tasks es la Lista de tareas.
                                                     //guardar en task la tarea que conincida con el id que le paso

        if (task == null)
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("No se encontro una tarea con el Id Proporcionados");
          ResetColor();
          return Tasks;
        }

        task.Completed = true;               //AQUI ya cambio a true
        task.ModifiedAt = DateTime.Now;     //Marcar ultima modificacion
        ForegroundColor = ConsoleColor.Red;
        WriteLine("Tarea marcada como compleda");
        ResetColor();
        return Tasks;


      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Error al marcar una tarea: {ex.Message}");
        return Tasks;
      }

    }


    //Editar una tarea
    public List<Task> EditTask()
    {
      try
      {
        WriteLine("------Editar tarea------");

        //Pido el id de la tarea y verifico
        Write("Ingrese el id de la tarea: ");
        var id = ReadLine();
        Task task = Tasks.Find(t => t.Id == id)!;
        if (task == null)
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("No se encontró una tarea con ese ID");
          ResetColor();
          return Tasks;
        }

        //Pedimos descirpcion
        Write("Ingrse la descripcion de la tarea: ");
        var description = ReadLine()!;

        //Ahora actualizamos la descirpcion
        task.Description = description;
        task.ModifiedAt = DateTime.Now;
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Tarea modificada con exito");
        ResetColor();
        return Tasks;



      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Error al editar una tarea: {ex.Message}");
        ResetColor();
        return Tasks;
      }
    }


    //Eliminar una tarea
    public List<Task> RemoveTask()
    {
      try
      {
        WriteLine("------ELIMINAR TAREA------");

        //Pido el id de la tarea y verifico
        Write("Ingrese el id de la tarea: ");
        var id = ReadLine();
        Task task = Tasks.Find(t => t.Id == id)!;
        if (task == null)
        {
          ForegroundColor = ConsoleColor.Red;
          WriteLine("No se encontró una tarea con ese ID");
          ResetColor();
          return Tasks;
        }
        Tasks.Remove(task);                   //AQUI elimino la tarea, obvio de "Tasks" le paso la tarea que busque con id.
        ForegroundColor = ConsoleColor.Green;
        WriteLine("Tarea eliminada con exito");
        ResetColor();
        return Tasks;



      }
      catch (Exception ex)
      {
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Error al eliminar la tarea: {ex.Message}");
        ResetColor();
        return Tasks;
      }





    }




  }
}
