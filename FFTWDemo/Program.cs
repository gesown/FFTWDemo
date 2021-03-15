using System;
using System.IO;
using System.Numerics;
using FFTW.NET;
using FFTWDemo.Facade;
using System.Linq;

namespace FFTWDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileIn = args[0];
            string fileOutR = fileIn + "_Real.txt";
            if (File.Exists(fileOutR))
            {
                File.Delete(fileOutR);
            }
            var sr = new StreamWriter(fileOutR);
            string fileOutI = fileIn + "_Imag.txt";
            if (File.Exists(fileOutI))
            {
                File.Delete(fileOutI);
            }
            var si = new StreamWriter(fileOutI);
            string fileOutA = fileIn + "_Abs.txt";
            if (File.Exists(fileOutA))
            {
                File.Delete(fileOutA);
            }
            var sa = new StreamWriter(fileOutA);
           var fftADIn = FFTWFacade.GetInputArray(fileIn);
           var fftADOut = FFTWFacade.GetOutPutArray(fftADIn);
           var fftADOR = fftADOut.Real;
           var fftADOI = fftADOut.Imag;
           var fftADOA = fftADOut.Abs;
           for (int i = 0; i < fftADOR.Length; i++)
           {
               sr.WriteLine( fftADOR[i]);
           }
           for (int i = 0; i < fftADOR.Length; i++)
           {
               si.WriteLine(fftADOI[i]);
           }
           for (int i = 0; i < fftADOR.Length; i++)
           {
               sa.WriteLine(fftADOA[i]);
           }

           sr.Flush();
           sr.Close();
           si.Flush();
           si.Close();
           sa.Flush();
           sa.Close();
        }
    }

}
