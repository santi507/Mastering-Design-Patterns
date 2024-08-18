namespace MasteringDesignPatterns.chapter01.Encapsulation;

public class ExtendedEvent: BasicEvent
{
    private string source;

    public ExtendedEvent()
    {
        this.source = "EMAIL";
    }

    public string GetSource()
    {
        return this.source;
    }

    public void SetSource(string strValue)
    {
        if (!string.IsNullOrWhiteSpace(strValue))
        {
            if (strValue == "EMAIL" || strValue == "MSG")
            {
                this.source = strValue;
            }
        }
    }
}