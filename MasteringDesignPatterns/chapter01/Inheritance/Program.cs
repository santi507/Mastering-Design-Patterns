namespace MasteringDesignPatterns.chapter01.Inheritance;

public class Program
{
    public static void Main()
    {
        BasicPipeline pipeline = new BasicPipeline();

        ExtendedPipeline extendedPipeline = new ExtendedPipeline();

        BasicEvent basicEvent = new BasicEvent
        {
            Id = Guid.NewGuid(),
            Data = "Some Event data"
        };

        ExtendedEvent extEvent = new ExtendedEvent
        {
            Id = Guid.NewGuid(),
            Data = "Some extended event data",
            Source = "Email"
        };

        pipeline.Process(basicEvent);
        Console.WriteLine();
        extendedPipeline.PreProcessing(extEvent);
        extendedPipeline.Process(extEvent);
        extendedPipeline.PostProcessing(extEvent);
    }
}