﻿
namespace Delegates;

public class PhotoProcessor
{
    public void Process(string path)
    {
        var photo = Photo.Load(path);

        var filters = new PhotoFilters();
        filters.ApplyBrightness(photo);
        filters.ApplyContrast(photo);
        filters.ApplyResize(photo);

        photo.Save();
    }
}
