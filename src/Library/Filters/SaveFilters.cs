using System.Drawing;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;


namespace CompAndDel.Filters
{
    public class SaveFilter : IFilter.Filter(IPicture)
    {
        private PictureProvider provider;

 

        public string GeneratePath (string path)
        {
            Picture picture = new Picture(1, 1);
            using (var image = Image.Load<Rgba32>(path))
            {
                picture.Resize(image.Width, image.Height);
                for (int h = 0; h < image.Height; h++)
                {
                    for (int w = 0; w <image.Width; w++)
                    {
                        picture.SetColor(w, h, System.Drawing.Color.FromArgb(image[w, h].A, image[w, h].R, image[w, h].G, image[w, h].B));
                    }
                }
            }
            return path;
        }
        
        public IPicture Filter(IPicture image, string path)
        {
            provider = new PictureProvider();
            provider.SavePicture(image,path);

            return image;
        }
    } 
}
 