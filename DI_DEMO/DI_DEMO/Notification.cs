public class Notification
{
    private IMessageService _messageService;

    // Constructor Injection
    public Notification(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Notify()
    {
        _messageService.Send();
    }
}