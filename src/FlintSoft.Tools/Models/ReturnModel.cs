namespace FlintSoft.Tools.Models;

public class ReturnModel<T>
{
    public bool HasException { get; set; }
    public Exception? Exception { get; set; }
    public T? ReturnedValue { get; set; }

    public ReturnModel(T returnedValue, Exception? ex = null)
    {
        ReturnedValue = returnedValue;
        if(ex != null)
        {
            Exception = ex;
            HasException = true;
        }
    }
}