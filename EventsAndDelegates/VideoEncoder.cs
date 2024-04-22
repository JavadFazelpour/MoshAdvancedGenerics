namespace EventsAndDelegates;

public class VideoEncoder
{
    public void Encode(Video video)
    {
        Console.WriteLine("Encoding video...");
        Thread.Sleep(1500);
    }
}
