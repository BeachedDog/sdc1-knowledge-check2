internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<BowlingBall>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var bowlingBall = new BowlingBall();

            Console.WriteLine("Enter the manufacturer's name: ");
            bowlingBall.Manufacturer = Console.ReadLine();

            Console.WriteLine("Enter the bowling ball's name: ");
            bowlingBall.Name = Console.ReadLine();

            Console.WriteLine("Is the ball Asymetric? (Type 'yes' if true)  ");
            bowlingBall.IsAsymetric = Console.ReadLine().ToLower() == "yes";

            Console.WriteLine("Enter the weight of the ball:");
            bowlingBall.Weight = int.Parse(Console.ReadLine());

            recordList.Add(bowlingBall);
        }

        foreach (var record in recordList)
        {
            Console.WriteLine(record.ToString());
        }
        // Print out the list of records using Console.WriteLine()
    }
}