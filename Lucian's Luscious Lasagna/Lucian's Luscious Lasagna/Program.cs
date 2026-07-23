class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int actualMinutes) => ExpectedMinutesInOven() - actualMinutes;

    public int PreparationTimeInMinutes(int layers) => layers * 2;

    public int ElapsedTimeInMinutes(int layers, int minutesInOven) => PreparationTimeInMinutes(layers) + minutesInOven;

}

class Program
{
    static void Main()
    {
        var lasagna = new Lasagna();
        Console.WriteLine("Expected Minutes In Oven : " + lasagna.ExpectedMinutesInOven());          // => 40
        Console.WriteLine("Remaining Minutes In Oven : " + lasagna.RemainingMinutesInOven(30));       // => 10
        Console.WriteLine("Preparation Time In Minutes : " + lasagna.PreparationTimeInMinutes(2));      // => 4
        Console.WriteLine("Elapsed Time In Minutes : " + lasagna.ElapsedTimeInMinutes(3, 20));      // => 26
    }
}