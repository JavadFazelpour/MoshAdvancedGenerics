namespace EventsAndDelegates;

public class VideoEncoder
{
    // 1. Define a delegate (It is the contract or agreement between publisher and subscribers.)
    // 2. Define an event based on that delegate.
    // 3. Raise (Publish) the event (We need a method that is responsible for raising an event ).

    // 1. Delegate
    public delegate void VideoEncodedEventHandler(object sender, VideoEventArgs eventArgs);

    // 2. Event based on delegate
    public event VideoEncodedEventHandler VideoEncoded;

    public void Encode(Video video)
    {
        Console.WriteLine("Encoding video...");
        Thread.Sleep(1500);

        // 4. Calling the method that raise the event.
        OnVideoEncoded(video);
    }
    // 3. Method that raise the event.
    protected virtual void OnVideoEncoded(Video video)
    {
        if (VideoEncoded !=null)
        {
            VideoEncoded(this, new VideoEventArgs() { Video=video});
        }
    }
}
