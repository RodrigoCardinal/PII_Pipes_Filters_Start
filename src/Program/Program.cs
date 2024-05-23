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
            //Tener en cuenta que para realizar el ejercicio debiamos empezar desde el final del diagrama (PipeNull)

            /*
            IPipe pipeNull = new PipeNull(); //Creamos el pipeNull 
            
            IFilter filterNegative = new FilterNegative(); // Creamos filterNegative

            IPipe pipeSerial = new PipeSerial(filterNegative, pipeNull);// Creamos pipeSerial

            IFilter filterGreyscale = new FilterGreyscale(); // Creamos filterGreyscale

            IPipe pipeSerial2 = new PipeSerial(filterGreyscale, pipeSerial);// Creamos pipeSerial2. Con otro nombre todo segun el diagrama.

            PictureProvider provider = new PictureProvider(); //Creamos provider

            IPicture picture = provider.GetPicture(@"beer.jpg");

            picture = pipeSerial2.Send(picture);     

            provider.SavePicture(picture, @"beer2.jpg");
            */


            // Ejercicio 2 

            IPipe pipeNull = new PipeNull();
            IFilter filterNegative = new FilterNegative();
            IPipe pipeSerial = new PipeSerial(filterNegative, pipeNull);
            IFilter filterGreyscale = new FilterGreyscale();
            IPipe pipeSerial2 = new PipeSerial(filterGreyscale, pipeSerial);
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"beer.jpg");
            picture = pipeSerial2.Send(picture);       
            provider.SavePicture(picture, @"beer2.jpg");




        }
    }
}
