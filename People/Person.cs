using System;
class Person
{
    public string Name;
    public int TickleTickle;
    public int TickleCount;
    public Person(string name, int ticklethreshold)
    {
        this.Name = name;
        TickleCount = 0;
        TickleTickle = ticklethreshold;

    }
    //TODO: Implement a Speak method
    public void Speak ()
    {
        Console.WriteLine($"Hi my name is {Name}");
    }
    
    
    public void Tickle () 
    {
        if (TickleCount < TickleTickle) 
        {
            Console.WriteLine("He He!");
        }
        else 
        {
            Console.WriteLine("STOP IT");
        }
        TickleCount++;
    }
}