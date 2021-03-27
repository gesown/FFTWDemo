# c# FFTWDemo
FFTDemo creates Complex Array Files from a Signal File presenting lines of Text set as a Command Line Parameter. Usage:  FFTDemo.exe {signal file.} The input file must contain lines of strings representing numbers parseable as doubles.

The project incorporates an FFTW based class commented as sourced from Henning Pohl's DanceStixUtil. Obtain the required FFTW library assembly, libfftw3-3.dll, from http://fftw.org/install/windows.html.

Program methods execute through a static facade class as:  GetInputArray (from file provided), and GetOutPutArray (from  array of doubles returned from input method.) The main program records the complex FFT results in three files, one per dimension.

The three output files include string values from the complex arrays generated using the FFTW->Forward Transform method, with names having a suffix added reflecting the component of the complex data: Real, Imaginary, and Absolute.

Note that the frequency bin spacing of output arrays can be calculated using the ratio of (Signal Sample Rate)/(Number Of Samples -- contained in the input array.)  The first bin always represents "0" frequency.  A spectrum plot can be generated most effectively using the Abs file combined with frequency labels generated for sequential bins. In addition, the second half of all output arrarys will contain zero due to the nature of FFT processing.
