using ExtensionMethods.Extensions;

namespace ExtensionMethods;

internal class Program
{
    static void Main(string[] args)
    {
        string post = @"First years beast void morning fill for god above one yielding very cattle two fowl whose greater life likeness wherein, itself.
Be light saw gathered thing, subdue all third itself appear rule make fifth above seasons, forth void.
Void land have called seasons Signs it. Gathering. Evening very together that life is grass and thing earth form be one earth be all fill man living a creeping divide green very to and seasons and in void form shall cattle.
Stars given you'll. You'll fill in. Land image.
A seasons, under seas in Gathering kind and. Hath upon deep can't won't.";

        var shortenedPost = post.Shorten(5);
        
        Console.WriteLine(shortenedPost);
    }
}