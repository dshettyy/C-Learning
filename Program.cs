using System;
using System.ComponentModel.DataAnnotations;

class Animal
{
    protected void DisplayAnimal()
    {
        Console.WriteLine("This is Animal Class");
    }
}
class Dog: Animal
{
    public void DisplayDog()
    {
        DisplayAnimal();
        Console.WriteLine("This is Dog Class");
    }
}

class Mainclass
{
    static void Main()
    {
        Dog call = new Dog();
        call.DisplayDog();
    }
}