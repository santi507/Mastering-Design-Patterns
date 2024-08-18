namespace MasteringDesignPatterns.chapter01.Encapsulation;

public class ExtendedPipeline: BasicPipeline, IPipeline, IPostProcessing
{
    public string Type { get; set; }
    
    protected sealed override void Validate(BasicEvent basicEvent)
    {
        var extendedEvent = basicEvent as ExtendedEvent;
        if (extendedEvent == null)
        {
            throw new ArgumentException("This pipeline can process only extended events");
        }

        if (string.IsNullOrWhiteSpace(extendedEvent.GetSource()))
        {
            throw new ArgumentException($"Event {basicEvent.Id} is invalid. Source cannot be null.");
        }

        base.Validate(basicEvent);
    }
    
    public void PostProcessing(BasicEvent basicEvent)
    {
        Console.WriteLine($"Postprocessing of event: {basicEvent.Id}");
    }
}