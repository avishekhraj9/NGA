using ReportingSystem.Interfaces;

namespace ReportingSystem.Services;

// Excel implementation (OCP)
public class ExcelFormatter : IReportFormatter
{
    public string Format(string data)
    {
        return "Excel: " + data;
    }
}