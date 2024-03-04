namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires are on vehicle?");
            int userInput = int.Parse(Console.ReadLine());

            //IVehicle vehicle1 = VehicleFactory.GetVehicle(2);
            //IVehicle vehicle2 = VehicleFactory.GetVehicle(4);
            IVehicle vehicle3 = VehicleFactory.GetVehicle(userInput);

           // vehicle1.Drive(); // Output: Building a new Motorcycle!
            //vehicle2.Drive(); // Output: Building a new Car!
            vehicle3.Drive();
        }
    }
}
