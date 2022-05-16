namespace FlintSoft.Tools.Models;

public class ReturnModel<T>
{
    public bool HasException { get; set; }
    public Exception? Exception { get; set; }
    public T? ReturnedValue { get; set; }
}