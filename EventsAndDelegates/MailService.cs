
namespace EventsAndDelegates;
internal class MailService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine($"Mail Service: {e.Video.Title} encoded. Sending a mail to user...");
    }
}
