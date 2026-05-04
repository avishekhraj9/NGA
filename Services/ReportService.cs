using ReportingSystem.Interfaces;

namespace ReportingSystem.Services;

// High-level module using abstraction (DIP)
public class ReportService
{
    private readonly IReportGenerator _generator;
    private readonly IReportFormatter _formatter;
    private readonly IReportSaver _saver;

    // Constructor Injection (DIP)
    public ReportService(
        IReportGenerator generator,
        IReportFormatter formatter,
        IReportSaver saver)
    {
        _generator = generator;
        _formatter = formatter;
        _saver = saver;
    }

    // Process report
    public string ProcessAndReturn()
    {
        var data = _generator.Generate();       // Generate
        var formatted = _formatter.Format(data); // Format
        _saver.Save(formatted);                 // Save

        return formatted;
    }
}