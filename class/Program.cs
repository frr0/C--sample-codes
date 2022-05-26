class Car
{
    string color = "red";
    public string model;  // Create a field

    // Create a class constructor for the Car class
    public Car()
    {
        model = "Mustang"; // Set the initial value for model
    }

    static void Main(string[] args)
    {
        Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
        Car myObj = new Car();


        for (int i = 0; i < 10; i++)
        {
            Console.Write(i + "\n");
        }

        // string userName = Console.ReadLine();
        string userName = "Ciao"; // debug
        Console.WriteLine(userName);
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj.color);
        Console.WriteLine(Ford.model);  // Print the value of model
    }
}
