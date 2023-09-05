using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car carOne = new Car("Jeep", "Cherokee", 2001);           
            Console.WriteLine($"Your car make is {carOne.Make}, the model is {carOne.Model}, and the year is {carOne.Year}!");
                
        }
    } 
}
