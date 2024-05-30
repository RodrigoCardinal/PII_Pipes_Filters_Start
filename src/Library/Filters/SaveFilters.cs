using System.Drawing;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;


namespace CompAndDel.Filters
{
    public class SaveFilter : IFilter
    {
        private PictureProvider provider;
        public string path;
    public SaveFilter( string Path)
    {
        this.provider = new PictureProvider();
        this.path = Path;

        return;
    }

        public IPicture Filter(IPicture image)
        {
            provider = new PictureProvider();
            provider.SavePicture(image, path);

            return image;
        }
    } 
}
 