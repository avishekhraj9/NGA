using ReportingSystem.Interfaces;

namespace ReportingSystem.Services;

// PDF implementation (OCP)
public class PdfFormatter : IReportFormatter
{
    public string Format(string data)
    {
        return "PDF: " + data;
    }
}