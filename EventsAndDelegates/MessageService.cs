namespace EventsAndDelegates;

public class MessageService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine($"Message Service:{e.Video.Title} encoded. Sending an SMS...");
    }
}