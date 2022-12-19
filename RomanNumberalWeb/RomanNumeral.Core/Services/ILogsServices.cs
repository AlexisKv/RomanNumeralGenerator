using RomanNumeral.Core.Models;

namespace RomanNumeral.Core.Services;

public interface ILogsServices : IEntityService<Logs>
{
     Task<Logs> Log(string input, string output);
}