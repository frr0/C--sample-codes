// See https://aka.ms/new-console-template for more information

public class Program
{

    static void Main(string[] args)
    {
        Car car = new Car("Bianco", "Tesla");
        Owner owner = new Owner("Pippo", "Rossi");

        // To display are of the Rectangle
        Console.WriteLine("The car is " + car._color + " kind " + car._brand + "\nThe owner is " + owner._name + " " + owner._lastname);
    }
}
