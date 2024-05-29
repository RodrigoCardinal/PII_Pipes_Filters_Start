using System.Drawing;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;


namespace CompAndDel.Filters
{
    public class SaveFilter : IFilter
    {
        private PictureProvider provider;
        public string path;
    public SaveFilter(PictureProvider Provider, string Path)
    {



    }

        
        public IPicture Filter(IPicture image)
        {
            provider = new PictureProvider();
            provider.SavePicture(image,path);

            return image;
        }
    } 
}
 