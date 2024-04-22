namespace EventsAndDelegates;
internal class Program
{
    static void Main(string[] args)
    {
        var video = new Video() { Title = "Duel" };
        var videoEncoder = new VideoEncoder(); //Publisher
        var mailService = new MailService(); //Subscriber
        var messageService = new MessageService();

        videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
        videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

        videoEncoder.Encode(video);
    }
}