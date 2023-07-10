namespace PropertyGuru.FastKey.Utilities
{
    public interface IMailService
    {
        Task<bool> SendAsync(MailData mailData, CancellationToken ct);
     
    }
}