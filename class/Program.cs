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
    Console.WriteLine(myObj.color);
    Console.WriteLine(Ford.model);  // Print the value of model
  }
}