namespace ReportingSystem.Interfaces;

// Used to extend formats without modifying code (OCP)
public interface IReportFormatter
{
    string Format(string data);
}