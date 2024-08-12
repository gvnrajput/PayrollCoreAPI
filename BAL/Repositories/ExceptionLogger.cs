using BAL.Interfaces;
using DAL.Models; 

public class ExceptionLogger : IExceptionLogger
{
    private readonly PayrollDbContext _context;
    public ExceptionLogger(PayrollDbContext context)
    {
        _context = context;
    }

    public async Task LogAsync(Exception exception)
    {
        var exceptionLog = new ExceptionLog
        {
            ExceptionMessage = exception.Message,
            StackTrace = exception.StackTrace,
            ExceptionType = exception.GetType().ToString(),
            DateOccurred = DateTime.UtcNow
        };

        _context.ExceptionLogs.Add(exceptionLog);
        await _context.SaveChangesAsync();
    }
}
