using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {

            static void ParteI()
            {
                PictureProvider provider = new PictureProvider();
                IPicture picture = provider.GetPicture(@"beer.jpg");
                PipeNull pipeNull = new PipeNull();
                FilterNegative filterNegative = new FilterNegative();
                PipeSerial pipeSerial = new PipeSerial(filterNegative, pipeNull);
                FilterGreyscale filterGreyscale = new FilterGreyscale();
                PipeSerial pipeSerial1 = new PipeSerial(filterGreyscale, pipeNull);
            }

            static void ParteII()
            {
                PictureProvider p = new PictureProvider();
                IPicture picture = p.GetPicture(@"beer.jpg");
IPicture        pic = p.SavePicture(picture, @"beer.jpg");
            }
        }
    }
}
