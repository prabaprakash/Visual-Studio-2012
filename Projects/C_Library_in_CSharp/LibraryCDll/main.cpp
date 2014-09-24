#include "C:\Users\PrabaKarthi\Documents\visual studio 2012\Projects\C_Library_in_CSharp\LibraryC\Praba.H"
#include "C:\Users\PrabaKarthi\Documents\visual studio 2012\Projects\C_Library_in_CSharp\LibraryC\body.cpp"

extern "C" _declspec(dllexport) char removeredun(char  c[])
{
	RegularExpessions rg;
	return rg.RemoveRedundant(c);
}