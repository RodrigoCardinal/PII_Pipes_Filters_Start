using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1 Hecho
            IPipe pipeNull = new PipeNull();
            IFilter filterNegative = new FilterNegative();
            IPipe pipeSerial = new PipeSerial(filterNegative, pipeNull);
            IFilter filterGreyscale = new FilterGreyscale();
            IPipe pipeSerial2 = new PipeSerial(filterGreyscale, pipeSerial);
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"beer.jpg");
            picture = pipeSerial2.Send(picture);       
            provider.SavePicture(picture, @"beer2.jpg");
            // Ejercicio 2 

            
        }
    }
}
