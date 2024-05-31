public class CriticalException : AbstractException
{
    public CriticalException(Exception exception) : base(exception, "Something wrong happen please contact with your system administrator", Severity.ERROR)
    {

    }
    public override void LogMessage()
    {
        var current = InnerException;
        do
        {
            current.StackTrace
            current = current InnerException;
        } while(current != null)
    }
}