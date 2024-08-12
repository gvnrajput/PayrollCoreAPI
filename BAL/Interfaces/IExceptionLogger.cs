namespace BAL.Interfaces
{
    public interface IExceptionLogger
    {
        Task LogAsync(Exception exception);
    }
}
