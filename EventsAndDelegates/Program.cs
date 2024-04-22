namespace EventsAndDelegates;
internal class Program
{
    static void Main(string[] args)
    {
        var video = new Video() { Title = "Duel" };
        var videoEncoder = new VideoEncoder();
        videoEncoder.Encode(video);
    }
}
