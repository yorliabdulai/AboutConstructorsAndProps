using AboutConstructorsAndProps;

class Program
{
    static void Main()
    {
        AbdullaiOrder abdullaiOrder = new AbdullaiOrder(); // Abdullai's instance 
        abdullaiOrder.BikeToWaakye();

        MoOrder moOrder = new MoOrder();
        moOrder.VroomToWaakye();

        Console.ReadKey();
    }
}
