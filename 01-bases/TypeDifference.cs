partial class Program
{
    static void TypeDifference()
    {
        int x = 5;
        int y = x;
        y = 15;

        Console.WriteLine($"x: {x}, y: {y}");


        Person person1= new Person{Name= "Ema"};
        Person person2= person1;
        person2.Name = "Mar";
    }
}

//clase Person
class Person
{
    public string? Name {get; set;}
}