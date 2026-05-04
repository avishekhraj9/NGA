using ReportingSystem.Interfaces;

namespace ReportingSystem.Services;

// Saves report (SRP)
public class ReportSaver : IReportSaver
{
    public void Save(string data)
    {
        Console.WriteLine("Saved: " + data);
    }
}