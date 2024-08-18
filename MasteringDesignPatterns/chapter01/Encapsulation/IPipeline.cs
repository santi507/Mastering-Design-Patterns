namespace MasteringDesignPatterns.chapter01.Encapsulation;

public interface IPipeline
{
    string Type { get; set; }
    void Process(BasicEvent basicEvent);
}