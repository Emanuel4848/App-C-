partial class Program
{
    static void ShowEmployeesInformation()
    {
        //Creo la lista vacia de tipo Eplyee(clase padre):
        List<Employee> empleados = new List<Employee>();

        //fuera, agrego instancias de los hijos a la lista tipo padre:
        empleados.Add(new TeamLeader("Carlos", 5000));
        empleados.Add(new Developer("Ana", 4000));
        empleados.Add(new TeamLeader("Laura", 6000));
        empleados.Add(new Developer("Luis", 3500));

        //Recoro la lista y muestro ShowInfo del padre sobre cada hijo.
         foreach (var empleado in empleados)
        {
            empleado.ShowInfo();
        }

    }

    

}


class Employee
{
    protected string? Name {get; set;}
    protected double Salary {get; set;}
    protected string? Position {get; set;}


    public Employee(string name, double salary, string position)
    {
        Name = name;
        Salary = salary;
        Position = position;
    }
    
    

    public virtual double CalculateBonus()
    {
        return Salary * 0.05;
    }

    public void ShowInfo()
    {
        WriteLine($"Empleado: {Name}, Cargo: {Position}, Salario: {Salary}, Bono: {CalculateBonus():C}");
    }

}

class TeamLeader: Employee
{
    public TeamLeader(string name, double salary): base(name, salary, "TeamLeader"){}

    public override double CalculateBonus()
    {
        return Salary * 0.10;
    }
}

class Developer: Employee
{
    public Developer(string name, double salary): base(name, salary, "Developer"){}

    public override double CalculateBonus()
    {
        return Salary * 0.07;
    }
}