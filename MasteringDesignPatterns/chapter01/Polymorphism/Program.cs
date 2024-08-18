namespace MasteringDesignPatterns.chapter01.Polymorphism;

public class Program
{
    public static void Main()
    {
        BasicPipeline pipeline = new BasicPipeline();
        BasicPipeline extendedPipeline = new ExtendedPipeline();

        BasicEvent basicEvent = new BasicEvent
        {
            Id = Guid.NewGuid(),
            Data = "Some data"
        };

        ExtendedEvent extendedEvent = new ExtendedEvent
        {
            Data = "Some data",
            Id = Guid.NewGuid(),
            Source = "Console App"
        };

        pipeline.Process(basicEvent);
        extendedPipeline.Process(extendedEvent);
        extendedPipeline.Process(basicEvent);
    }
}