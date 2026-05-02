class Program
{
    static void Main(string[] args)
    {
        IMessageService service = new EmailService(); // choose dependency
        Notification notification = new Notification(service);

        notification.Notify();
    }
}