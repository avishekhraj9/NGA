namespace ReportingSystem.Models;

// Derived class (can replace base class → LSP)
public class SalesReport : Report
{
    public override string GetContent()
    {
        return "Sales Report Content";
    }
}