
namespace Delegates;
internal class Program
{
    static void Main(string[] args)
    {
        var processor = new PhotoProcessor();
        var filters = new PhotoFilters();

        Action<Photo> filterHandler = filters.ApplyBrightness;

        filterHandler += filters.ApplyContrast;
        filterHandler += RemoveRedEye;
        filterHandler += RotatePhoto;
        processor.Process("MyPhoto.jpg", filterHandler);
    }
    static void RemoveRedEye(Photo photo)
    {
        Console.WriteLine("Red eye remove.");
    }
    static void RotatePhoto(Photo photo)
    {
        Console.WriteLine("Rotates photo.");
    }
}
