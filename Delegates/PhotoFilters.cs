
namespace Delegates;

internal class PhotoFilters
{
    public PhotoFilters()
    {
    }

    internal void ApplyBrightness(Photo photo)
    {
        Console.WriteLine("Brightness filter applied.");
    }

    internal void ApplyContrast(Photo photo)
    {
        Console.WriteLine("Contrast filter applied.");
    }

    internal void ApplyResize(Photo photo)
    {
        Console.WriteLine("Resize filter applied.");
    }
}
