namespace MasteringDesignPatterns.chapter01.Polymorphism;

public class ExtendedPipeline : BasicPipeline
{
    public void PreProcessing(ExtendedEvent extendedEvent)
    {
        WriteLog($"Preprocessing event: {extendedEvent.Id} from {extendedEvent.Source}");
    }

    public void PostProcessing(ExtendedEvent extendedEvent)
    {
        WriteLog($"Postprocessing event: {extendedEvent.Id} from {extendedEvent.Source}");
    }

    protected override void Validate(BasicEvent basicEvent)
    {
        var extendedEvent = basicEvent as ExtendedEvent;
        if (extendedEvent == null)
        {
            throw new ArgumentException("This pipeline can process only extended events");
        }

        if (string.IsNullOrWhiteSpace(extendedEvent.Source))
        {
            throw new ArgumentException($"Event {basicEvent.Id} is invalid. Source cannot be null.");
        }

        base.Validate(basicEvent);
    }
}

public class ExtendedEvent : BasicEvent
{
    public string Source { get; set; }
}