namespace ExceptionHandling;
internal class Program
{
    static void Main(string[] args)
    {
        //StreamReader streamReader = null;
        try
        {
            var api = new YoutubeApi();
            var videos = api.GetVideos("Javad");
            //Calculator calc = new Calculator();
            //var result = calc.Divide(5, 0);
            //streamReader = new StreamReader(@"D:\Myfile.txt");
            //var content = streamReader.ReadToEnd();
            //throw new Exception("Oppsss");
            //using (var streamReader=new StreamReader(@"D:\Myfile.txt"))
            //{
            //    var content = streamReader.ReadToEnd();
            //}
        }
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("You can not divide by zero.");
        //}
        //catch (ArithmeticException ex) { }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        //finally
        //{
        //    if (streamReader != null)
        //    {

        //        streamReader.Dispose();
        //    }
        //}
    }
}
