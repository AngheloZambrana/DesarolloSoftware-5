public class BusinessException : AbstractException
{
    public BusinessException(string message) : base(message, Severity.WARNING)
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