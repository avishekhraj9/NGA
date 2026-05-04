namespace ReportingSystem.Models;

// Base abstract class (LSP)
public abstract class Report
{
    // Each report must define its own content
    public abstract string GetContent();
}