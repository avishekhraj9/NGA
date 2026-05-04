using ReportingSystem.Interfaces;
using ReportingSystem.Models;

namespace ReportingSystem.Services;

// Generates report data (SRP)
public class ReportGenerator : IReportGenerator
{
    public string Generate()
    {
        // Using model (LSP)
        Report report = new SalesReport();
        return report.GetContent();
    }
}