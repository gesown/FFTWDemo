# c# FFTWDemo
FFTDemo creates Complex Array Files from a Signal File presented as single lines of Text set as a Command Line Parameter.

The project incorporates an FFTW based class commented as sourced from Henning Pohl's DanceStixUtil. Obtain libfftw3-3.dll from http://fftw.org/install/windows.html.

Program methods execute through a static facade class:  GetInputArray (from file provided), and GetOutPutArray (from  array of doubles returned from input method.)

Output files include string values from the complex arrays generated using the FFTW->Forward Transform method, with names having a suffix added reflecting the component of the complex data: Real, Imaginary, and Absolute.

Note that bin spacing of output arrays can be calculated using the ratio of SampleRate/NumberOfSamples.  The first bin always represents "0" frequency.  A spectrum plot can be generated most effectively using the Abs file combined with frequency labels generated for sequential bins.
