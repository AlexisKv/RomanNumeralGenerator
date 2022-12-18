using RomanNumeral.Core.Models;
using RomanNumeral.Core.Services;
using RomanNumeral.Data;

namespace RomanNumeral.Services;

public class LogsServices : EntityService<Logs>, ILogsServices
{
    public LogsServices(IRomanNumeralDbContext context) : base(context)
    {
    }
    
    public async Task<Logs> Log(string input, string output)
    {
        Logs newLog = new Logs();
        
        newLog.Input = input;
        newLog.Output = output;
        newLog.TimeCreated = DateTime.Now;

        Create(newLog);
        await _context.SaveChangesAsync();
        
        return newLog;
    }

   
}