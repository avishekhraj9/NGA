namespace ReportingSystem.Interfaces;

// Responsible only for saving report (SRP)
public interface IReportSaver
{
    void Save(string data);
}