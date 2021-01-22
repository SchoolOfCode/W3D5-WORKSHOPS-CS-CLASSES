using System;
class Person
{
    public string Name;
    public int TickleTickle;
    public int TickleCount;
    //declare a field for food
    public string Food;
    public Person(string name, int ticklethreshold, string food)
    {
        this.Name = name;
        TickleCount = 0;
        TickleTickle = ticklethreshold;
        Food = food;

    }
    //TODO: Implement a Speak method
    public void Speak()
    {
        Console.WriteLine($"Hi my name is {Name}");
    }


    public void Tickle()
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

    // adding a new behaviour
    public void Eat()
    {
        Console.WriteLine($"This {Food} is so good!");
    }
}