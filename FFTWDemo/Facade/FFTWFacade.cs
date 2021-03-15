using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FFTWDemo.Facade
{
    public static  class FFTWFacade
    {
        public static Entity.FFTW.ComplexArray GetOutPutArray(Entity.FFTW.DoubleArray arrayIn)
        {
            Entity.FFTW.DoubleArray input = arrayIn;
            Entity.FFTW.ComplexArray output=new Entity.FFTW.ComplexArray(arrayIn.Length);
            Entity.FFTW.ForwardTransform(input,output); 
            return output;
        }

        public static Entity.FFTW.DoubleArray GetInputArray(string fileIn)
        {
            IList<string> dataIn = File.ReadAllLines(fileIn);
            IList<double> dataInDouble = new List<double>();
            foreach (var s in dataIn)
            {
                dataInDouble.Add(double.Parse(s));
            }
            Entity.FFTW.DoubleArray retValue =new Entity.FFTW.DoubleArray(dataInDouble.ToArray()); // not complex numbers
            return retValue;
        }
    }
}
