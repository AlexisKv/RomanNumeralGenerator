namespace RomanNumberalWeb.Models;

public class Logging
{
    public static Logs Log(string input, string output)
    {
        Logs newLog = new Logs();

        newLog.Input = input;
        newLog.Output = output;
        newLog.TimeCreated = DateTime.Now;

        return newLog;
    }
}