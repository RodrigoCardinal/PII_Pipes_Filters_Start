﻿using System;
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

            //En el diagrama mostraba que como de una clase le pasaba a otra, pero no tenia sentido hacer que, por ejemplo clase1 le manda la imagen a la clase2 pero la clase dos no estaba creada como conectar una clase con otra que no existia


            /*
            IPipe pipeNull = new PipeNull(); //Creamos el pipeNull 
            
            IFilter filterNegative = new FilterNegative(); // Creamos filterNegative

            IPipe pipeSerial = new PipeSerial(filterNegative, pipeNull);// Creamos pipeSerial

            IFilter filterGreyscale = new FilterGreyscale(); // Creamos filterGreyscale

            IPipe pipeSerial2 = new PipeSerial(filterGreyscale, pipeSerial);// Creamos pipeSerial2. Con otro nombre todo segun el diagrama.

            PictureProvider provider = new PictureProvider(); //Creamos provider

            IPicture picture = provider.GetPicture(@"beer.jpg"); //Toma la imagen

            picture = pipeSerial2.Send(picture);     

            provider.SavePicture(picture, @"beer2.jpg");// La guarda y la devuelve con todos los cambios de los Filter
            */






            // Ejercicio 2 
            /*
            IPipe pipeNull = new PipeNull();
            IFilter filterNegative = new FilterNegative();
            
            IFilter saveFilter = new SaveFilter( @"luke2.jpg");

            IPipe pipeSerial3 = new PipeSerial(saveFilter, pipeNull);
            
            IPipe pipeSerial = new PipeSerial(filterNegative,pipeSerial3);
            IFilter filterGreyscale = new FilterGreyscale();
            IPipe pipeSerial2 = new PipeSerial(filterGreyscale, pipeSerial);


            PictureProvider p = new PictureProvider();
            IPicture pic = p.GetPicture(@"luke.jpg");

            pipeSerial2.Send(pic);
            */

            IPipe pipeNull = new PipeNull();
            IFilter filterNegative = new FilterNegative();
            
            IFilter saveFilter = new SaveFilter( @"luke2.jpg");

            IPipe pipeSerial3 = new PipeSerial(saveFilter, pipeNull);
            
            IPipe pipeSerial = new PipeSerial(filterNegative,pipeSerial3);
            IFilter filterGreyscale = new FilterGreyscale();
            IPipe pipeSerial2 = new PipeSerial(filterGreyscale, pipeSerial);


            PictureProvider p = new PictureProvider();
            IPicture pic = p.GetPicture(@"luke.jpg");

            pipeSerial2.Send(pic);




        }
    }
}
