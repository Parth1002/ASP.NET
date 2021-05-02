// VCTestApp.cpp : main project file.
#include "stdafx.h"
using namespace System;
public class SimpleClass
{
	public:
	void simpleMethod()
	{
		Console::WriteLine("A simple method");
	}
};
int main(array<System::String ^> ^args)
{
	SimpleClass simpleObject;
	simpleObject.simpleMethod();
	return 0;
}
